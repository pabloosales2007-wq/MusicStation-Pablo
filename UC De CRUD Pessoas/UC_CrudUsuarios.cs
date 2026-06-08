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
    public partial class UC_CrudUsuarios : UserControl
    {
        public UC_CrudUsuarios()
        {
            InitializeComponent();
            AtualizarLista();

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparElementos();
        }

        private void btnDeletarUsuarios_Click(object sender, EventArgs e)
        {

            if (lboUsuarios.SelectedItem == null) return;
            UsuariosRow usuario = lboUsuarios.SelectedItem as UsuariosRow;
            if (usuario == null) return;



            UsuariosTableAdapter usuarios = new UsuariosTableAdapter();
            usuarios.Delete(usuario.id_usuario);



            // Reseta a interface após a exclusão
            AtualizarLista();
            LimparElementos();

        }

        private void btnCadastrarUsuarios_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            string email = txtEmail.Text;
            string senha = txtSenha.Text;
            string dataCadastro = txtDataCadastro.Text;

            try
            {
                
                UsuariosTableAdapter usuarios = new UsuariosTableAdapter();
                usuarios.Insert(nome, email, senha, DateTime.Now);
                LimparElementos();
                AtualizarLista();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().Name);
            }
        }

        private void btnAtualizarUsuarios_Click(object sender, EventArgs e)
        {
            if (lboUsuarios.SelectedItem == null) return;
            UsuariosRow usuario = lboUsuarios.SelectedItem as UsuariosRow;
            if (usuario == null) return;

            usuario.nome = txtNome.Text;
            usuario.email = txtEmail.Text;
            usuario.senha = txtSenha.Text;

            try
            {

                UsuariosTableAdapter usuarios = new UsuariosTableAdapter();

                usuarios.Update(usuario.id_usuario, usuario.nome, usuario.email, usuario.senha);


                AtualizarLista();
                LimparElementos();

                MessageBox.Show("Usuário atualizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                // Caso aconteça algum erro de banco ou digitação, ele entra aqui
                MessageBox.Show("Erro ao atualizar o usuário: " + ex.Message, "Erro");
            }
        }

        private void LimparElementos()
        {
            txtNome.Clear();
            txtEmail.Clear();
            txtPesquisa.Clear();
            txtDataCadastro.Clear();
            txtSenha.Clear();
        }

        private void lboUsuarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lboUsuarios.SelectedItem == null) return;
            UsuariosRow usuarios = lboUsuarios.SelectedItem as UsuariosRow;
            if (usuarios == null) return;

            txtNome.Text = usuarios.nome;
            txtEmail.Text = usuarios.email;
            txtSenha.Text = usuarios.senha;
            txtDataCadastro.Text = usuarios.data_cadastro.ToString("dd/MM/yyyy");

        }

        private void AtualizarLista()
        {
            lboUsuarios.Items.Clear();
            UsuariosTableAdapter usuarios = new UsuariosTableAdapter();
            var dados = from linha in usuarios.GetData()
                        select linha;
            foreach (UsuariosRow dado in dados) lboUsuarios.Items.Add(dado);

        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            // Filtra a ListBox em tempo real conforme o usuário digita o nome ou email
            TextBox pesquisa = sender as TextBox;

            if (pesquisa.Text == "")
            {
                AtualizarLista(); 
                return;
            }

            lboUsuarios.ClearSelected();
            lboUsuarios.Items.Clear();

            string textoDigitado = txtPesquisa.Text;


            UsuariosTableAdapter dados = new UsuariosTableAdapter();

            var usuarios = from linha in dados.GetData()
                           where linha.nome.ToLower().Contains(textoDigitado.ToLower())
                              || linha.email.ToLower().Contains(textoDigitado.ToLower())
                           select linha;

            // Adiciona os usuários filtrados na sua ListBox de usuários
            foreach (var usuario in usuarios)
            {
                lboUsuarios.Items.Add(usuario);
            }
        }

    }
}
