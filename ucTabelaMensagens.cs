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
    
    public partial class ucTabelaMensagens : UserControl
    {
        public Action<UserControl> SolicitarAbertura;
        public ucTabelaMensagens()
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

        private void ucTabelaMensagens_Load(object sender, EventArgs e)
        {
        
            ArredondarBotao(btnAvaliacoes, 20);
            ArredondarBotao(btnChats, 20);
            ArredondarBotao(btnMensagens, 20);
            ArredondarBotao(btnNotificacoes, 20);

        }

        private void btnMensagens_Click(object sender, EventArgs e)
        {
            // Quando clicar, vai abrir a tela de CRUD de Mensagens
            SolicitarAbertura?.Invoke(new UC_CrudMensagens());
        }

        private void btnAvaliacoes_Click(object sender, EventArgs e)
        {
            // Quando clicar, vai abrir a tela de CRUD de Avaliações
            SolicitarAbertura?.Invoke(new UC_CrudAvaliacoes());
        }

        private void btnNotificacoes_Click(object sender, EventArgs e)
        {
            // Quando clicar, vai abrir a tela de CRUD de Notificações
            SolicitarAbertura?.Invoke(new UC_CrudNotificacoes());
        }

        private void btnChats_Click(object sender, EventArgs e)
        {
            // Quando clicar, vai abrir a tela de CRUD de Chats
            SolicitarAbertura?.Invoke(new UC_CrudChats());
        }
    }
}
