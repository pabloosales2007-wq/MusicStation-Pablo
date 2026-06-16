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
    public partial class UC_CrudChats : UserControl
    {
        public UC_CrudChats()
        {
            InitializeComponent();
            UsuariosTableAdapter clientes = new UsuariosTableAdapter();
            var obterClientes = from linha in clientes.GetData() select linha;
            foreach (var cliente in obterClientes)
            {
                cboUsuario1.Items.Add(cliente);
            }
            cboUsuario1.SelectedIndex = -1;

            UsuariosTableAdapter usuarios = new UsuariosTableAdapter();
            var obterUsuarios= from linha in usuarios.GetData() select linha;
            foreach (var usuario in obterUsuarios)
            {
                cboUsuario2.Items.Add(usuario);
            }
            cboUsuario2.SelectedIndex = -1;
            AtualizarLista();
        }


        private void AtualizarLista()
        {
            lboChats.Items.Clear();
            ChatsTableAdapter empresas = new ChatsTableAdapter();
            var dados = from linha in empresas.GetData()
                        select linha;
            foreach (ChatsRow dado in dados) lboChats.Items.Add(dado);

        }

        private void LimparElementos()
        {
            cboUsuario1.SelectedIndex = -1;
            cboUsuario2.SelectedIndex = -1;
            dtpDataCriacao.Value = DateTime.Now;

        }

        private void lboChats_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lboChats.SelectedItem == null) return;
            ChatsRow admin = lboChats.SelectedItem as ChatsRow;
            if (admin == null) return;

            cboUsuario1.Text = admin.NomeUsuario1;
            cboUsuario2.Text = admin.NomeUsuario2;
            dtpDataCriacao.Value = admin.data_criacao;
        }

        private void btnDeletarUsuarios_Click(object sender, EventArgs e)
        {
            if (lboChats.SelectedItem == null) return;
            ChatsRow chats = lboChats.SelectedItem as ChatsRow;
            if (chats == null) return;




            ChatsTableAdapter clientes = new ChatsTableAdapter();
            clientes.Delete(chats.id_chat);

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparElementos();
        }

        private void btnAtualizarUsuarios_Click(object sender, EventArgs e)
        {

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

            lboChats.ClearSelected();
            lboChats.Items.Clear();

            string textoDigitado = txtPesquisa.Text;

            // Instancia o adaptador de usuários do seu projeto
            ChatsTableAdapter dados = new ChatsTableAdapter();

            // Faz a busca usando LINQ (procura tanto no Nome quanto no Email)
            var usuarios = from linha in dados.GetData()
                           where linha.NomeUsuario1.ToLower().Contains(textoDigitado.ToLower())
                           || linha.NomeUsuario2.ToLower().Contains(textoDigitado.ToLower())

                           select linha;

            // Adiciona os usuários filtrados na sua ListBox de usuários
            foreach (var usuario in usuarios)
            {
                lboChats.Items.Add(usuario);
            }
        }

        private void btnCadastrarUsuarios_Click(object sender, EventArgs e)
        {

        }
    }
}
