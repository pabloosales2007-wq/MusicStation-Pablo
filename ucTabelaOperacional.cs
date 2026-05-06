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
    public partial class ucTabelaOperacional : UserControl
    {
        public Action<UserControl> SolicitarAbertura;
        public ucTabelaOperacional()
        {
            InitializeComponent();
        }

        #region ////Metodo para arredondar os botao
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
        private void ucTabelaOperacional_Load(object sender, EventArgs e)

        {
            ArredondarBotao(btnLocacoes, 20);
            ArredondarBotao(btnLocacoesItens, 20);
            ArredondarBotao(btnPedidos, 20);
            ArredondarBotao(btnServicoPedido, 20);

        }
        #endregion

        private void btnPedidos_Click(object sender, EventArgs e)
        {
            // Quando clicar, vai abrir a tela de CRUD de Pedidos 
            SolicitarAbertura?.Invoke(new UC_CrudPedidos());
        }

        private void btnServicoPedido_Click(object sender, EventArgs e)
        {
            // Quando clicar, vai abrir a tela de CRUD de Serviço Pedido
            SolicitarAbertura?.Invoke(new UC_CrudServicoPedido());
        }

        private void btnLocacoes_Click(object sender, EventArgs e)
        {
            // Quando clicar, vai abrir a tela de CRUD de Locações
            SolicitarAbertura?.Invoke(new UC_CrudLocacoes());
        }

        private void btnLocacoesItens_Click(object sender, EventArgs e)
        {
            // Quando clicar, vai abrir a tela de CRUD de Locações Itens 
            SolicitarAbertura?.Invoke(new UC_CrudLocacoesItens());
        }
    }
}
