using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace MusicStation_Pablo
{
    public partial class Form1 : Form
    {
        public Form1()
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


        //Arrendondar botoes
        private void Form1_Load(object sender, EventArgs e)
        {
            ArredondarBotao(btnPessoas, 20);
            ArredondarBotao(btnCatalogo, 20);
            ArredondarBotao(btnDashboard, 20);
            ArredondarBotao(btnFinanceiro, 20);
            ArredondarBotao(btnMensagens, 20);
            ArredondarBotao(btnOperacional, 20);
        }
        #endregion

        #region //Metodo de abrir um UserControl em um panel
        public void ExibirUserControl(UserControl novoControle, Panel painelDestino)
        {
            // 1. Limpa o painel e libera a memória dos controles antigos
            if (painelDestino.Controls.Count > 0)
            {
                for (int i = painelDestino.Controls.Count - 1; i >= 0; i--)
                {
                    Control controleAntigo = painelDestino.Controls[i];

                    // Remove do painel
                    painelDestino.Controls.Remove(controleAntigo);

                    // Libera recursos e handles do Windows
                    controleAntigo.Dispose();
                }
            }

            // 2. Configura o novo controle para ocupar todo o espaço do painel
            novoControle.Dock = DockStyle.Fill;

            // 3. Adiciona o novo controle ao painel
            painelDestino.Controls.Add(novoControle);
        }
        #endregion

        private void btnPessoas_Click(object sender, EventArgs e)
        {
            ucTabelasPessoas ucTabelas = new ucTabelasPessoas();
            ExibirUserControl(ucTabelas, panelTabelas);
        }

        private void btnCatalogo_Click(object sender, EventArgs e)
        {
            ucTabelaCatalogo ucTabelaCatalogo = new ucTabelaCatalogo();
            ExibirUserControl(ucTabelaCatalogo, panelTabelas);
        }

        private void btnOperacional_Click(object sender, EventArgs e)
        {
            ucTabelaOperacional ucTabelaOperacional = new ucTabelaOperacional();
            ExibirUserControl(ucTabelaOperacional, panelTabelas);
        }

        private void btnFinanceiro_Click(object sender, EventArgs e)
        {
            ucTabelaFinanceiro ucTabelaFinanceiro = new ucTabelaFinanceiro();
            ExibirUserControl(ucTabelaFinanceiro, panelTabelas);
        }

        private void btnMensagens_Click(object sender, EventArgs e)
        {
            ucTabelaMensagens ucTabelaMensagens = new ucTabelaMensagens();
            ExibirUserControl(ucTabelaMensagens, panelTabelas);
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {

        }
    }
}
