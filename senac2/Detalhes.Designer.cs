namespace senac2
{
    partial class Detalhes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        public System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        public void InitializeComponent()
        {
            this.txt_id = new System.Windows.Forms.TextBox();
            this.btn_fechar = new System.Windows.Forms.Button();
            this.lbl_id = new System.Windows.Forms.Label();
            this.txt_desc = new System.Windows.Forms.RichTextBox();
            this.combo_unidade = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.lbl_nome = new System.Windows.Forms.Label();
            this.panel_btns = new System.Windows.Forms.Panel();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_gravar = new System.Windows.Forms.Button();
            this.btn_imagem = new System.Windows.Forms.Button();
            this.lbl_dsc = new System.Windows.Forms.Label();
            this.lbl_unidade = new System.Windows.Forms.Label();
            this.txt_qtd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_valor = new System.Windows.Forms.Label();
            this.lbl_imagem = new System.Windows.Forms.Label();
            this.txt_valor = new System.Windows.Forms.TextBox();
            this.Arquivos = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel_btns.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(71, 43);
            this.txt_id.Name = "txt_id";
            this.txt_id.ReadOnly = true;
            this.txt_id.Size = new System.Drawing.Size(45, 20);
            this.txt_id.TabIndex = 0;
            // 
            // btn_fechar
            // 
            this.btn_fechar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_fechar.Location = new System.Drawing.Point(634, 0);
            this.btn_fechar.Name = "btn_fechar";
            this.btn_fechar.Size = new System.Drawing.Size(142, 40);
            this.btn_fechar.TabIndex = 9;
            this.btn_fechar.Text = "FECHAR";
            this.btn_fechar.UseVisualStyleBackColor = true;
            this.btn_fechar.Click += new System.EventHandler(this.btn_fechar_Click);
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Location = new System.Drawing.Point(41, 46);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(24, 13);
            this.lbl_id.TabIndex = 2;
            this.lbl_id.Text = "ID :";
            // 
            // txt_desc
            // 
            this.txt_desc.Location = new System.Drawing.Point(71, 85);
            this.txt_desc.Name = "txt_desc";
            this.txt_desc.Size = new System.Drawing.Size(686, 145);
            this.txt_desc.TabIndex = 2;
            this.txt_desc.Text = "";
            // 
            // combo_unidade
            // 
            this.combo_unidade.FormattingEnabled = true;
            this.combo_unidade.Items.AddRange(new object[] {
            "UN",
            "KG"});
            this.combo_unidade.Location = new System.Drawing.Point(127, 241);
            this.combo_unidade.Name = "combo_unidade";
            this.combo_unidade.Size = new System.Drawing.Size(45, 21);
            this.combo_unidade.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(585, 245);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(172, 149);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(169, 43);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(588, 20);
            this.txt_nome.TabIndex = 1;
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Location = new System.Drawing.Point(122, 46);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(41, 13);
            this.lbl_nome.TabIndex = 7;
            this.lbl_nome.Text = "Nome :";
            // 
            // panel_btns
            // 
            this.panel_btns.Controls.Add(this.btn_cancelar);
            this.panel_btns.Controls.Add(this.btn_gravar);
            this.panel_btns.Controls.Add(this.btn_fechar);
            this.panel_btns.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_btns.Location = new System.Drawing.Point(0, 410);
            this.panel_btns.Name = "panel_btns";
            this.panel_btns.Size = new System.Drawing.Size(776, 40);
            this.panel_btns.TabIndex = 8;
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_cancelar.Location = new System.Drawing.Point(350, 0);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(142, 40);
            this.btn_cancelar.TabIndex = 8;
            this.btn_cancelar.Text = "CANCELAR";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_gravar
            // 
            this.btn_gravar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_gravar.Location = new System.Drawing.Point(492, 0);
            this.btn_gravar.Name = "btn_gravar";
            this.btn_gravar.Size = new System.Drawing.Size(142, 40);
            this.btn_gravar.TabIndex = 7;
            this.btn_gravar.Text = "GRAVAR";
            this.btn_gravar.UseVisualStyleBackColor = true;
            this.btn_gravar.Click += new System.EventHandler(this.btn_gravar_Click);
            // 
            // btn_imagem
            // 
            this.btn_imagem.Location = new System.Drawing.Point(504, 371);
            this.btn_imagem.Name = "btn_imagem";
            this.btn_imagem.Size = new System.Drawing.Size(75, 23);
            this.btn_imagem.TabIndex = 6;
            this.btn_imagem.Text = "Add Imagem";
            this.btn_imagem.UseVisualStyleBackColor = true;
            this.btn_imagem.Click += new System.EventHandler(this.btn_imagem_Click);
            // 
            // lbl_dsc
            // 
            this.lbl_dsc.AutoSize = true;
            this.lbl_dsc.Location = new System.Drawing.Point(4, 88);
            this.lbl_dsc.Name = "lbl_dsc";
            this.lbl_dsc.Size = new System.Drawing.Size(61, 13);
            this.lbl_dsc.TabIndex = 10;
            this.lbl_dsc.Text = "Descrição :";
            // 
            // lbl_unidade
            // 
            this.lbl_unidade.AutoSize = true;
            this.lbl_unidade.Location = new System.Drawing.Point(68, 244);
            this.lbl_unidade.Name = "lbl_unidade";
            this.lbl_unidade.Size = new System.Drawing.Size(53, 13);
            this.lbl_unidade.TabIndex = 11;
            this.lbl_unidade.Text = "Unidade :";
            // 
            // txt_qtd
            // 
            this.txt_qtd.Location = new System.Drawing.Point(269, 242);
            this.txt_qtd.Name = "txt_qtd";
            this.txt_qtd.Size = new System.Drawing.Size(74, 20);
            this.txt_qtd.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(195, 244);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Quantidade :";
            // 
            // lbl_valor
            // 
            this.lbl_valor.AutoSize = true;
            this.lbl_valor.Location = new System.Drawing.Point(371, 245);
            this.lbl_valor.Name = "lbl_valor";
            this.lbl_valor.Size = new System.Drawing.Size(31, 13);
            this.lbl_valor.TabIndex = 14;
            this.lbl_valor.Text = "Valor";
            // 
            // lbl_imagem
            // 
            this.lbl_imagem.AutoSize = true;
            this.lbl_imagem.Location = new System.Drawing.Point(529, 249);
            this.lbl_imagem.Name = "lbl_imagem";
            this.lbl_imagem.Size = new System.Drawing.Size(50, 13);
            this.lbl_imagem.TabIndex = 15;
            this.lbl_imagem.Text = "Imagem :";
            // 
            // txt_valor
            // 
            this.txt_valor.Location = new System.Drawing.Point(408, 242);
            this.txt_valor.Name = "txt_valor";
            this.txt_valor.Size = new System.Drawing.Size(74, 20);
            this.txt_valor.TabIndex = 5;
            // 
            // Arquivos
            // 
            this.Arquivos.FileName = "Arquivos";
            // 
            // Detalhes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(776, 450);
            this.Controls.Add(this.txt_valor);
            this.Controls.Add(this.lbl_imagem);
            this.Controls.Add(this.lbl_valor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_qtd);
            this.Controls.Add(this.lbl_unidade);
            this.Controls.Add(this.lbl_dsc);
            this.Controls.Add(this.btn_imagem);
            this.Controls.Add(this.panel_btns);
            this.Controls.Add(this.lbl_nome);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.combo_unidade);
            this.Controls.Add(this.txt_desc);
            this.Controls.Add(this.lbl_id);
            this.Controls.Add(this.txt_id);
            this.MaximizeBox = false;
            this.Name = "Detalhes";
            this.Text = "Detalhes";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel_btns.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txt_id;
        public System.Windows.Forms.Label lbl_id;
        public System.Windows.Forms.RichTextBox txt_desc;
        public System.Windows.Forms.ComboBox combo_unidade;
        public System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Button btn_fechar;
        public System.Windows.Forms.TextBox txt_nome;
        public System.Windows.Forms.Label lbl_nome;
        public System.Windows.Forms.Panel panel_btns;
        public System.Windows.Forms.Button btn_cancelar;
        public System.Windows.Forms.Button btn_gravar;
        public System.Windows.Forms.Button btn_imagem;
        public System.Windows.Forms.Label lbl_dsc;
        public System.Windows.Forms.Label lbl_unidade;
        public System.Windows.Forms.TextBox txt_qtd;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label lbl_valor;
        public System.Windows.Forms.Label lbl_imagem;
        public System.Windows.Forms.TextBox txt_valor;
        private System.Windows.Forms.OpenFileDialog Arquivos;
    }
}