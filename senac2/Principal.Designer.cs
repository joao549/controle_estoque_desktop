namespace senac2
{
    partial class Principal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pnl_buttons = new System.Windows.Forms.Panel();
            this.btn_excluir = new System.Windows.Forms.Button();
            this.btn_xml = new System.Windows.Forms.Button();
            this.btn_adicionar = new System.Windows.Forms.Button();
            this.btn_editar = new System.Windows.Forms.Button();
            this.btn_visualizar = new System.Windows.Forms.Button();
            this.btn_fechar = new System.Windows.Forms.Button();
            this.panel_titulo = new System.Windows.Forms.Panel();
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.data = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imagemDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.produtosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.senacDataSet = new senac2.senacDataSet1();
            this.txt_pesquisa = new System.Windows.Forms.TextBox();
            this.btn_pesquisar = new System.Windows.Forms.Button();
            this.produtosTableAdapter = new senac2.senacDataSet1TableAdapters.produtosTableAdapter();
            this.pnl_buttons.SuspendLayout();
            this.panel_titulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.senacDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_buttons
            // 
            this.pnl_buttons.Controls.Add(this.btn_excluir);
            this.pnl_buttons.Controls.Add(this.btn_xml);
            this.pnl_buttons.Controls.Add(this.btn_adicionar);
            this.pnl_buttons.Controls.Add(this.btn_editar);
            this.pnl_buttons.Controls.Add(this.btn_visualizar);
            this.pnl_buttons.Controls.Add(this.btn_fechar);
            this.pnl_buttons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_buttons.Location = new System.Drawing.Point(0, 406);
            this.pnl_buttons.Name = "pnl_buttons";
            this.pnl_buttons.Size = new System.Drawing.Size(779, 44);
            this.pnl_buttons.TabIndex = 0;
            // 
            // btn_excluir
            // 
            this.btn_excluir.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_excluir.Location = new System.Drawing.Point(-1, 0);
            this.btn_excluir.Name = "btn_excluir";
            this.btn_excluir.Size = new System.Drawing.Size(130, 44);
            this.btn_excluir.TabIndex = 5;
            this.btn_excluir.Text = "EXCLUIR";
            this.btn_excluir.UseVisualStyleBackColor = true;
            this.btn_excluir.Click += new System.EventHandler(this.btn_excluir_Click);
            // 
            // btn_xml
            // 
            this.btn_xml.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_xml.Location = new System.Drawing.Point(129, 0);
            this.btn_xml.Name = "btn_xml";
            this.btn_xml.Size = new System.Drawing.Size(130, 44);
            this.btn_xml.TabIndex = 4;
            this.btn_xml.Text = "GERAR XML";
            this.btn_xml.UseVisualStyleBackColor = true;
            this.btn_xml.Click += new System.EventHandler(this.btn_xml_Click);
            // 
            // btn_adicionar
            // 
            this.btn_adicionar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_adicionar.Location = new System.Drawing.Point(259, 0);
            this.btn_adicionar.Name = "btn_adicionar";
            this.btn_adicionar.Size = new System.Drawing.Size(130, 44);
            this.btn_adicionar.TabIndex = 3;
            this.btn_adicionar.Text = "ADICIONAR";
            this.btn_adicionar.UseVisualStyleBackColor = true;
            this.btn_adicionar.Click += new System.EventHandler(this.btn_adicionar_Click);
            // 
            // btn_editar
            // 
            this.btn_editar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_editar.Location = new System.Drawing.Point(389, 0);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(130, 44);
            this.btn_editar.TabIndex = 2;
            this.btn_editar.Text = "EDITAR";
            this.btn_editar.UseVisualStyleBackColor = true;
            this.btn_editar.Click += new System.EventHandler(this.btn_editar_Click);
            // 
            // btn_visualizar
            // 
            this.btn_visualizar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_visualizar.Location = new System.Drawing.Point(519, 0);
            this.btn_visualizar.Name = "btn_visualizar";
            this.btn_visualizar.Size = new System.Drawing.Size(130, 44);
            this.btn_visualizar.TabIndex = 1;
            this.btn_visualizar.Text = "VISUALIZAR";
            this.btn_visualizar.UseVisualStyleBackColor = true;
            this.btn_visualizar.Click += new System.EventHandler(this.btn_visualizar_Click);
            // 
            // btn_fechar
            // 
            this.btn_fechar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_fechar.Location = new System.Drawing.Point(649, 0);
            this.btn_fechar.Name = "btn_fechar";
            this.btn_fechar.Size = new System.Drawing.Size(130, 44);
            this.btn_fechar.TabIndex = 0;
            this.btn_fechar.Text = "FECHAR";
            this.btn_fechar.UseVisualStyleBackColor = true;
            this.btn_fechar.Click += new System.EventHandler(this.btn_fechar_Click);
            // 
            // panel_titulo
            // 
            this.panel_titulo.Controls.Add(this.lbl_titulo);
            this.panel_titulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_titulo.Location = new System.Drawing.Point(0, 0);
            this.panel_titulo.Name = "panel_titulo";
            this.panel_titulo.Size = new System.Drawing.Size(779, 37);
            this.panel_titulo.TabIndex = 1;
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbl_titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo.Location = new System.Drawing.Point(0, 0);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(169, 31);
            this.lbl_titulo.TabIndex = 0;
            this.lbl_titulo.Text = "PRODUTOS";
            // 
            // data
            // 
            this.data.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.data.AutoGenerateColumns = false;
            this.data.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn1,
            this.descricaoDataGridViewTextBoxColumn,
            this.unidadeDataGridViewTextBoxColumn,
            this.valorDataGridViewTextBoxColumn,
            this.quantidadeDataGridViewTextBoxColumn,
            this.imagemDataGridViewImageColumn});
            this.data.DataSource = this.produtosBindingSource;
            this.data.Location = new System.Drawing.Point(6, 98);
            this.data.Name = "data";
            this.data.Size = new System.Drawing.Size(761, 302);
            this.data.TabIndex = 2;
            this.data.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_CellDoubleClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "nome";
            this.dataGridViewTextBoxColumn1.HeaderText = "nome";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // descricaoDataGridViewTextBoxColumn
            // 
            this.descricaoDataGridViewTextBoxColumn.DataPropertyName = "descricao";
            this.descricaoDataGridViewTextBoxColumn.HeaderText = "descricao";
            this.descricaoDataGridViewTextBoxColumn.Name = "descricaoDataGridViewTextBoxColumn";
            // 
            // unidadeDataGridViewTextBoxColumn
            // 
            this.unidadeDataGridViewTextBoxColumn.DataPropertyName = "unidade";
            this.unidadeDataGridViewTextBoxColumn.HeaderText = "unidade";
            this.unidadeDataGridViewTextBoxColumn.Name = "unidadeDataGridViewTextBoxColumn";
            // 
            // valorDataGridViewTextBoxColumn
            // 
            this.valorDataGridViewTextBoxColumn.DataPropertyName = "valor";
            this.valorDataGridViewTextBoxColumn.HeaderText = "valor";
            this.valorDataGridViewTextBoxColumn.Name = "valorDataGridViewTextBoxColumn";
            // 
            // quantidadeDataGridViewTextBoxColumn
            // 
            this.quantidadeDataGridViewTextBoxColumn.DataPropertyName = "quantidade";
            this.quantidadeDataGridViewTextBoxColumn.HeaderText = "quantidade";
            this.quantidadeDataGridViewTextBoxColumn.Name = "quantidadeDataGridViewTextBoxColumn";
            // 
            // imagemDataGridViewImageColumn
            // 
            this.imagemDataGridViewImageColumn.DataPropertyName = "imagem";
            this.imagemDataGridViewImageColumn.HeaderText = "imagem";
            this.imagemDataGridViewImageColumn.Name = "imagemDataGridViewImageColumn";
            // 
            // produtosBindingSource
            // 
            this.produtosBindingSource.DataMember = "produtos";
            this.produtosBindingSource.DataSource = this.senacDataSet;
            // 
            // senacDataSet
            // 
            this.senacDataSet.DataSetName = "senacDataSet";
            this.senacDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txt_pesquisa
            // 
            this.txt_pesquisa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_pesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pesquisa.Location = new System.Drawing.Point(6, 54);
            this.txt_pesquisa.Name = "txt_pesquisa";
            this.txt_pesquisa.Size = new System.Drawing.Size(625, 38);
            this.txt_pesquisa.TabIndex = 3;
            // 
            // btn_pesquisar
            // 
            this.btn_pesquisar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_pesquisar.Location = new System.Drawing.Point(637, 54);
            this.btn_pesquisar.Name = "btn_pesquisar";
            this.btn_pesquisar.Size = new System.Drawing.Size(130, 38);
            this.btn_pesquisar.TabIndex = 4;
            this.btn_pesquisar.Text = "PESQUISAR";
            this.btn_pesquisar.UseVisualStyleBackColor = true;
            this.btn_pesquisar.Click += new System.EventHandler(this.btn_pesquisar_Click);
            // 
            // produtosTableAdapter
            // 
            this.produtosTableAdapter.ClearBeforeFill = true;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 450);
            this.Controls.Add(this.btn_pesquisar);
            this.Controls.Add(this.txt_pesquisa);
            this.Controls.Add(this.data);
            this.Controls.Add(this.panel_titulo);
            this.Controls.Add(this.pnl_buttons);
            this.Name = "Principal";
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.Principal_Load);
            this.pnl_buttons.ResumeLayout(false);
            this.panel_titulo.ResumeLayout(false);
            this.panel_titulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.senacDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_buttons;
        private System.Windows.Forms.Panel panel_titulo;
        private System.Windows.Forms.Button btn_xml;
        private System.Windows.Forms.Button btn_adicionar;
        private System.Windows.Forms.Button btn_editar;
        private System.Windows.Forms.Button btn_visualizar;
        private System.Windows.Forms.Button btn_fechar;
        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.Button btn_excluir;
        private System.Windows.Forms.DataGridView data;
        private System.Windows.Forms.TextBox txt_pesquisa;
        private System.Windows.Forms.Button btn_pesquisar;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private senacDataSet1 senacDataSet;
        private System.Windows.Forms.BindingSource produtosBindingSource;
        private senacDataSet1TableAdapters.produtosTableAdapter produtosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn imagemDataGridViewImageColumn;
    }
}

