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
            AbrirTela(new ucDashboard()); // Abre o dashboard por padrão ao iniciar o Form1
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


            private void AbrirTela(Control tela)
            {
                // Verifica se há algo para remover
                if (panelConteudo.Controls.Count > 0)
                {
                    // Percorre os controles atuais e libera a memória de cada um
                    foreach (Control c in panelConteudo.Controls)
                    {
                        c.Dispose();
                    }
                    panelConteudo.Controls.Clear();
                }

                // Configura e adiciona a nova tela

                tela.Dock = DockStyle.Fill;

                panelConteudo.Controls.Add(tela);
                tela.Show();
            }

        private void btnPessoas_Click(object sender, EventArgs e)
        {
            panelConteudo.Controls.Clear();
            panelTabelas.Controls.Clear();
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
            panelConteudo.Controls.Clear();
            panelTabelas.Controls.Clear();
            ucTabelaCatalogo ucTabelaCatalogo = new ucTabelaCatalogo();

            ucTabelaCatalogo.SolicitarAbertura = (proximaTela) =>
            {
                ExibirUserControl(proximaTela, panelConteudo); // panelConteudo é o painel principal do CRUD
            };

            ExibirUserControl(ucTabelaCatalogo, panelTabelas);
        }

        private void btnOperacional_Click(object sender, EventArgs e)
        {
            panelConteudo.Controls.Clear();
            panelTabelas.Controls.Clear();
            ucTabelaOperacional ucTabelaOperacional = new ucTabelaOperacional();

            ucTabelaOperacional.SolicitarAbertura = (proximaTela) =>
            { 
                ExibirUserControl(proximaTela, panelConteudo); // panelConteudo é o painel principal do CRUD
            };


            ExibirUserControl(ucTabelaOperacional, panelTabelas);
        }

        private void btnFinanceiro_Click(object sender, EventArgs e)
        {
            panelConteudo.Controls.Clear();
            panelTabelas.Controls.Clear();
            ucTabelaFinanceiro ucTabelaFinanceiro = new ucTabelaFinanceiro();

            ucTabelaFinanceiro.SolicitarAbertura = (proximaTela) =>
            {
                ExibirUserControl(proximaTela, panelConteudo); // panelConteudo é o painel principal do CRUD
            };


            ExibirUserControl(ucTabelaFinanceiro, panelTabelas);
        }

        private void btnMensagens_Click(object sender, EventArgs e)
        {
            panelConteudo.Controls.Clear();
            panelTabelas.Controls.Clear();
            ucTabelaMensagens ucTabelaMensagens = new ucTabelaMensagens();

            ucTabelaMensagens.SolicitarAbertura = (proximaTela) =>
            { 
                ExibirUserControl(proximaTela, panelConteudo); // panelConteudo é o painel principal do CRUD
            };


            ExibirUserControl(ucTabelaMensagens, panelTabelas);
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            panelConteudo.Controls.Clear();
            panelTabelas.Controls.Clear();
            ucDashboard ucDashboard = new ucDashboard();
            AbrirTela(ucDashboard);
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
            ucDashboard ucDashboard = new ucDashboard();
            AbrirTela(ucDashboard);
        }
    }
}
