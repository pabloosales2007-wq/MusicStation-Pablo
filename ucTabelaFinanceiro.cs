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
    public partial class ucTabelaFinanceiro : UserControl
    {
        public Action<UserControl> SolicitarAbertura;
        public ucTabelaFinanceiro()
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

        private void ucFinanceiro_Load(object sender, EventArgs e)
        {
            ArredondarBotao(btnPagamentos, 20);
            ArredondarBotao(btnFormasPagamentos, 20);
            ArredondarBotao(btnTransacoesPagamentos, 20);
        }

        private void btnPagamentos_Click(object sender, EventArgs e)
        {
             // Quando clicar, vai abrir a tela de CRUD de Pagamentos
            SolicitarAbertura?.Invoke(new UC_CrudPagamentos());
        }

        private void btnTransacoesPagamentos_Click(object sender, EventArgs e)
        {
            // Quando clicar, vai abrir a tela de CRUD de TranPagamentos 
            SolicitarAbertura?.Invoke(new UC_CrudTranPagamentos());
        }

        private void btnFormasPagamentos_Click(object sender, EventArgs e)
        {
            // Quando clicar, vai abrir a tela de CRUD de TranPagamentos 
            SolicitarAbertura?.Invoke(new UC_CrudFormasPagamentos());
        }
    }
}
