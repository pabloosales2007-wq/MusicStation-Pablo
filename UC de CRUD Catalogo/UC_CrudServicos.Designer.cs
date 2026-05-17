namespace MusicStation_Pablo
{
    partial class UC_CrudServicos
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

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelNomeTop = new System.Windows.Forms.Panel();
            this.lblServicos = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panelCRUD = new System.Windows.Forms.TableLayoutPanel();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnAtualizarUsuarios = new System.Windows.Forms.Button();
            this.btnDeletarUsuarios = new System.Windows.Forms.Button();
            this.btnCadastrarUsuarios = new System.Windows.Forms.Button();
            this.panelListBox = new System.Windows.Forms.Panel();
            this.lboServicos = new System.Windows.Forms.ListBox();
            this.lblPreco = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelNomeTop.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelCRUD.SuspendLayout();
            this.panelListBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelNomeTop
            // 
            this.panelNomeTop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panelNomeTop.Controls.Add(this.lblServicos);
            this.panelNomeTop.Location = new System.Drawing.Point(0, 0);
            this.panelNomeTop.Name = "panelNomeTop";
            this.panelNomeTop.Size = new System.Drawing.Size(976, 82);
            this.panelNomeTop.TabIndex = 38;
            // 
            // lblServicos
            // 
            this.lblServicos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblServicos.AutoSize = true;
            this.lblServicos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(30)))), ((int)(((byte)(98)))));
            this.lblServicos.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServicos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(180)))), ((int)(((byte)(34)))));
            this.lblServicos.Location = new System.Drawing.Point(415, 18);
            this.lblServicos.Name = "lblServicos";
            this.lblServicos.Size = new System.Drawing.Size(146, 47);
            this.lblServicos.TabIndex = 17;
            this.lblServicos.Text = "Serviços";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtPesquisa);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.panelCRUD);
            this.panel2.Controls.Add(this.panelListBox);
            this.panel2.Controls.Add(this.lblPreco);
            this.panel2.Controls.Add(this.txtNome);
            this.panel2.Controls.Add(this.lblDescricao);
            this.panel2.Controls.Add(this.txtDescricao);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txtPreco);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(976, 536);
            this.panel2.TabIndex = 39;
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPesquisa.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.txtPesquisa.ForeColor = System.Drawing.Color.Black;
            this.txtPesquisa.Location = new System.Drawing.Point(527, 303);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(409, 33);
            this.txtPesquisa.TabIndex = 49;
            this.txtPesquisa.TextChanged += new System.EventHandler(this.txtPesquisa_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(523, 275);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 25);
            this.label2.TabIndex = 48;
            this.label2.Text = "Pesquisar:";
            // 
            // panelCRUD
            // 
            this.panelCRUD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelCRUD.ColumnCount = 2;
            this.panelCRUD.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panelCRUD.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panelCRUD.Controls.Add(this.btnLimpar, 1, 1);
            this.panelCRUD.Controls.Add(this.btnAtualizarUsuarios, 0, 1);
            this.panelCRUD.Controls.Add(this.btnDeletarUsuarios, 1, 0);
            this.panelCRUD.Controls.Add(this.btnCadastrarUsuarios, 0, 0);
            this.panelCRUD.Location = new System.Drawing.Point(523, 135);
            this.panelCRUD.Name = "panelCRUD";
            this.panelCRUD.RowCount = 2;
            this.panelCRUD.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panelCRUD.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panelCRUD.Size = new System.Drawing.Size(412, 123);
            this.panelCRUD.TabIndex = 34;
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnLimpar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLimpar.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.btnLimpar.ForeColor = System.Drawing.Color.Transparent;
            this.btnLimpar.Location = new System.Drawing.Point(210, 64);
            this.btnLimpar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(198, 56);
            this.btnLimpar.TabIndex = 25;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnAtualizarUsuarios
            // 
            this.btnAtualizarUsuarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnAtualizarUsuarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAtualizarUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAtualizarUsuarios.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.btnAtualizarUsuarios.ForeColor = System.Drawing.Color.Transparent;
            this.btnAtualizarUsuarios.Location = new System.Drawing.Point(4, 64);
            this.btnAtualizarUsuarios.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAtualizarUsuarios.Name = "btnAtualizarUsuarios";
            this.btnAtualizarUsuarios.Size = new System.Drawing.Size(198, 56);
            this.btnAtualizarUsuarios.TabIndex = 23;
            this.btnAtualizarUsuarios.Text = "Atualizar";
            this.btnAtualizarUsuarios.UseVisualStyleBackColor = false;
            this.btnAtualizarUsuarios.Click += new System.EventHandler(this.btnAtualizarUsuarios_Click);
            // 
            // btnDeletarUsuarios
            // 
            this.btnDeletarUsuarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnDeletarUsuarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDeletarUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDeletarUsuarios.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.btnDeletarUsuarios.ForeColor = System.Drawing.Color.White;
            this.btnDeletarUsuarios.Location = new System.Drawing.Point(210, 3);
            this.btnDeletarUsuarios.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnDeletarUsuarios.Name = "btnDeletarUsuarios";
            this.btnDeletarUsuarios.Size = new System.Drawing.Size(198, 55);
            this.btnDeletarUsuarios.TabIndex = 22;
            this.btnDeletarUsuarios.Text = "Deletar";
            this.btnDeletarUsuarios.UseVisualStyleBackColor = false;
            this.btnDeletarUsuarios.Click += new System.EventHandler(this.btnDeletarUsuarios_Click);
            // 
            // btnCadastrarUsuarios
            // 
            this.btnCadastrarUsuarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnCadastrarUsuarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCadastrarUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCadastrarUsuarios.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.btnCadastrarUsuarios.ForeColor = System.Drawing.Color.Transparent;
            this.btnCadastrarUsuarios.Location = new System.Drawing.Point(4, 3);
            this.btnCadastrarUsuarios.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCadastrarUsuarios.Name = "btnCadastrarUsuarios";
            this.btnCadastrarUsuarios.Size = new System.Drawing.Size(198, 55);
            this.btnCadastrarUsuarios.TabIndex = 18;
            this.btnCadastrarUsuarios.Text = "Cadastrar";
            this.btnCadastrarUsuarios.UseVisualStyleBackColor = false;
            this.btnCadastrarUsuarios.Click += new System.EventHandler(this.btnCadastrarUsuarios_Click);
            // 
            // panelListBox
            // 
            this.panelListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.panelListBox.Controls.Add(this.lboServicos);
            this.panelListBox.Location = new System.Drawing.Point(34, 368);
            this.panelListBox.Name = "panelListBox";
            this.panelListBox.Size = new System.Drawing.Size(904, 154);
            this.panelListBox.TabIndex = 36;
            // 
            // lboServicos
            // 
            this.lboServicos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lboServicos.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.lboServicos.FormattingEnabled = true;
            this.lboServicos.HorizontalScrollbar = true;
            this.lboServicos.ItemHeight = 25;
            this.lboServicos.Location = new System.Drawing.Point(3, 3);
            this.lboServicos.Name = "lboServicos";
            this.lboServicos.ScrollAlwaysVisible = true;
            this.lboServicos.Size = new System.Drawing.Size(897, 129);
            this.lboServicos.TabIndex = 35;
            this.lboServicos.SelectedIndexChanged += new System.EventHandler(this.lboServicos_SelectedIndexChanged);
            // 
            // lblPreco
            // 
            this.lblPreco.AutoSize = true;
            this.lblPreco.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lblPreco.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.lblPreco.ForeColor = System.Drawing.Color.White;
            this.lblPreco.Location = new System.Drawing.Point(31, 211);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(64, 25);
            this.lblPreco.TabIndex = 31;
            this.lblPreco.Text = "Preço:";
            // 
            // txtNome
            // 
            this.txtNome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNome.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.txtNome.ForeColor = System.Drawing.Color.Black;
            this.txtNome.Location = new System.Drawing.Point(31, 113);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(415, 33);
            this.txtNome.TabIndex = 24;
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lblDescricao.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.lblDescricao.ForeColor = System.Drawing.Color.White;
            this.lblDescricao.Location = new System.Drawing.Point(31, 147);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(98, 25);
            this.lblDescricao.TabIndex = 30;
            this.lblDescricao.Text = "Descricao:";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescricao.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.txtDescricao.ForeColor = System.Drawing.Color.Black;
            this.txtDescricao.Location = new System.Drawing.Point(31, 175);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(415, 33);
            this.txtDescricao.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(32, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 25);
            this.label1.TabIndex = 29;
            this.label1.Text = "Nome:";
            // 
            // txtPreco
            // 
            this.txtPreco.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPreco.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.txtPreco.ForeColor = System.Drawing.Color.Black;
            this.txtPreco.Location = new System.Drawing.Point(31, 239);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(207, 33);
            this.txtPreco.TabIndex = 26;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(976, 536);
            this.panel1.TabIndex = 50;
            // 
            // UC_CrudServicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(28)))), ((int)(((byte)(26)))));
            this.Controls.Add(this.panelNomeTop);
            this.Controls.Add(this.panel2);
            this.Name = "UC_CrudServicos";
            this.Size = new System.Drawing.Size(976, 536);
            this.panelNomeTop.ResumeLayout(false);
            this.panelNomeTop.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panelCRUD.ResumeLayout(false);
            this.panelListBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelNomeTop;
        private System.Windows.Forms.Label lblServicos;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel panelCRUD;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnAtualizarUsuarios;
        private System.Windows.Forms.Button btnDeletarUsuarios;
        private System.Windows.Forms.Button btnCadastrarUsuarios;
        private System.Windows.Forms.Panel panelListBox;
        private System.Windows.Forms.ListBox lboServicos;
        private System.Windows.Forms.Label lblPreco;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.Panel panel1;
    }
}
