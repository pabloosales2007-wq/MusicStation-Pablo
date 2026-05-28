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

namespace MusicStation_Pablo
{
    public partial class ucDashboard : UserControl
    {
        public ucDashboard()
        {
            InitializeComponent();
            ArredondarPainel(panelUsuarios, 40);
            ArredondarPainel(panelClientes, 40);
            ArredondarPainel(panelAdm, 40);
            ArredondarPainel(panelEmpresa, 40);
            ArredondarPainel(panelLocacoes, 40);
            ArredondarPainel(panelValores, 40);
            ArredondarPainel(panelPedido, 40);
            ArredondarPainel(panelTotal, 60);

        }

        private void ArredondarPainel(Panel painel, int raio)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, raio, raio, 180, 90);
            path.AddArc(painel.Width - raio, 0, raio, raio, 270, 90);
            path.AddArc(painel.Width - raio, painel.Height - raio, raio, raio, 0, 90);
            path.AddArc(0, painel.Height - raio, raio, raio, 90, 90);

            painel.Region = new Region(path);
        }
    }
}
