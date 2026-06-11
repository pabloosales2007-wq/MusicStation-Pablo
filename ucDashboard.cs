using MusicStation_Pablo.MusicStationDataSetTableAdapters;
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
using System.Windows.Forms.DataVisualization.Charting;

namespace MusicStation_Pablo
{
    public partial class ucDashboard : UserControl
    {
        public ucDashboard()
        {
            InitializeComponent();
            ArredondarPainel(panelUsuarios, 80);
            ArredondarPainel(panelClientes, 80);
            ArredondarPainel(panelAdm, 80);
            ArredondarPainel(panelEmpresa, 80);
            ArredondarPainel(panelLocacoes, 80);
            ArredondarPainel(panelValores, 80);
            ArredondarPainel(panelPedido, 80);
            ArredondarPainel(panelTotal, 80);

            CarregarGraficoPedidos();
            CarregarGraficoFaturamento();
            CarregarUltimosPedidos();
            CarregarTotais();
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


        // ========== VERDE - Pedidos por Status ==========
        private void CarregarGraficoPedidos()
        {
            ObterPedidosPorStatusTableAdapter adapter = new ObterPedidosPorStatusTableAdapter();
            var dados = adapter.GetData();

            chartPedidos.Series.Clear();
            chartPedidos.Series.Add("Pedidos");
            chartPedidos.Series["Pedidos"].ChartType = SeriesChartType.Bar;

            foreach (var linha in dados)
            {
                chartPedidos.Series["Pedidos"].Points.AddXY(
                    linha.acompanhamento,
                    linha.quantidade
                );
            }
        }

        // ========== AZUL - Faturamento Mensal ==========
        private void CarregarGraficoFaturamento()
        {
            ObterFaturamentoMensalTableAdapter adapter = new ObterFaturamentoMensalTableAdapter();
            var dados = adapter.GetData();

            chartFaturamento.Series.Clear();
            chartFaturamento.Series.Add("Faturamento");
            chartFaturamento.Series["Faturamento"].ChartType = SeriesChartType.Line;


            foreach (var linha in dados)
            {
                chartFaturamento.Series["Faturamento"].Points.AddXY(
                    $"{linha.mes}/{linha.ano}",
                    linha.total
                );
            }
        }

        // ========== PRETO - Últimos Pedidos ==========
        private void CarregarUltimosPedidos()
        {
            ObterPedidosTableAdapter adapter = new ObterPedidosTableAdapter();
            var dados = adapter.GetData();

            lboPedidos.Items.Clear();

            foreach (var linha in dados)
            {
                lboPedidos.Items.Add(
                    $"#{linha.id_pedido} | {linha.NomeCliente} | " +
                    $"R$ {linha.total:F2} | {linha.acompanhamento}"
                );
            }
        }


        private void CarregarTotais()
        {
            ObterTotaisDashboardTableAdapter adapter = new ObterTotaisDashboardTableAdapter();
            var dados = adapter.GetData()[0]; // só tem 1 linha

            lblNusuarios.Text = dados.total_usuarios.ToString();
            lblNclientes.Text = dados.total_clientes.ToString();
            lblNadmin.Text = dados.total_admins.ToString();
            lblNempresas.Text = dados.total_empresas.ToString();
            lblNlocacoes.Text = dados.total_locacoes.ToString();
        }



    }
}
