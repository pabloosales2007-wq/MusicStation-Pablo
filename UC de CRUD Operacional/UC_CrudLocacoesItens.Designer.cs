namespace MusicStation_Pablo
{
    partial class UC_CrudLocacoesItens
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
            this.lblLocacoesItens = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblInstrumentos = new System.Windows.Forms.Label();
            this.lblNomeLocacao = new System.Windows.Forms.Label();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.lblDias = new System.Windows.Forms.Label();
            this.lblPrecoLocacao = new System.Windows.Forms.Label();
            this.txtPrecoLocacao = new System.Windows.Forms.TextBox();
            this.txtDias = new System.Windows.Forms.TextBox();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panelCRUD = new System.Windows.Forms.TableLayoutPanel();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnAtualizarUsuarios = new System.Windows.Forms.Button();
            this.btnDeletarUsuarios = new System.Windows.Forms.Button();
            this.btnCadastrarUsuarios = new System.Windows.Forms.Button();
            this.panelListBox = new System.Windows.Forms.Panel();
            this.lboLocacoesItens = new System.Windows.Forms.ListBox();
            this.cboInstrumento = new System.Windows.Forms.ComboBox();
            this.cboLocacao = new System.Windows.Forms.ComboBox();
            this.panelNomeTop.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelCRUD.SuspendLayout();
            this.panelListBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelNomeTop
            // 
            this.panelNomeTop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panelNomeTop.Controls.Add(this.lblLocacoesItens);
            this.panelNomeTop.Location = new System.Drawing.Point(0, 0);
            this.panelNomeTop.Name = "panelNomeTop";
            this.panelNomeTop.Size = new System.Drawing.Size(976, 82);
            this.panelNomeTop.TabIndex = 38;
            // 
            // lblLocacoesItens
            // 
            this.lblLocacoesItens.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLocacoesItens.AutoSize = true;
            this.lblLocacoesItens.BackColor = System.Drawing.Color.Transparent;
            this.lblLocacoesItens.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocacoesItens.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(180)))), ((int)(((byte)(34)))));
            this.lblLocacoesItens.Location = new System.Drawing.Point(366, 18);
            this.lblLocacoesItens.Name = "lblLocacoesItens";
            this.lblLocacoesItens.Size = new System.Drawing.Size(245, 47);
            this.lblLocacoesItens.TabIndex = 17;
            this.lblLocacoesItens.Text = "Locações Itens";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cboLocacao);
            this.panel2.Controls.Add(this.cboInstrumento);
            this.panel2.Controls.Add(this.lblInstrumentos);
            this.panel2.Controls.Add(this.lblNomeLocacao);
            this.panel2.Controls.Add(this.lblSubtotal);
            this.panel2.Controls.Add(this.lblDias);
            this.panel2.Controls.Add(this.lblPrecoLocacao);
            this.panel2.Controls.Add(this.txtPrecoLocacao);
            this.panel2.Controls.Add(this.txtDias);
            this.panel2.Controls.Add(this.txtSubtotal);
            this.panel2.Controls.Add(this.txtPesquisa);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.panelCRUD);
            this.panel2.Controls.Add(this.panelListBox);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(976, 536);
            this.panel2.TabIndex = 39;
            // 
            // lblInstrumentos
            // 
            this.lblInstrumentos.AutoSize = true;
            this.lblInstrumentos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lblInstrumentos.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.lblInstrumentos.ForeColor = System.Drawing.Color.White;
            this.lblInstrumentos.Location = new System.Drawing.Point(34, 147);
            this.lblInstrumentos.Name = "lblInstrumentos";
            this.lblInstrumentos.Size = new System.Drawing.Size(126, 25);
            this.lblInstrumentos.TabIndex = 72;
            this.lblInstrumentos.Text = "Instrumentos:";
            // 
            // lblNomeLocacao
            // 
            this.lblNomeLocacao.AutoSize = true;
            this.lblNomeLocacao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lblNomeLocacao.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.lblNomeLocacao.ForeColor = System.Drawing.Color.White;
            this.lblNomeLocacao.Location = new System.Drawing.Point(35, 83);
            this.lblNomeLocacao.Name = "lblNomeLocacao";
            this.lblNomeLocacao.Size = new System.Drawing.Size(137, 25);
            this.lblNomeLocacao.TabIndex = 70;
            this.lblNomeLocacao.Text = "N° da Locação:";
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lblSubtotal.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.lblSubtotal.ForeColor = System.Drawing.Color.White;
            this.lblSubtotal.Location = new System.Drawing.Point(278, 147);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(86, 25);
            this.lblSubtotal.TabIndex = 55;
            this.lblSubtotal.Text = "Subtotal:";
            // 
            // lblDias
            // 
            this.lblDias.AutoSize = true;
            this.lblDias.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lblDias.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.lblDias.ForeColor = System.Drawing.Color.White;
            this.lblDias.Location = new System.Drawing.Point(278, 83);
            this.lblDias.Name = "lblDias";
            this.lblDias.Size = new System.Drawing.Size(52, 25);
            this.lblDias.TabIndex = 54;
            this.lblDias.Text = "Dias:";
            // 
            // lblPrecoLocacao
            // 
            this.lblPrecoLocacao.AutoSize = true;
            this.lblPrecoLocacao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lblPrecoLocacao.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.lblPrecoLocacao.ForeColor = System.Drawing.Color.White;
            this.lblPrecoLocacao.Location = new System.Drawing.Point(34, 212);
            this.lblPrecoLocacao.Name = "lblPrecoLocacao";
            this.lblPrecoLocacao.Size = new System.Drawing.Size(138, 25);
            this.lblPrecoLocacao.TabIndex = 53;
            this.lblPrecoLocacao.Text = "Preço Locação:";
            // 
            // txtPrecoLocacao
            // 
            this.txtPrecoLocacao.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPrecoLocacao.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.txtPrecoLocacao.ForeColor = System.Drawing.Color.Black;
            this.txtPrecoLocacao.Location = new System.Drawing.Point(34, 240);
            this.txtPrecoLocacao.Name = "txtPrecoLocacao";
            this.txtPrecoLocacao.Size = new System.Drawing.Size(207, 33);
            this.txtPrecoLocacao.TabIndex = 50;
            // 
            // txtDias
            // 
            this.txtDias.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDias.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.txtDias.ForeColor = System.Drawing.Color.Black;
            this.txtDias.Location = new System.Drawing.Point(278, 111);
            this.txtDias.Name = "txtDias";
            this.txtDias.Size = new System.Drawing.Size(207, 33);
            this.txtDias.TabIndex = 51;
            this.txtDias.TextChanged += new System.EventHandler(this.txtDias_TextChanged);
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSubtotal.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.txtSubtotal.ForeColor = System.Drawing.Color.Black;
            this.txtSubtotal.Location = new System.Drawing.Point(278, 175);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.Size = new System.Drawing.Size(207, 33);
            this.txtSubtotal.TabIndex = 52;
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
            this.panelListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.panelListBox.Controls.Add(this.lboLocacoesItens);
            this.panelListBox.Location = new System.Drawing.Point(34, 368);
            this.panelListBox.Name = "panelListBox";
            this.panelListBox.Size = new System.Drawing.Size(904, 154);
            this.panelListBox.TabIndex = 36;
            // 
            // lboLocacoesItens
            // 
            this.lboLocacoesItens.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lboLocacoesItens.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.lboLocacoesItens.FormattingEnabled = true;
            this.lboLocacoesItens.HorizontalScrollbar = true;
            this.lboLocacoesItens.ItemHeight = 25;
            this.lboLocacoesItens.Location = new System.Drawing.Point(3, 3);
            this.lboLocacoesItens.Name = "lboLocacoesItens";
            this.lboLocacoesItens.ScrollAlwaysVisible = true;
            this.lboLocacoesItens.Size = new System.Drawing.Size(897, 129);
            this.lboLocacoesItens.TabIndex = 35;
            this.lboLocacoesItens.SelectedIndexChanged += new System.EventHandler(this.lboLocacoesItens_SelectedIndexChanged);
            // 
            // cboInstrumento
            // 
            this.cboInstrumento.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.cboInstrumento.FormattingEnabled = true;
            this.cboInstrumento.Location = new System.Drawing.Point(34, 175);
            this.cboInstrumento.Name = "cboInstrumento";
            this.cboInstrumento.Size = new System.Drawing.Size(207, 33);
            this.cboInstrumento.TabIndex = 75;
            // 
            // cboLocacao
            // 
            this.cboLocacao.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.cboLocacao.FormattingEnabled = true;
            this.cboLocacao.Location = new System.Drawing.Point(34, 111);
            this.cboLocacao.Name = "cboLocacao";
            this.cboLocacao.Size = new System.Drawing.Size(207, 33);
            this.cboLocacao.TabIndex = 76;
            // 
            // UC_CrudLocacoesItens
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(28)))), ((int)(((byte)(26)))));
            this.Controls.Add(this.panelNomeTop);
            this.Controls.Add(this.panel2);
            this.Name = "UC_CrudLocacoesItens";
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
        private System.Windows.Forms.Label lblLocacoesItens;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel panelCRUD;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnAtualizarUsuarios;
        private System.Windows.Forms.Button btnDeletarUsuarios;
        private System.Windows.Forms.Button btnCadastrarUsuarios;
        private System.Windows.Forms.Panel panelListBox;
        private System.Windows.Forms.ListBox lboLocacoesItens;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Label lblDias;
        private System.Windows.Forms.Label lblPrecoLocacao;
        private System.Windows.Forms.TextBox txtPrecoLocacao;
        private System.Windows.Forms.TextBox txtDias;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.Label lblInstrumentos;
        private System.Windows.Forms.Label lblNomeLocacao;
        private System.Windows.Forms.ComboBox cboInstrumento;
        private System.Windows.Forms.ComboBox cboLocacao;
    }
}
