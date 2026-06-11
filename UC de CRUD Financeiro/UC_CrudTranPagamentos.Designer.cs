namespace MusicStation_Pablo
{
    partial class UC_CrudTranPagamentos
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
            this.lblTranPagamentos = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblAcompanhamento = new System.Windows.Forms.Label();
            this.lbldata_transacao = new System.Windows.Forms.Label();
            this.lblCodigoExterno = new System.Windows.Forms.Label();
            this.txtCodigoExterno = new System.Windows.Forms.TextBox();
            this.cboStatusTransacao = new System.Windows.Forms.ComboBox();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panelCRUD = new System.Windows.Forms.TableLayoutPanel();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnAtualizarUsuarios = new System.Windows.Forms.Button();
            this.btnDeletarUsuarios = new System.Windows.Forms.Button();
            this.btnCadastrarUsuarios = new System.Windows.Forms.Button();
            this.panelListBox = new System.Windows.Forms.Panel();
            this.lboTranPagamentos = new System.Windows.Forms.ListBox();
            this.lblPagamentoRef = new System.Windows.Forms.Label();
            this.dtpDataTransacao = new System.Windows.Forms.DateTimePicker();
            this.cboPagamentos = new System.Windows.Forms.ComboBox();
            this.panelNomeTop.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelCRUD.SuspendLayout();
            this.panelListBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelNomeTop
            // 
            this.panelNomeTop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panelNomeTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(28)))), ((int)(((byte)(26)))));
            this.panelNomeTop.Controls.Add(this.lblTranPagamentos);
            this.panelNomeTop.Location = new System.Drawing.Point(0, 0);
            this.panelNomeTop.Name = "panelNomeTop";
            this.panelNomeTop.Size = new System.Drawing.Size(976, 82);
            this.panelNomeTop.TabIndex = 38;
            // 
            // lblTranPagamentos
            // 
            this.lblTranPagamentos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTranPagamentos.AutoSize = true;
            this.lblTranPagamentos.BackColor = System.Drawing.Color.Transparent;
            this.lblTranPagamentos.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTranPagamentos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(180)))), ((int)(((byte)(34)))));
            this.lblTranPagamentos.Location = new System.Drawing.Point(269, 18);
            this.lblTranPagamentos.Name = "lblTranPagamentos";
            this.lblTranPagamentos.Size = new System.Drawing.Size(439, 47);
            this.lblTranPagamentos.TabIndex = 17;
            this.lblTranPagamentos.Text = "Transações de Pagamentos";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(28)))), ((int)(((byte)(26)))));
            this.panel2.Controls.Add(this.cboPagamentos);
            this.panel2.Controls.Add(this.dtpDataTransacao);
            this.panel2.Controls.Add(this.lblAcompanhamento);
            this.panel2.Controls.Add(this.lbldata_transacao);
            this.panel2.Controls.Add(this.lblCodigoExterno);
            this.panel2.Controls.Add(this.txtCodigoExterno);
            this.panel2.Controls.Add(this.cboStatusTransacao);
            this.panel2.Controls.Add(this.txtPesquisa);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.panelCRUD);
            this.panel2.Controls.Add(this.panelListBox);
            this.panel2.Controls.Add(this.lblPagamentoRef);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(976, 536);
            this.panel2.TabIndex = 39;
            // 
            // lblAcompanhamento
            // 
            this.lblAcompanhamento.AutoSize = true;
            this.lblAcompanhamento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lblAcompanhamento.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.lblAcompanhamento.ForeColor = System.Drawing.Color.White;
            this.lblAcompanhamento.Location = new System.Drawing.Point(32, 153);
            this.lblAcompanhamento.Name = "lblAcompanhamento";
            this.lblAcompanhamento.Size = new System.Drawing.Size(167, 25);
            this.lblAcompanhamento.TabIndex = 55;
            this.lblAcompanhamento.Text = "Acompanhamento";
            // 
            // lbldata_transacao
            // 
            this.lbldata_transacao.AutoSize = true;
            this.lbldata_transacao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lbldata_transacao.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.lbldata_transacao.ForeColor = System.Drawing.Color.White;
            this.lbldata_transacao.Location = new System.Drawing.Point(32, 287);
            this.lbldata_transacao.Name = "lbldata_transacao";
            this.lbldata_transacao.Size = new System.Drawing.Size(144, 25);
            this.lbldata_transacao.TabIndex = 54;
            this.lbldata_transacao.Text = "Data Transacao:";
            // 
            // lblCodigoExterno
            // 
            this.lblCodigoExterno.AutoSize = true;
            this.lblCodigoExterno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lblCodigoExterno.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.lblCodigoExterno.ForeColor = System.Drawing.Color.White;
            this.lblCodigoExterno.Location = new System.Drawing.Point(32, 217);
            this.lblCodigoExterno.Name = "lblCodigoExterno";
            this.lblCodigoExterno.Size = new System.Drawing.Size(146, 25);
            this.lblCodigoExterno.TabIndex = 52;
            this.lblCodigoExterno.Text = "Codigo Externo:";
            // 
            // txtCodigoExterno
            // 
            this.txtCodigoExterno.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCodigoExterno.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.txtCodigoExterno.ForeColor = System.Drawing.Color.Black;
            this.txtCodigoExterno.Location = new System.Drawing.Point(34, 245);
            this.txtCodigoExterno.Name = "txtCodigoExterno";
            this.txtCodigoExterno.Size = new System.Drawing.Size(207, 33);
            this.txtCodigoExterno.TabIndex = 51;
            // 
            // cboStatusTransacao
            // 
            this.cboStatusTransacao.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.cboStatusTransacao.FormattingEnabled = true;
            this.cboStatusTransacao.Items.AddRange(new object[] {
            "processando",
            "aprovado",
            "recusado",
            "falha"});
            this.cboStatusTransacao.Location = new System.Drawing.Point(34, 181);
            this.cboStatusTransacao.Name = "cboStatusTransacao";
            this.cboStatusTransacao.Size = new System.Drawing.Size(207, 33);
            this.cboStatusTransacao.TabIndex = 50;
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
            this.panelListBox.Controls.Add(this.lboTranPagamentos);
            this.panelListBox.Location = new System.Drawing.Point(34, 368);
            this.panelListBox.Name = "panelListBox";
            this.panelListBox.Size = new System.Drawing.Size(904, 154);
            this.panelListBox.TabIndex = 36;
            // 
            // lboTranPagamentos
            // 
            this.lboTranPagamentos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lboTranPagamentos.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.lboTranPagamentos.FormattingEnabled = true;
            this.lboTranPagamentos.HorizontalScrollbar = true;
            this.lboTranPagamentos.ItemHeight = 25;
            this.lboTranPagamentos.Location = new System.Drawing.Point(3, 3);
            this.lboTranPagamentos.Name = "lboTranPagamentos";
            this.lboTranPagamentos.ScrollAlwaysVisible = true;
            this.lboTranPagamentos.Size = new System.Drawing.Size(897, 129);
            this.lboTranPagamentos.TabIndex = 35;
            this.lboTranPagamentos.SelectedIndexChanged += new System.EventHandler(this.lboTranPagamentos_SelectedIndexChanged);
            // 
            // lblPagamentoRef
            // 
            this.lblPagamentoRef.AutoSize = true;
            this.lblPagamentoRef.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lblPagamentoRef.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.lblPagamentoRef.ForeColor = System.Drawing.Color.White;
            this.lblPagamentoRef.Location = new System.Drawing.Point(32, 85);
            this.lblPagamentoRef.Name = "lblPagamentoRef";
            this.lblPagamentoRef.Size = new System.Drawing.Size(107, 25);
            this.lblPagamentoRef.TabIndex = 29;
            this.lblPagamentoRef.Text = "Pagamento";
            // 
            // dtpDataTransacao
            // 
            this.dtpDataTransacao.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.dtpDataTransacao.Location = new System.Drawing.Point(37, 316);
            this.dtpDataTransacao.Name = "dtpDataTransacao";
            this.dtpDataTransacao.Size = new System.Drawing.Size(379, 33);
            this.dtpDataTransacao.TabIndex = 56;
            // 
            // cboPagamentos
            // 
            this.cboPagamentos.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.cboPagamentos.FormattingEnabled = true;
            this.cboPagamentos.Items.AddRange(new object[] {
            "processando",
            "aprovado",
            "recusado",
            "falha"});
            this.cboPagamentos.Location = new System.Drawing.Point(34, 113);
            this.cboPagamentos.Name = "cboPagamentos";
            this.cboPagamentos.Size = new System.Drawing.Size(207, 33);
            this.cboPagamentos.TabIndex = 57;
            // 
            // UC_CrudTranPagamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelNomeTop);
            this.Controls.Add(this.panel2);
            this.Name = "UC_CrudTranPagamentos";
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
        private System.Windows.Forms.Label lblTranPagamentos;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel panelCRUD;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnAtualizarUsuarios;
        private System.Windows.Forms.Button btnDeletarUsuarios;
        private System.Windows.Forms.Button btnCadastrarUsuarios;
        private System.Windows.Forms.Panel panelListBox;
        private System.Windows.Forms.ListBox lboTranPagamentos;
        private System.Windows.Forms.Label lblPagamentoRef;
        private System.Windows.Forms.ComboBox cboStatusTransacao;
        private System.Windows.Forms.Label lblAcompanhamento;
        private System.Windows.Forms.Label lbldata_transacao;
        private System.Windows.Forms.Label lblCodigoExterno;
        private System.Windows.Forms.TextBox txtCodigoExterno;
        private System.Windows.Forms.DateTimePicker dtpDataTransacao;
        private System.Windows.Forms.ComboBox cboPagamentos;
    }
}
