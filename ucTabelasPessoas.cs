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
using System.Drawing.Drawing2D;

namespace MusicStation_Pablo
{
    public partial class ucTabelasPessoas : UserControl
    {
        public Action<UserControl> SolicitarAbertura;
        public ucTabelasPessoas()
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

        private void ucTabelas_Load(object sender, EventArgs e)
        {
            ArredondarBotao(btnAdministradores, 20);
            ArredondarBotao(btnCargos, 20);
            ArredondarBotao(btnClientes, 20);
            ArredondarBotao(btnEmpresa, 20);
            ArredondarBotao(btnProfissionais, 20);
            ArredondarBotao(btnProfissionalCargo, 20);
            ArredondarBotao(btnUsuarios, 20);
        }

        private void btnAdministradores_Click(object sender, EventArgs e)
        {
            // Quando clicar, vai abrir a tela de CRUD de ADMs 
            SolicitarAbertura?.Invoke(new UC_CrudAdms());
        }

        private void btnCargos_Click(object sender, EventArgs e)
        {
            // Quando clicar, vai abrir a tela de CRUD de Cargos 
            SolicitarAbertura?.Invoke(new UC_CrudCargos());
        }

        private void btnProfissionais_Click(object sender, EventArgs e)
        {
            // Quando clicar, vai abrir a tela de CRUD de Profissionais 
            SolicitarAbertura?.Invoke(new UC_CrudProfissionais());
        }

        private void btnProfissionalCargo_Click(object sender, EventArgs e)
        {
            // Quando clicar, vai abrir a tela de CRUD de ProfissionalCargo
            SolicitarAbertura?.Invoke(new UC_CrudProfCargo());
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            // Quando clicar, vai abrir a tela de CRUD de Clientes
            SolicitarAbertura?.Invoke(new UC_CrudClientes());
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            // Quando clicar, vai abrir a tela de CRUD de Usuarios
            SolicitarAbertura?.Invoke(new UC_CrudUsuarios());
        }

        private void btnEmpresa_Click(object sender, EventArgs e)
        {
            // Quando clicar, vai abrir a tela de CRUD de Empresa
            SolicitarAbertura?.Invoke(new UC_CrudEmpresa());
        }
    }
}
