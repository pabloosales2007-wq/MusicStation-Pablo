namespace MusicStation_Pablo
{
    partial class UC_CrudClientes
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
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblRua = new System.Windows.Forms.Label();
            this.lblNomeUsuario = new System.Windows.Forms.Label();
            this.txtRua = new System.Windows.Forms.TextBox();
            this.txtNomeCliente = new System.Windows.Forms.TextBox();
            this.panelCRUD = new System.Windows.Forms.TableLayoutPanel();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnAtualizarUsuarios = new System.Windows.Forms.Button();
            this.btnDeletarUsuarios = new System.Windows.Forms.Button();
            this.btnCadastrarUsuarios = new System.Windows.Forms.Button();
            this.panelNomeTop = new System.Windows.Forms.Panel();
            this.lblClientes = new System.Windows.Forms.Label();
            this.panelListBox = new System.Windows.Forms.Panel();
            this.lboClientes = new System.Windows.Forms.ListBox();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.lblNumero = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.lblSenha = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelCRUD.SuspendLayout();
            this.panelNomeTop.SuspendLayout();
            this.panelListBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPesquisa.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.txtPesquisa.ForeColor = System.Drawing.Color.Black;
            this.txtPesquisa.Location = new System.Drawing.Point(526, 309);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(409, 33);
            this.txtPesquisa.TabIndex = 85;
            this.txtPesquisa.TextChanged += new System.EventHandler(this.txtPesquisa_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(523, 281);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 25);
            this.label2.TabIndex = 84;
            this.label2.Text = "Pesquisar:";
            // 
            // lblRua
            // 
            this.lblRua.AutoSize = true;
            this.lblRua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lblRua.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.lblRua.ForeColor = System.Drawing.Color.White;
            this.lblRua.Location = new System.Drawing.Point(270, 155);
            this.lblRua.Name = "lblRua";
            this.lblRua.Size = new System.Drawing.Size(48, 25);
            this.lblRua.TabIndex = 79;
            this.lblRua.Text = "Rua:";
            // 
            // lblNomeUsuario
            // 
            this.lblNomeUsuario.AutoSize = true;
            this.lblNomeUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lblNomeUsuario.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.lblNomeUsuario.ForeColor = System.Drawing.Color.White;
            this.lblNomeUsuario.Location = new System.Drawing.Point(32, 93);
            this.lblNomeUsuario.Name = "lblNomeUsuario";
            this.lblNomeUsuario.Size = new System.Drawing.Size(137, 25);
            this.lblNomeUsuario.TabIndex = 78;
            this.lblNomeUsuario.Text = "Nome Usuario:";
            // 
            // txtRua
            // 
            this.txtRua.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRua.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.txtRua.ForeColor = System.Drawing.Color.Black;
            this.txtRua.Location = new System.Drawing.Point(270, 183);
            this.txtRua.Name = "txtRua";
            this.txtRua.Size = new System.Drawing.Size(199, 33);
            this.txtRua.TabIndex = 76;
            // 
            // txtNomeCliente
            // 
            this.txtNomeCliente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNomeCliente.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.txtNomeCliente.ForeColor = System.Drawing.Color.Black;
            this.txtNomeCliente.Location = new System.Drawing.Point(31, 121);
            this.txtNomeCliente.Name = "txtNomeCliente";
            this.txtNomeCliente.Size = new System.Drawing.Size(199, 33);
            this.txtNomeCliente.TabIndex = 75;
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
            this.panelCRUD.Location = new System.Drawing.Point(523, 139);
            this.panelCRUD.Name = "panelCRUD";
            this.panelCRUD.RowCount = 2;
            this.panelCRUD.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panelCRUD.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panelCRUD.Size = new System.Drawing.Size(412, 123);
            this.panelCRUD.TabIndex = 73;
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
            // panelNomeTop
            // 
            this.panelNomeTop.Controls.Add(this.lblClientes);
            this.panelNomeTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelNomeTop.Location = new System.Drawing.Point(0, 0);
            this.panelNomeTop.Name = "panelNomeTop";
            this.panelNomeTop.Size = new System.Drawing.Size(976, 82);
            this.panelNomeTop.TabIndex = 77;
            // 
            // lblClientes
            // 
            this.lblClientes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblClientes.AutoSize = true;
            this.lblClientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(30)))), ((int)(((byte)(98)))));
            this.lblClientes.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(180)))), ((int)(((byte)(34)))));
            this.lblClientes.Location = new System.Drawing.Point(418, 20);
            this.lblClientes.Name = "lblClientes";
            this.lblClientes.Size = new System.Drawing.Size(141, 47);
            this.lblClientes.TabIndex = 17;
            this.lblClientes.Text = "Clientes";
            // 
            // panelListBox
            // 
            this.panelListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.panelListBox.Controls.Add(this.lboClientes);
            this.panelListBox.Location = new System.Drawing.Point(34, 374);
            this.panelListBox.Name = "panelListBox";
            this.panelListBox.Size = new System.Drawing.Size(904, 154);
            this.panelListBox.TabIndex = 74;
            // 
            // lboClientes
            // 
            this.lboClientes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lboClientes.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.lboClientes.FormattingEnabled = true;
            this.lboClientes.HorizontalScrollbar = true;
            this.lboClientes.ItemHeight = 25;
            this.lboClientes.Location = new System.Drawing.Point(3, 3);
            this.lboClientes.Name = "lboClientes";
            this.lboClientes.ScrollAlwaysVisible = true;
            this.lboClientes.Size = new System.Drawing.Size(897, 129);
            this.lboClientes.TabIndex = 36;
            this.lboClientes.SelectedIndexChanged += new System.EventHandler(this.lboClientes_SelectedIndexChanged);
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lblTelefone.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.lblTelefone.ForeColor = System.Drawing.Color.White;
            this.lblTelefone.Location = new System.Drawing.Point(31, 283);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(87, 25);
            this.lblTelefone.TabIndex = 89;
            this.lblTelefone.Text = "Telefone:";
            // 
            // txtTelefone
            // 
            this.txtTelefone.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTelefone.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.txtTelefone.ForeColor = System.Drawing.Color.Black;
            this.txtTelefone.Location = new System.Drawing.Point(31, 311);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(199, 33);
            this.txtTelefone.TabIndex = 88;
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lblNumero.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.lblNumero.ForeColor = System.Drawing.Color.White;
            this.lblNumero.Location = new System.Drawing.Point(270, 93);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(85, 25);
            this.lblNumero.TabIndex = 91;
            this.lblNumero.Text = "Numero:";
            // 
            // txtNumero
            // 
            this.txtNumero.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNumero.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.txtNumero.ForeColor = System.Drawing.Color.Black;
            this.txtNumero.Location = new System.Drawing.Point(270, 121);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(199, 33);
            this.txtNumero.TabIndex = 90;
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lblSenha.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.lblSenha.ForeColor = System.Drawing.Color.White;
            this.lblSenha.Location = new System.Drawing.Point(31, 215);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(68, 25);
            this.lblSenha.TabIndex = 93;
            this.lblSenha.Text = "Senha:";
            // 
            // txtSenha
            // 
            this.txtSenha.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSenha.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.txtSenha.ForeColor = System.Drawing.Color.Black;
            this.txtSenha.Location = new System.Drawing.Point(31, 243);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(199, 33);
            this.txtSenha.TabIndex = 92;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.lblEmail.ForeColor = System.Drawing.Color.White;
            this.lblEmail.Location = new System.Drawing.Point(31, 155);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(62, 25);
            this.lblEmail.TabIndex = 95;
            this.lblEmail.Text = "Email:";
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.txtEmail.ForeColor = System.Drawing.Color.Black;
            this.txtEmail.Location = new System.Drawing.Point(31, 183);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(199, 33);
            this.txtEmail.TabIndex = 94;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(976, 536);
            this.panel1.TabIndex = 96;
            // 
            // UC_CrudClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(28)))), ((int)(((byte)(26)))));
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.lblTelefone);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.txtPesquisa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblRua);
            this.Controls.Add(this.lblNomeUsuario);
            this.Controls.Add(this.txtRua);
            this.Controls.Add(this.txtNomeCliente);
            this.Controls.Add(this.panelCRUD);
            this.Controls.Add(this.panelNomeTop);
            this.Controls.Add(this.panelListBox);
            this.Controls.Add(this.panel1);
            this.Name = "UC_CrudClientes";
            this.Size = new System.Drawing.Size(976, 536);
            this.panelCRUD.ResumeLayout(false);
            this.panelNomeTop.ResumeLayout(false);
            this.panelNomeTop.PerformLayout();
            this.panelListBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblRua;
        private System.Windows.Forms.Label lblNomeUsuario;
        private System.Windows.Forms.TextBox txtRua;
        private System.Windows.Forms.TextBox txtNomeCliente;
        private System.Windows.Forms.TableLayoutPanel panelCRUD;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnAtualizarUsuarios;
        private System.Windows.Forms.Button btnDeletarUsuarios;
        private System.Windows.Forms.Button btnCadastrarUsuarios;
        private System.Windows.Forms.Panel panelNomeTop;
        private System.Windows.Forms.Label lblClientes;
        private System.Windows.Forms.Panel panelListBox;
        private System.Windows.Forms.ListBox lboClientes;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Panel panel1;
    }
}
