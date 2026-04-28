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
    public partial class ucTabelaCatalogo : UserControl
    {
        public ucTabelaCatalogo()
        {
            InitializeComponent();
        }

        #region
        //Metodo para arredondar os botao
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
        #endregion

        #region
        private void ucTabelaCatalogo_Load(object sender, EventArgs e)
        {
            ArredondarBotao(btnServicos, 20);
            ArredondarBotao(btnInstrumentos, 20);
        }
        #endregion
    }
}
