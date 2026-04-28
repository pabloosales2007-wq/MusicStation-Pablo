using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace MusicStation_Pablo
{
    public partial class ucTabelasPessoas : UserControl
    {
        public ucTabelasPessoas()
        {
            InitializeComponent();
        }

        private void ArredondarBotao(Button btn, int raio)
        {
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();

            path.AddArc(0, 0, raio, raio, 180, 90);
            path.AddArc(btn.Width - raio, 0, raio, raio, 270, 90);
            path.AddArc(btn.Width - raio, btn.Height - raio, raio, raio, 0, 90);
            path.AddArc(0, btn.Height - raio, raio, raio, 90, 90);

            path.CloseFigure();
            btn.Region = new Region(path);
        }

        private void ucTabelas_Load(object sender, EventArgs e)
        {
            ArredondarBotao(btnAdministradores, 20);
            ArredondarBotao(btnCargos, 20);
            ArredondarBotao(btnClientes, 20);
            ArredondarBotao(btnEmpresa, 20);
            ArredondarBotao(btnProfissionais, 20);
            ArredondarBotao(btnProfissionalCargo, 20);
            ArredondarBotao(btnUsuarios, 20);
        }
    }
}
