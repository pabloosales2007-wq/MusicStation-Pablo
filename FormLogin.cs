using MusicStation_Pablo.MusicStationDataSetTableAdapters;
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
        public bool saida;
        public FormLogin()
        {
            InitializeComponent();
        }

        private void panelLogin_Paint(object sender, PaintEventArgs e)
        {
            int raio = 40; // Ajuste aqui o nível do arredondamento
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
            // Captura as informações digitadas nos campos do formulário
            string nome = txtUsuario.Text;
            string senha = txtSenha.Text;

            // Validação de campos vazios
            if (string.IsNullOrEmpty(nome) || string.IsNullOrEmpty(senha))
            {
                MessageBox.Show("Por favor, preencha todos os campos.", "Aviso");
                return;
            }

            try
            {
                // Instancia o TableAdapter correto que criamos para o administrador
                VerificarLoginAdmin1TableAdapter consulta = new VerificarLoginAdmin1TableAdapter();

                // Faz a busca usando o LINQ (exatamente igual ao padrão do professor)
                var administrador = (from linha in consulta.GetData(nome, senha)
                                     select linha).FirstOrDefault();

                // Se a consulta não retornar nenhuma linha (ou seja, null)
                if (administrador == null)
                {
                    MessageBox.Show("Acesso negado. Nome ou senha incorretos, ou o usuário não é um Administrador.", "Erro de Autenticação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Se o login for válido, exibe as boas-vindas usando o nome que veio do banco
                MessageBox.Show($"Bem-vindo, Administrador {administrador.nome}!", "Acesso Permitido", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Marca a saída como verdadeira se o seu sistema usar essa lógica no Form principal
                saida = true;

                // Abre a tela principal do sistema
                Form1 principal = new Form1();
                principal.Show();

                // Esconde ou fecha a tela de login atual
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().Name);
            }
        }
    }
}
