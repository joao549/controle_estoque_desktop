using senac2.senacDataSet1TableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace senac2
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }
        
        public void AtualizarDataGridView()
        {
            produtosTableAdapter.Fill(senacDataSet.produtos);
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            produtosTableAdapter.Fill(senacDataSet.produtos);
        }

        private void btn_pesquisar_Click(object sender, EventArgs e)
        {
            string searchTerm = txt_pesquisa.Text;



            foreach (DataGridViewRow row in data.Rows)
            {
                if (!row.IsNewRow)
                {
                    bool found = false;
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        if (cell.Value != null && cell.Value.ToString().Contains(searchTerm))
                        {
                            found = true;
                            break;
                        }
                    }

                    row.Visible = found;
                }
            }

        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_visualizar_Click(object sender, EventArgs e)
        {
            if (data.CurrentRow != null)
            {
                Detalhes detalhes = Detalhes.GetInstance();
                detalhes.btn_gravar.Enabled = false;
                detalhes.btn_cancelar.Enabled = false;
                detalhes.btn_imagem.Enabled = false;
                detalhes.txt_id.Enabled = false;
                detalhes.txt_desc.Enabled = false;
                detalhes.txt_valor.Enabled = false;
                detalhes.combo_unidade.Enabled = false;
                detalhes.txt_nome.Enabled = false;
                detalhes.txt_qtd.Enabled = false;

                //

                detalhes.txt_id.Text = Convert.ToString(data[0, data.CurrentRow.Index].Value);
                detalhes.txt_nome.Text = Convert.ToString(data[1, data.CurrentRow.Index].Value);
                detalhes.txt_desc.Text = Convert.ToString(data[2, data.CurrentRow.Index].Value);
                detalhes.combo_unidade.Text = Convert.ToString(data[3, data.CurrentRow.Index].Value);
                detalhes.txt_qtd.Text = Convert.ToString(data[4, data.CurrentRow.Index].Value);
                detalhes.txt_valor.Text = Convert.ToString(data[5, data.CurrentRow.Index].Value);
                byte[] imagemBytes = BuscarImagemDoBanco(detalhes.txt_id.Text);
                if (imagemBytes != null && imagemBytes.Length > 0)
                {
                    using (MemoryStream memstr = new MemoryStream(imagemBytes))
                    {
                        detalhes.pictureBox1.Image = Image.FromStream(memstr);
                    }
                }

                detalhes.Show();

            }
            else
            {
                MessageBox.Show("Informe o item a visualizar", "Nenhum item selecionado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            if (data.CurrentRow != null)
            {
                Detalhes detalhes = Detalhes.GetInstance();
                detalhes.principal = this;
                detalhes.txt_id.Text = Convert.ToString(data[0, data.CurrentRow.Index].Value);
                detalhes.txt_nome.Text = Convert.ToString(data[1, data.CurrentRow.Index].Value);
                detalhes.txt_desc.Text = Convert.ToString(data[2, data.CurrentRow.Index].Value);
                detalhes.combo_unidade.Text = Convert.ToString(data[3, data.CurrentRow.Index].Value);
                detalhes.txt_qtd.Text = Convert.ToString(data[4, data.CurrentRow.Index].Value);
                detalhes.txt_valor.Text = Convert.ToString(data[5, data.CurrentRow.Index].Value);
                byte[] imagemBytes = BuscarImagemDoBanco(detalhes.txt_id.Text);
                if (imagemBytes != null && imagemBytes.Length > 0)
                {
                    using (MemoryStream memstr = new MemoryStream(imagemBytes))
                    {
                        detalhes.pictureBox1.Image = Image.FromStream(memstr);
                    }
                }

                detalhes.Show();
            }
            else
            {
                MessageBox.Show("Informe um item a editar", "Nenhum item selecionado para edição", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_adicionar_Click(object sender, EventArgs e)
        {
            Detalhes detalhes = Detalhes.GetInstance();
            detalhes.principal = this;
            detalhes.Show();
        }

        private void btn_xml_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=JOAO-ELIAS\SQLEXPRESS; Initial Catalog=senac;Integrated Security=True");

            try
            {
                con.Open();

                string sql = "SELECT * FROM produtos";
                SqlCommand cmd = new SqlCommand(sql, con);
                List<Produtos> produtos = new List<Produtos>();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Produtos produto = new Produtos
                        {
                            Nome = reader["nome"].ToString(),
                            Descricao = reader["descricao"].ToString(),
                            Unidade = reader["unidade"].ToString(),
                            Valor = reader["valor"].ToString(),
                            Quantidade = reader["quantidade"].ToString(),
                            Imagem = (byte[])reader["imagem"]
                    };

                        produtos.Add(produto);
                    }
                }

                string caminhoDoArquivo = @"C:\XML\produtos.xml";

                // Verifica se o diretório existe, se não, cria
                string diretorio = Path.GetDirectoryName(caminhoDoArquivo);
                if (!Directory.Exists(diretorio))
                {
                    Directory.CreateDirectory(diretorio);
                }

                // Continua com a serialização e gravação do arquivo XML
                XmlSerializer serializer = new XmlSerializer(typeof(List<Produtos>));

                using (FileStream fs = new FileStream(caminhoDoArquivo, FileMode.Create))
                {
                    serializer.Serialize(fs, produtos);
                }

                MessageBox.Show("Arquivo XML gerado com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao gerar XML: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            if (data.CurrentRow != null)
            {
                string id = Convert.ToString(data[0, data.CurrentRow.Index].Value);
                DialogResult result = MessageBox.Show("Tem certeza que deseja excluir este item?", "Confirmação de Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    using (SqlConnection connection = new SqlConnection(@"Data Source=JOAO-ELIAS\SQLEXPRESS; Initial Catalog=senac;Integrated Security=True"))
                    {
                        connection.Open();
                        SqlCommand cmd = new SqlCommand("DELETE FROM produtos WHERE id = @id", connection);
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.ExecuteNonQuery();
                    }
                    data.Rows.RemoveAt(data.CurrentRow.Index);
                    MessageBox.Show("Item excluído com sucesso!", "Exclusão bem-sucedida", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecione um item para excluir.", "Nenhum item selecionado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void data_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (data.CurrentRow != null)
            {
                Detalhes detalhes = Detalhes.GetInstance();
                detalhes.btn_gravar.Enabled = false;
                detalhes.btn_cancelar.Enabled = false;
                detalhes.btn_imagem.Enabled = false;
                detalhes.txt_id.Enabled = false;
                detalhes.txt_desc.Enabled = false;
                detalhes.txt_valor.Enabled = false;
                detalhes.combo_unidade.Enabled = false;
                detalhes.txt_nome.Enabled = false;
                detalhes.txt_qtd.Enabled = false;

                //

                detalhes.txt_id.Text = Convert.ToString(data[0, data.CurrentRow.Index].Value);
                detalhes.txt_nome.Text = Convert.ToString(data[1, data.CurrentRow.Index].Value);
                detalhes.txt_desc.Text = Convert.ToString(data[2, data.CurrentRow.Index].Value);
                detalhes.combo_unidade.Text = Convert.ToString(data[3, data.CurrentRow.Index].Value);
                detalhes.txt_qtd.Text = Convert.ToString(data[4, data.CurrentRow.Index].Value);
                detalhes.txt_valor.Text = Convert.ToString(data[5, data.CurrentRow.Index].Value);
                byte[] imagemBytes = BuscarImagemDoBanco(detalhes.txt_id.Text);
                if (imagemBytes != null && imagemBytes.Length > 0)
                {
                    using (MemoryStream memstr = new MemoryStream(imagemBytes))
                    {
                        detalhes.pictureBox1.Image = Image.FromStream(memstr);
                    }
                }

                detalhes.Show();

            }
            else
            {
                MessageBox.Show("Informe o item a visualizar", "Nenhum item selecionado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private byte[] BuscarImagemDoBanco(string id)
        {
            using (SqlConnection conn = new SqlConnection(@"Data Source=JOAO-ELIAS\SQLEXPRESS; Initial Catalog=senac;Integrated Security=True"))
            {
                conn.Open();

                string sql = "SELECT imagem FROM produtos WHERE id = @id";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read() && reader["imagem"] != DBNull.Value)
                        {
                            return (byte[])reader["imagem"];
                        }
                    }
                }
            }

            return null; // Retorna null se não encontrar a imagem
        }
        public class Produtos
        {
            public string Nome { get; set; }
            public string Descricao { get; set; }
            public string Unidade { get; set; }
            public string Valor { get; set; }
            public string Quantidade { get; set; }
            public byte[] Imagem { get; set; }
        }

        private static Detalhes instance;
        public static Detalhes GetInstance()
        {
            if (instance == null || instance.IsDisposed)
                instance = new Detalhes();
            else
            {
                if (instance.WindowState == FormWindowState.Minimized)
                    instance.WindowState = FormWindowState.Normal;
                instance.BringToFront();
            }
            return instance;
        }

    }
}
