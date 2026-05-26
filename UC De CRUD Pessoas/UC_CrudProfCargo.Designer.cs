namespace MusicStation_Pablo
{
    partial class UC_CrudProfCargo
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelNomeTop = new System.Windows.Forms.Panel();
            this.lblProfissionalCargo = new System.Windows.Forms.Label();
            this.panelFundo = new System.Windows.Forms.Panel();
            this.cboCargo = new System.Windows.Forms.ComboBox();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panelListBox = new System.Windows.Forms.Panel();
            this.lboProfCargos = new System.Windows.Forms.ListBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblCargo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelCRUD = new System.Windows.Forms.TableLayoutPanel();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnAtualizarUsuarios = new System.Windows.Forms.Button();
            this.btnDeletarUsuarios = new System.Windows.Forms.Button();
            this.btnCadastrarUsuarios = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panelNomeTop.SuspendLayout();
            this.panelFundo.SuspendLayout();
            this.panelListBox.SuspendLayout();
            this.panelCRUD.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(28)))), ((int)(((byte)(26)))));
            this.panel2.Controls.Add(this.panelNomeTop);
            this.panel2.Controls.Add(this.panelFundo);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(976, 536);
            this.panel2.TabIndex = 38;
            // 
            // panelNomeTop
            // 
            this.panelNomeTop.Controls.Add(this.lblProfissionalCargo);
            this.panelNomeTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelNomeTop.Location = new System.Drawing.Point(0, 0);
            this.panelNomeTop.Name = "panelNomeTop";
            this.panelNomeTop.Size = new System.Drawing.Size(976, 82);
            this.panelNomeTop.TabIndex = 50;
            // 
            // lblProfissionalCargo
            // 
            this.lblProfissionalCargo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblProfissionalCargo.AutoSize = true;
            this.lblProfissionalCargo.BackColor = System.Drawing.Color.Transparent;
            this.lblProfissionalCargo.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfissionalCargo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(180)))), ((int)(((byte)(34)))));
            this.lblProfissionalCargo.Location = new System.Drawing.Point(338, 18);
            this.lblProfissionalCargo.Name = "lblProfissionalCargo";
            this.lblProfissionalCargo.Size = new System.Drawing.Size(301, 47);
            this.lblProfissionalCargo.TabIndex = 17;
            this.lblProfissionalCargo.Text = "Profissional Cargo";
            // 
            // panelFundo
            // 
            this.panelFundo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(28)))), ((int)(((byte)(26)))));
            this.panelFundo.Controls.Add(this.cboCargo);
            this.panelFundo.Controls.Add(this.txtPesquisa);
            this.panelFundo.Controls.Add(this.label2);
            this.panelFundo.Controls.Add(this.panelListBox);
            this.panelFundo.Controls.Add(this.txtNome);
            this.panelFundo.Controls.Add(this.lblCargo);
            this.panelFundo.Controls.Add(this.label1);
            this.panelFundo.Controls.Add(this.panelCRUD);
            this.panelFundo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFundo.Location = new System.Drawing.Point(0, 0);
            this.panelFundo.Name = "panelFundo";
            this.panelFundo.Size = new System.Drawing.Size(976, 536);
            this.panelFundo.TabIndex = 51;
            // 
            // cboCargo
            // 
            this.cboCargo.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.cboCargo.FormattingEnabled = true;
            this.cboCargo.Location = new System.Drawing.Point(31, 177);
            this.cboCargo.Name = "cboCargo";
            this.cboCargo.Size = new System.Drawing.Size(411, 33);
            this.cboCargo.TabIndex = 48;
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPesquisa.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.txtPesquisa.ForeColor = System.Drawing.Color.Black;
            this.txtPesquisa.Location = new System.Drawing.Point(526, 303);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(409, 33);
            this.txtPesquisa.TabIndex = 47;
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
            this.label2.TabIndex = 46;
            this.label2.Text = "Pesquisar:";
            // 
            // panelListBox
            // 
            this.panelListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.panelListBox.Controls.Add(this.lboProfCargos);
            this.panelListBox.Location = new System.Drawing.Point(34, 368);
            this.panelListBox.Name = "panelListBox";
            this.panelListBox.Size = new System.Drawing.Size(904, 154);
            this.panelListBox.TabIndex = 45;
            // 
            // lboProfCargos
            // 
            this.lboProfCargos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lboProfCargos.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.lboProfCargos.FormattingEnabled = true;
            this.lboProfCargos.HorizontalScrollbar = true;
            this.lboProfCargos.ItemHeight = 25;
            this.lboProfCargos.Location = new System.Drawing.Point(3, 3);
            this.lboProfCargos.Name = "lboProfCargos";
            this.lboProfCargos.ScrollAlwaysVisible = true;
            this.lboProfCargos.Size = new System.Drawing.Size(897, 129);
            this.lboProfCargos.TabIndex = 35;
            this.lboProfCargos.SelectedIndexChanged += new System.EventHandler(this.lboCargos_SelectedIndexChanged);
            // 
            // txtNome
            // 
            this.txtNome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNome.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.txtNome.ForeColor = System.Drawing.Color.Black;
            this.txtNome.Location = new System.Drawing.Point(31, 115);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(415, 33);
            this.txtNome.TabIndex = 37;
            // 
            // lblCargo
            // 
            this.lblCargo.AutoSize = true;
            this.lblCargo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lblCargo.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.lblCargo.ForeColor = System.Drawing.Color.White;
            this.lblCargo.Location = new System.Drawing.Point(31, 149);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(67, 25);
            this.lblCargo.TabIndex = 42;
            this.lblCargo.Text = "Cargo:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(32, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 25);
            this.label1.TabIndex = 41;
            this.label1.Text = "Nome:";
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
            this.panelCRUD.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.panelCRUD.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.panelCRUD.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.panelCRUD.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
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
            // UC_CrudProfCargo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Name = "UC_CrudProfCargo";
            this.Size = new System.Drawing.Size(976, 536);
            this.panel2.ResumeLayout(false);
            this.panelNomeTop.ResumeLayout(false);
            this.panelNomeTop.PerformLayout();
            this.panelFundo.ResumeLayout(false);
            this.panelFundo.PerformLayout();
            this.panelListBox.ResumeLayout(false);
            this.panelCRUD.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelNomeTop;
        private System.Windows.Forms.Label lblProfissionalCargo;
        private System.Windows.Forms.Panel panelFundo;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelListBox;
        private System.Windows.Forms.ListBox lboProfCargos;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblCargo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel panelCRUD;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnAtualizarUsuarios;
        private System.Windows.Forms.Button btnDeletarUsuarios;
        private System.Windows.Forms.Button btnCadastrarUsuarios;
        private System.Windows.Forms.ComboBox cboCargo;
    }
}
