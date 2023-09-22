using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
                Detalhes detalhes = new Detalhes();
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
                Detalhes detalhes = new Detalhes();
                detalhes.principal = this;
                detalhes.txt_id.Text = Convert.ToString(data[0, data.CurrentRow.Index].Value);
                detalhes.txt_nome.Text = Convert.ToString(data[1, data.CurrentRow.Index].Value);
                detalhes.txt_desc.Text = Convert.ToString(data[2, data.CurrentRow.Index].Value);
                detalhes.combo_unidade.Text = Convert.ToString(data[3, data.CurrentRow.Index].Value);
                detalhes.txt_qtd.Text = Convert.ToString(data[4, data.CurrentRow.Index].Value);
                detalhes.txt_valor.Text = Convert.ToString(data[5, data.CurrentRow.Index].Value);
                detalhes.Show();
            }
            else
            {
                MessageBox.Show("Informe um item a editar", "Nenhum item selecionado para edição", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_adicionar_Click(object sender, EventArgs e)
        {
            Detalhes detalhes = new Detalhes();
            detalhes.principal = this;
            detalhes.Show();
        }

        private void btn_xml_Click(object sender, EventArgs e)
        {

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
            if (e.RowIndex >= 0 && !data.Rows[e.RowIndex].IsNewRow)
            {
                Detalhes detalhes = new Detalhes();
                //DESABILITA OS BOTÕES NA VISUALIZAÇÃO
                detalhes.btn_gravar.Enabled = false;
                detalhes.btn_cancelar.Enabled = false;
                detalhes.btn_imagem.Enabled = false;
                detalhes.txt_id.Enabled = false;
                detalhes.txt_desc.Enabled = false;
                detalhes.txt_valor.Enabled = false;
                detalhes.combo_unidade.Enabled = false;
                detalhes.txt_nome.Enabled = false;
                detalhes.txt_qtd.Enabled = false;
                //MOSTRA OS DADOS DO DATAGRIVIEW
                detalhes.txt_id.Text = data.Rows[e.RowIndex].Cells[0].Value.ToString();
                detalhes.txt_nome.Text = data.Rows[e.RowIndex].Cells[1].Value.ToString();
                detalhes.txt_desc.Text = data.Rows[e.RowIndex].Cells[2].Value.ToString();
                detalhes.combo_unidade.Text = data.Rows[e.RowIndex].Cells[3].Value.ToString();
                detalhes.txt_qtd.Text = data.Rows[e.RowIndex].Cells[4].Value.ToString();
                detalhes.txt_valor.Text = data.Rows[e.RowIndex].Cells[5].Value.ToString();

                if (detalhes.ShowDialog() == DialogResult.OK)
                {
                    detalhes.Show();
                    EditRow(e.RowIndex, detalhes.txt_id.Text, detalhes.txt_nome.Text, detalhes.txt_desc.Text, detalhes.combo_unidade.Text, detalhes.txt_qtd.Text, detalhes.txt_valor.Text);
                }
            }
        }

        public void EditRow(int idx, string id, string nome, string desc, string unidade, string qtd, string vlr)
        {
            //DEFINE OS CAMPOS DA DATAGRIDVIEW PARA O DETALHES
            data.Rows[idx].Cells[0].Value = id;
            data.Rows[idx].Cells[1].Value = nome;
            data.Rows[idx].Cells[2].Value = desc;
            data.Rows[idx].Cells[3].Value = unidade;
            data.Rows[idx].Cells[4].Value = qtd;
            data.Rows[idx].Cells[5].Value = vlr;
        }
    }
}
