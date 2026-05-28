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
        

        public void AlterarConteudo(UserControl uc)
        {
            // Limpa o painel de conteúdo
            if (panelConteudo.Controls.Count > 0)
            {
                panelConteudo.Controls[0].Dispose();
            }

            panelConteudo.Controls.Clear();

            // Configura e adiciona o novo UserControl
            uc.Dock = DockStyle.Fill;
            panelConteudo.Controls.Add(uc);
        }


        //Arrendondar botoes
        private void Form1_Load(object sender, EventArgs e)
        {
            
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

            // Conectamos a Action do UserControl ao método do Form1
            // "Quando o ucTabelas pedir para abrir algo, use o ExibirUserControl no panelConteudo"
            ucTabelas.SolicitarAbertura = (proximaTela) =>
            {
                ExibirUserControl(proximaTela, panelConteudo); // panelConteudo é o painel principal do CRUD
            };

            // Exibe o menu de botões (Usuários, Admins) no painel de tabelas
            ExibirUserControl(ucTabelas, panelTabelas);

        }

        private void btnCatalogo_Click(object sender, EventArgs e)
        {
            ucTabelaCatalogo ucTabelaCatalogo = new ucTabelaCatalogo();

            ucTabelaCatalogo.SolicitarAbertura = (proximaTela) =>
            {
                ExibirUserControl(proximaTela, panelConteudo); // panelConteudo é o painel principal do CRUD
            };

            ExibirUserControl(ucTabelaCatalogo, panelTabelas);
        }

        private void btnOperacional_Click(object sender, EventArgs e)
        {
            ucTabelaOperacional ucTabelaOperacional = new ucTabelaOperacional();

            ucTabelaOperacional.SolicitarAbertura = (proximaTela) =>
            { 
                ExibirUserControl(proximaTela, panelConteudo); // panelConteudo é o painel principal do CRUD
            };


            ExibirUserControl(ucTabelaOperacional, panelTabelas);
        }

        private void btnFinanceiro_Click(object sender, EventArgs e)
        {
            ucTabelaFinanceiro ucTabelaFinanceiro = new ucTabelaFinanceiro();

            ucTabelaFinanceiro.SolicitarAbertura = (proximaTela) =>
            {
                ExibirUserControl(proximaTela, panelConteudo); // panelConteudo é o painel principal do CRUD
            };


            ExibirUserControl(ucTabelaFinanceiro, panelTabelas);
        }

        private void btnMensagens_Click(object sender, EventArgs e)
        {
            ucTabelaMensagens ucTabelaMensagens = new ucTabelaMensagens();

            ucTabelaMensagens.SolicitarAbertura = (proximaTela) =>
            { 
                ExibirUserControl(proximaTela, panelConteudo); // panelConteudo é o painel principal do CRUD
            };


            ExibirUserControl(ucTabelaMensagens, panelTabelas);
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            
        }

        private void pboMenu_Click(object sender, EventArgs e)
        {
            FormLogin formLogin = new FormLogin();
            formLogin.Show();
            this.Close();
            
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            panelConteudo.Controls.Clear();
            panelTabelas.Controls.Clear();

        }
    }
}
