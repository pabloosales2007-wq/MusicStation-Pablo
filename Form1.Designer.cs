namespace MusicStation_Pablo
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelTabelas = new System.Windows.Forms.Panel();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panelAbrirTabelas = new System.Windows.Forms.Panel();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.btnMensagens = new System.Windows.Forms.Button();
            this.btnFinanceiro = new System.Windows.Forms.Button();
            this.btnOperacional = new System.Windows.Forms.Button();
            this.btnCatalogo = new System.Windows.Forms.Button();
            this.btnPessoas = new System.Windows.Forms.Button();
            this.panelConteudo = new System.Windows.Forms.Panel();
            this.pboLogo = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panelAbrirTabelas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(28)))), ((int)(((byte)(26)))));
            this.panel1.Controls.Add(this.panelTabelas);
            this.panel1.Controls.Add(this.panelLogo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 636);
            this.panel1.TabIndex = 0;
            // 
            // panelTabelas
            // 
            this.panelTabelas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelTabelas.Location = new System.Drawing.Point(0, 100);
            this.panelTabelas.Name = "panelTabelas";
            this.panelTabelas.Size = new System.Drawing.Size(200, 536);
            this.panelTabelas.TabIndex = 1;
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.pboLogo);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(200, 100);
            this.panelLogo.TabIndex = 0;
            // 
            // panelAbrirTabelas
            // 
            this.panelAbrirTabelas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelAbrirTabelas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(28)))), ((int)(((byte)(26)))));
            this.panelAbrirTabelas.Controls.Add(this.btnDashboard);
            this.panelAbrirTabelas.Controls.Add(this.btnMensagens);
            this.panelAbrirTabelas.Controls.Add(this.btnFinanceiro);
            this.panelAbrirTabelas.Controls.Add(this.btnOperacional);
            this.panelAbrirTabelas.Controls.Add(this.btnCatalogo);
            this.panelAbrirTabelas.Controls.Add(this.btnPessoas);
            this.panelAbrirTabelas.Location = new System.Drawing.Point(200, 0);
            this.panelAbrirTabelas.Name = "panelAbrirTabelas";
            this.panelAbrirTabelas.Size = new System.Drawing.Size(976, 100);
            this.panelAbrirTabelas.TabIndex = 1;
            // 
            // btnDashboard
            // 
            this.btnDashboard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(33)))), ((int)(((byte)(111)))));
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.btnDashboard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(175)))), ((int)(((byte)(55)))));
            this.btnDashboard.Location = new System.Drawing.Point(813, 16);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(151, 70);
            this.btnDashboard.TabIndex = 5;
            this.btnDashboard.Text = "📈\r\nDASHBOARD";
            this.btnDashboard.UseVisualStyleBackColor = false;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // btnMensagens
            // 
            this.btnMensagens.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMensagens.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(33)))), ((int)(((byte)(111)))));
            this.btnMensagens.FlatAppearance.BorderSize = 0;
            this.btnMensagens.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMensagens.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.btnMensagens.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(175)))), ((int)(((byte)(55)))));
            this.btnMensagens.Location = new System.Drawing.Point(652, 16);
            this.btnMensagens.Name = "btnMensagens";
            this.btnMensagens.Size = new System.Drawing.Size(151, 70);
            this.btnMensagens.TabIndex = 4;
            this.btnMensagens.Text = "📨\r\nMENSAGENS";
            this.btnMensagens.UseVisualStyleBackColor = false;
            this.btnMensagens.Click += new System.EventHandler(this.btnMensagens_Click);
            // 
            // btnFinanceiro
            // 
            this.btnFinanceiro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFinanceiro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(33)))), ((int)(((byte)(111)))));
            this.btnFinanceiro.FlatAppearance.BorderSize = 0;
            this.btnFinanceiro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinanceiro.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.btnFinanceiro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(175)))), ((int)(((byte)(55)))));
            this.btnFinanceiro.Location = new System.Drawing.Point(491, 16);
            this.btnFinanceiro.Name = "btnFinanceiro";
            this.btnFinanceiro.Size = new System.Drawing.Size(151, 70);
            this.btnFinanceiro.TabIndex = 3;
            this.btnFinanceiro.Text = "💵\r\nFINANCEIRO";
            this.btnFinanceiro.UseVisualStyleBackColor = false;
            this.btnFinanceiro.Click += new System.EventHandler(this.btnFinanceiro_Click);
            // 
            // btnOperacional
            // 
            this.btnOperacional.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOperacional.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(33)))), ((int)(((byte)(111)))));
            this.btnOperacional.FlatAppearance.BorderSize = 0;
            this.btnOperacional.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOperacional.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOperacional.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(175)))), ((int)(((byte)(55)))));
            this.btnOperacional.Location = new System.Drawing.Point(330, 15);
            this.btnOperacional.Name = "btnOperacional";
            this.btnOperacional.Size = new System.Drawing.Size(151, 70);
            this.btnOperacional.TabIndex = 2;
            this.btnOperacional.Text = "🛠️\r\nOPERACIONAL";
            this.btnOperacional.UseVisualStyleBackColor = false;
            this.btnOperacional.Click += new System.EventHandler(this.btnOperacional_Click);
            // 
            // btnCatalogo
            // 
            this.btnCatalogo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCatalogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(33)))), ((int)(((byte)(111)))));
            this.btnCatalogo.FlatAppearance.BorderSize = 0;
            this.btnCatalogo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCatalogo.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.btnCatalogo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(175)))), ((int)(((byte)(55)))));
            this.btnCatalogo.Location = new System.Drawing.Point(169, 15);
            this.btnCatalogo.Name = "btnCatalogo";
            this.btnCatalogo.Size = new System.Drawing.Size(151, 70);
            this.btnCatalogo.TabIndex = 1;
            this.btnCatalogo.Text = "🛒\r\nCATALOGO";
            this.btnCatalogo.UseVisualStyleBackColor = false;
            this.btnCatalogo.Click += new System.EventHandler(this.btnCatalogo_Click);
            // 
            // btnPessoas
            // 
            this.btnPessoas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPessoas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(33)))), ((int)(((byte)(111)))));
            this.btnPessoas.FlatAppearance.BorderSize = 0;
            this.btnPessoas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPessoas.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.btnPessoas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(175)))), ((int)(((byte)(55)))));
            this.btnPessoas.Location = new System.Drawing.Point(8, 15);
            this.btnPessoas.Name = "btnPessoas";
            this.btnPessoas.Size = new System.Drawing.Size(151, 70);
            this.btnPessoas.TabIndex = 0;
            this.btnPessoas.Text = "👤\r\nPESSOAS";
            this.btnPessoas.UseVisualStyleBackColor = false;
            this.btnPessoas.Click += new System.EventHandler(this.btnPessoas_Click);
            // 
            // panelConteudo
            // 
            this.panelConteudo.Location = new System.Drawing.Point(200, 100);
            this.panelConteudo.Name = "panelConteudo";
            this.panelConteudo.Size = new System.Drawing.Size(976, 536);
            this.panelConteudo.TabIndex = 2;
            // 
            // pboLogo
            // 
            this.pboLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pboLogo.Image = global::MusicStation_Pablo.Properties.Resources.music_station_vetorizada_1;
            this.pboLogo.Location = new System.Drawing.Point(0, 0);
            this.pboLogo.Name = "pboLogo";
            this.pboLogo.Size = new System.Drawing.Size(200, 100);
            this.pboLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pboLogo.TabIndex = 0;
            this.pboLogo.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1176, 636);
            this.Controls.Add(this.panelConteudo);
            this.Controls.Add(this.panelAbrirTabelas);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "FormBase";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelAbrirTabelas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pboLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.PictureBox pboLogo;
        private System.Windows.Forms.Panel panelAbrirTabelas;
        private System.Windows.Forms.Panel panelTabelas;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnMensagens;
        private System.Windows.Forms.Button btnFinanceiro;
        private System.Windows.Forms.Button btnOperacional;
        private System.Windows.Forms.Button btnCatalogo;
        private System.Windows.Forms.Button btnPessoas;
        private System.Windows.Forms.Panel panelConteudo;
    }
}

