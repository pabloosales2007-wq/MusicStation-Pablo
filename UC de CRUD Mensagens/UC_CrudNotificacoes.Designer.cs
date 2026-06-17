namespace MusicStation_Pablo
{
    partial class UC_CrudNotificacoes
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
            this.lblNotificacoes = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.chkLida = new System.Windows.Forms.CheckBox();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panelCRUD = new System.Windows.Forms.TableLayoutPanel();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnAtualizarUsuarios = new System.Windows.Forms.Button();
            this.btnDeletarUsuarios = new System.Windows.Forms.Button();
            this.btnCadastrarUsuarios = new System.Windows.Forms.Button();
            this.lblTipo = new System.Windows.Forms.Label();
            this.panelListBox = new System.Windows.Forms.Panel();
            this.lboNotificacoes = new System.Windows.Forms.ListBox();
            this.lblMensagem = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.lblDestinatario = new System.Windows.Forms.Label();
            this.txtMensagem = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboUsuario = new System.Windows.Forms.ComboBox();
            this.cboTipo = new System.Windows.Forms.ComboBox();
            this.dtpEnvio = new System.Windows.Forms.DateTimePicker();
            this.panelNomeTop.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelCRUD.SuspendLayout();
            this.panelListBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelNomeTop
            // 
            this.panelNomeTop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panelNomeTop.Controls.Add(this.lblNotificacoes);
            this.panelNomeTop.Location = new System.Drawing.Point(0, 0);
            this.panelNomeTop.Name = "panelNomeTop";
            this.panelNomeTop.Size = new System.Drawing.Size(976, 82);
            this.panelNomeTop.TabIndex = 38;
            // 
            // lblNotificacoes
            // 
            this.lblNotificacoes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNotificacoes.AutoSize = true;
            this.lblNotificacoes.BackColor = System.Drawing.Color.Transparent;
            this.lblNotificacoes.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotificacoes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(180)))), ((int)(((byte)(34)))));
            this.lblNotificacoes.Location = new System.Drawing.Point(383, 18);
            this.lblNotificacoes.Name = "lblNotificacoes";
            this.lblNotificacoes.Size = new System.Drawing.Size(210, 47);
            this.lblNotificacoes.TabIndex = 17;
            this.lblNotificacoes.Text = "Notificações";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dtpEnvio);
            this.panel2.Controls.Add(this.cboTipo);
            this.panel2.Controls.Add(this.cboUsuario);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.chkLida);
            this.panel2.Controls.Add(this.txtPesquisa);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.panelCRUD);
            this.panel2.Controls.Add(this.lblTipo);
            this.panel2.Controls.Add(this.panelListBox);
            this.panel2.Controls.Add(this.lblMensagem);
            this.panel2.Controls.Add(this.lblTitulo);
            this.panel2.Controls.Add(this.txtTitulo);
            this.panel2.Controls.Add(this.lblDestinatario);
            this.panel2.Controls.Add(this.txtMensagem);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(976, 536);
            this.panel2.TabIndex = 39;
            // 
            // chkLida
            // 
            this.chkLida.AutoSize = true;
            this.chkLida.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.chkLida.ForeColor = System.Drawing.Color.White;
            this.chkLida.Location = new System.Drawing.Point(278, 175);
            this.chkLida.Name = "chkLida";
            this.chkLida.Size = new System.Drawing.Size(66, 29);
            this.chkLida.TabIndex = 51;
            this.chkLida.Text = "Lida";
            this.chkLida.UseVisualStyleBackColor = true;
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
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lblTipo.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.lblTipo.ForeColor = System.Drawing.Color.White;
            this.lblTipo.Location = new System.Drawing.Point(31, 274);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(106, 25);
            this.lblTipo.TabIndex = 32;
            this.lblTipo.Text = "Data Envio:";
            // 
            // panelListBox
            // 
            this.panelListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.panelListBox.Controls.Add(this.lboNotificacoes);
            this.panelListBox.Location = new System.Drawing.Point(34, 368);
            this.panelListBox.Name = "panelListBox";
            this.panelListBox.Size = new System.Drawing.Size(904, 154);
            this.panelListBox.TabIndex = 36;
            // 
            // lboNotificacoes
            // 
            this.lboNotificacoes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lboNotificacoes.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.lboNotificacoes.FormattingEnabled = true;
            this.lboNotificacoes.HorizontalScrollbar = true;
            this.lboNotificacoes.ItemHeight = 25;
            this.lboNotificacoes.Location = new System.Drawing.Point(3, 3);
            this.lboNotificacoes.Name = "lboNotificacoes";
            this.lboNotificacoes.ScrollAlwaysVisible = true;
            this.lboNotificacoes.Size = new System.Drawing.Size(897, 129);
            this.lboNotificacoes.TabIndex = 35;
            this.lboNotificacoes.SelectedIndexChanged += new System.EventHandler(this.lboNotificacoes_SelectedIndexChanged);
            // 
            // lblMensagem
            // 
            this.lblMensagem.AutoSize = true;
            this.lblMensagem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lblMensagem.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.lblMensagem.ForeColor = System.Drawing.Color.White;
            this.lblMensagem.Location = new System.Drawing.Point(273, 85);
            this.lblMensagem.Name = "lblMensagem";
            this.lblMensagem.Size = new System.Drawing.Size(109, 25);
            this.lblMensagem.TabIndex = 31;
            this.lblMensagem.Text = "Mensagem:";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(31, 147);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(64, 25);
            this.lblTitulo.TabIndex = 30;
            this.lblTitulo.Text = "Titulo:";
            // 
            // txtTitulo
            // 
            this.txtTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTitulo.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.txtTitulo.ForeColor = System.Drawing.Color.Black;
            this.txtTitulo.Location = new System.Drawing.Point(31, 175);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(207, 33);
            this.txtTitulo.TabIndex = 25;
            // 
            // lblDestinatario
            // 
            this.lblDestinatario.AutoSize = true;
            this.lblDestinatario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lblDestinatario.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.lblDestinatario.ForeColor = System.Drawing.Color.White;
            this.lblDestinatario.Location = new System.Drawing.Point(32, 85);
            this.lblDestinatario.Name = "lblDestinatario";
            this.lblDestinatario.Size = new System.Drawing.Size(118, 25);
            this.lblDestinatario.TabIndex = 29;
            this.lblDestinatario.Text = "Destinatario:";
            // 
            // txtMensagem
            // 
            this.txtMensagem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMensagem.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.txtMensagem.ForeColor = System.Drawing.Color.Black;
            this.txtMensagem.Location = new System.Drawing.Point(273, 113);
            this.txtMensagem.Name = "txtMensagem";
            this.txtMensagem.Size = new System.Drawing.Size(207, 33);
            this.txtMensagem.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(31, 210);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 25);
            this.label1.TabIndex = 54;
            this.label1.Text = "Tipo:";
            // 
            // cboUsuario
            // 
            this.cboUsuario.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.cboUsuario.FormattingEnabled = true;
            this.cboUsuario.Location = new System.Drawing.Point(31, 113);
            this.cboUsuario.Name = "cboUsuario";
            this.cboUsuario.Size = new System.Drawing.Size(206, 33);
            this.cboUsuario.TabIndex = 55;
            // 
            // cboTipo
            // 
            this.cboTipo.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.cboTipo.FormattingEnabled = true;
            this.cboTipo.Items.AddRange(new object[] {
            "sistema",
            "agendamento",
            "mensagem",
            "promocao"});
            this.cboTipo.Location = new System.Drawing.Point(36, 238);
            this.cboTipo.Name = "cboTipo";
            this.cboTipo.Size = new System.Drawing.Size(201, 33);
            this.cboTipo.TabIndex = 56;
            // 
            // dtpEnvio
            // 
            this.dtpEnvio.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.dtpEnvio.Location = new System.Drawing.Point(36, 303);
            this.dtpEnvio.Name = "dtpEnvio";
            this.dtpEnvio.Size = new System.Drawing.Size(376, 33);
            this.dtpEnvio.TabIndex = 57;
            // 
            // UC_CrudNotificacoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(28)))), ((int)(((byte)(26)))));
            this.Controls.Add(this.panelNomeTop);
            this.Controls.Add(this.panel2);
            this.Name = "UC_CrudNotificacoes";
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
        private System.Windows.Forms.Label lblNotificacoes;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel panelCRUD;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnAtualizarUsuarios;
        private System.Windows.Forms.Button btnDeletarUsuarios;
        private System.Windows.Forms.Button btnCadastrarUsuarios;
        private System.Windows.Forms.Panel panelListBox;
        private System.Windows.Forms.ListBox lboNotificacoes;
        private System.Windows.Forms.Label lblMensagem;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.Label lblDestinatario;
        private System.Windows.Forms.TextBox txtMensagem;
        private System.Windows.Forms.CheckBox chkLida;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.ComboBox cboTipo;
        private System.Windows.Forms.ComboBox cboUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpEnvio;
    }
}
