using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicStation_Pablo
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void panelLogin_Paint(object sender, PaintEventArgs e)
        {
            int raio = 20; // Ajuste aqui o nível do arredondamento
            Rectangle bordas = new Rectangle(0, 0, panelLogin.Width, panelLogin.Height);
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();

            path.AddArc(bordas.X, bordas.Y, raio, raio, 180, 90);
            path.AddArc(bordas.Width - raio, bordas.Y, raio, raio, 270, 90);
            path.AddArc(bordas.Width - raio, bordas.Height - raio, raio, raio, 0, 90);
            path.AddArc(bordas.X, bordas.Height - raio, raio, raio, 90, 90);
            path.CloseAllFigures();

            panelLogin.Region = new Region(path);

            // Opcional: Desenhar uma borda suave
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            using (Pen pen = new Pen(Color.Black, 1)) // Cor da borda
            {
                e.Graphics.DrawPath(pen, path);
            }
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            Form1 principal = new Form1();
            principal.FormClosed += (s, args) => Application.Exit();
            principal.Show();
            this.Hide();
        }
    }
}
