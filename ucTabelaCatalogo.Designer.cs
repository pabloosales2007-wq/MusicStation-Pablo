namespace MusicStation_Pablo
{
    partial class ucTabelaCatalogo
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnServicos = new System.Windows.Forms.Button();
            this.btnInstrumentos = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.btnServicos, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnInstrumentos, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 14;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(200, 536);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // btnServicos
            // 
            this.btnServicos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(33)))), ((int)(((byte)(111)))));
            this.btnServicos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnServicos.FlatAppearance.BorderSize = 0;
            this.btnServicos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnServicos.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.btnServicos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(175)))), ((int)(((byte)(55)))));
            this.btnServicos.Location = new System.Drawing.Point(3, 125);
            this.btnServicos.Name = "btnServicos";
            this.btnServicos.Size = new System.Drawing.Size(194, 37);
            this.btnServicos.TabIndex = 4;
            this.btnServicos.Text = "Serviços";
            this.btnServicos.UseVisualStyleBackColor = false;
            this.btnServicos.Click += new System.EventHandler(this.btnServicos_Click);
            // 
            // btnInstrumentos
            // 
            this.btnInstrumentos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(33)))), ((int)(((byte)(111)))));
            this.btnInstrumentos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnInstrumentos.FlatAppearance.BorderSize = 0;
            this.btnInstrumentos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInstrumentos.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.btnInstrumentos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(175)))), ((int)(((byte)(55)))));
            this.btnInstrumentos.Location = new System.Drawing.Point(3, 83);
            this.btnInstrumentos.Name = "btnInstrumentos";
            this.btnInstrumentos.Size = new System.Drawing.Size(194, 36);
            this.btnInstrumentos.TabIndex = 3;
            this.btnInstrumentos.Text = "Instrumentos";
            this.btnInstrumentos.UseVisualStyleBackColor = false;
            this.btnInstrumentos.Click += new System.EventHandler(this.btnInstrumentos_Click);
            // 
            // ucTabelaCatalogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ucTabelaCatalogo";
            this.Size = new System.Drawing.Size(200, 536);
            this.Load += new System.EventHandler(this.ucTabelaCatalogo_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnServicos;
        private System.Windows.Forms.Button btnInstrumentos;
    }
}
