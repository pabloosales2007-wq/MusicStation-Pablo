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
using static MusicStation_Pablo.MusicStationDataSet;

namespace MusicStation_Pablo
{
    public partial class UC_CrudAdms : UserControl
    {
        public UC_CrudAdms()
        {
            InitializeComponent();
            AtualizarLista();
        }

        private void lboAdministradores_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lboAdministradores.SelectedItem == null) return;
            AdministradoresRow admin = lboAdministradores.SelectedItem as AdministradoresRow;
            if (admin == null) return;

            txtNomeAdmin.Text = admin.NomeAdmin;
            txtEmail.Text = admin.EmailAdmin;
            txtNivelAcesso.Text = admin.nivel_acesso;
            txtObservacao.Text = admin.observacoes;
            
        }

        private void btnDeletarUsuarios_Click(object sender, EventArgs e)
        {
            if (lboAdministradores.SelectedItem == null) return;
            AdministradoresRow admin = lboAdministradores.SelectedItem as AdministradoresRow;
            if (admin == null) return;



            AdministradoresTableAdapter admins = new AdministradoresTableAdapter();
            admins.Delete(admin.id_admin, admin.usuario_id);



            // Reseta a interface após a exclusão
            AtualizarLista();
            LimparElementos();

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparElementos();
        }

        private void btnAtualizarUsuarios_Click(object sender, EventArgs e)
        {
            if (lboAdministradores.SelectedItem == null) return;
            AdministradoresRow admin = lboAdministradores.SelectedItem as AdministradoresRow;
            if (admin == null) return;

            string nome = txtNomeAdmin.Text;
            string email = txtEmail.Text;
            string senha = txtSenha.Text;
            string NivelAcesso = txtNivelAcesso.Text;
            string observacao = txtObservacao.Text;

            try
            {
                AdministradoresTableAdapter Admins = new AdministradoresTableAdapter();

                // Alterado para o nome da procedure e passando as variáveis da tela
                Admins.Update(admin.id_admin, admin.usuario_id, nome, email, senha, NivelAcesso, observacao);

                LimparElementos();
                AtualizarLista();

                MessageBox.Show("Admin atualizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().Name);
            }
        }

        private void btnCadastrarUsuarios_Click(object sender, EventArgs e)
        {
            string nome = txtNomeAdmin.Text;
            string email = txtEmail.Text;
            string senha = txtSenha.Text;
            string nivelAcesso = txtNivelAcesso.Text;
            string observacao = txtObservacao.Text;

            try
            {
                AdministradoresTableAdapter Admins = new AdministradoresTableAdapter();

                Admins.Insert(nome, email, senha, nivelAcesso, observacao);

                LimparElementos();
                AtualizarLista();

                MessageBox.Show("Administrador cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().Name);
            }
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            // Filtra a ListBox em tempo real conforme o usuário digita o nome ou email
            TextBox pesquisa = sender as TextBox;

            if (pesquisa.Text == "")
            {
                AtualizarLista(); // Recarrega todos os usuários se o campo estiver vazio
                return;
            }

            lboAdministradores.ClearSelected();
            lboAdministradores.Items.Clear();

            string textoDigitado = txtPesquisa.Text;

            // Instancia o adaptador de usuários do seu projeto
            AdministradoresTableAdapter dados = new AdministradoresTableAdapter();

            // Faz a busca usando LINQ (procura tanto no Nome quanto no Email)
            var usuarios = from linha in dados.GetData()
                           where linha.NomeAdmin.ToLower().Contains(textoDigitado.ToLower())

                           select linha;

            // Adiciona os usuários filtrados na sua ListBox de usuários
            foreach (var usuario in usuarios)
            {
                lboAdministradores.Items.Add(usuario);
            }
        }

        private void AtualizarLista()
        {
            lboAdministradores.Items.Clear();
            AdministradoresTableAdapter cargos = new AdministradoresTableAdapter();
            var dados = from linha in cargos.GetData()
                        select linha;
            foreach (AdministradoresRow dado in dados) lboAdministradores.Items.Add(dado);

        }

        private void LimparElementos()
        {
            txtNomeAdmin.Clear();
            txtPesquisa.Clear();
            txtEmail.Clear();
            txtSenha.Clear();
            txtNivelAcesso.Clear();
            txtObservacao.Clear();

        }
    }
}
