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

namespace senac2
{
    public partial class Detalhes : Form
    {
        public Principal principal { get; set; }
        public Detalhes()
        {
            InitializeComponent();
        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_gravar_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Passou aqui");
            SqlConnection conn = new SqlConnection(@"Data Source=JOAO-ELIAS\SQLEXPRESS; Initial Catalog=senac;Integrated Security=True");
            string sqladd = "INSERT INTO produtos (nome, descricao, unidade, valor, quantidade, imagem) VALUES(@nome, @descricao, @unidade, @valor, @quantidade, @imagem)";
            string sqlupdt = "UPDATE produtos set nome=@nome, descricao=@descricao, valor=@valor, quantidade=@quantidade, imagem=@imagem where id=@id";
            
            //MessageBox.Show("Passou aqui");
            if (string.IsNullOrEmpty(txt_id.Text))
            {
                {
                    try
                    {
                        SqlCommand comando = new SqlCommand(sqladd, conn);
                        comando.Parameters.Add(new SqlParameter("@nome", txt_nome.Text));
                        comando.Parameters.Add(new SqlParameter("@descricao", txt_desc.Text));
                        comando.Parameters.Add(new SqlParameter("@unidade", combo_unidade.Text));
                        comando.Parameters.Add(new SqlParameter("@valor", txt_valor.Text));
                        comando.Parameters.Add(new SqlParameter("@quantidade", txt_qtd.Text));
                        if(pictureBox1 != null)
                        {
                            MemoryStream memstr = new MemoryStream();
                            pictureBox1.Image.Save(memstr, pictureBox1.Image.RawFormat);
                            comando.Parameters.AddWithValue("@imagem", memstr.ToArray());
                        }
                        conn.Open();
                        comando.ExecuteNonQuery();
                        conn.Close();
                        MessageBox.Show("Deu certo");
                        principal.AtualizarDataGridView();
                        Limpacampos();


                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show("Não deu certo" + ex.Message);
                    }
                }
            }
            else if (!string.IsNullOrEmpty(txt_id.Text))
            {
                try
                {
                    SqlCommand comando = new SqlCommand(sqlupdt, conn);
                    comando.Parameters.AddWithValue("@id", txt_id.Text);
                    comando.Parameters.AddWithValue("@nome", txt_nome.Text);
                    comando.Parameters.AddWithValue("@descricao", txt_desc.Text);
                    comando.Parameters.AddWithValue("@unidade", combo_unidade.Text);
                    comando.Parameters.AddWithValue("@quantidade", txt_qtd.Text);
                    comando.Parameters.AddWithValue("@valor", txt_valor.Text);
                    if (pictureBox1 != null)
                    {
                        MemoryStream memstr = new MemoryStream();
                        pictureBox1.Image.Save(memstr, pictureBox1.Image.RawFormat);
                        comando.Parameters.AddWithValue("@imagem", memstr.ToArray());
                    }
                    else 
                    {
                        comando.Parameters.AddWithValue("@imagem", DBNull.Value);
                    }
                    conn.Open();
                    comando.ExecuteNonQuery();
                    conn.Close();
                    principal.AtualizarDataGridView();
                    Close();


                }
                catch (Exception ex)
                {
                    MessageBox.Show("" + ex);
                }
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
           DialogResult result = MessageBox.Show("Deseja Cancelar a inserção/Edição do item selcionado?", "Aviso", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Limpacampos();
                Close();
            }
        }

        private void btn_imagem_Click(object sender, EventArgs e)
        {
            Arquivos.Filter = "*.Jpeg; *.png; *.Gif;| *.Jpeg; *.png; *.Gif";
            if(Arquivos.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(Arquivos.FileName);
            }
        }
        private void Limpacampos()
        {
            txt_nome.Text = "";
            txt_desc.Text = "";
            combo_unidade.Text = "";
            txt_qtd.Text = "";
            txt_valor.Text = "";
        }
    }
}
