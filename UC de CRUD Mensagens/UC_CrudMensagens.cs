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
    public partial class UC_CrudMensagens : UserControl
    {
        public UC_CrudMensagens()
        {
            InitializeComponent();

            ChatsTableAdapter clientes = new ChatsTableAdapter();
            var obterClientes = from linha in clientes.GetData() select linha;
            foreach (var cliente in obterClientes)
            {
                cboChat.Items.Add(cliente);
            }
            cboChat.SelectedIndex = -1;

            AtualizarLista();
        }

        private void lboMensagens_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lboMensagens.SelectedItem == null) return;
            MensagensRow mensagem = lboMensagens.SelectedItem as MensagensRow;
            if (mensagem == null) return;




            cboChat.Text = mensagem.chat_id.ToString();
            cboRemetente.Text = mensagem.chat_id.ToString();
            dtpDataEnvio.Value = mensagem.data_envio;
            txtConteudo.Text = mensagem.conteudo;
            chkLida.Checked = mensagem.lida;
        }

        private void btnDeletarUsuarios_Click(object sender, EventArgs e)
        {

        }

        private void btnAtualizarUsuarios_Click(object sender, EventArgs e)
        {

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparElementos();
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

            lboMensagens.ClearSelected();
            lboMensagens.Items.Clear();

            string textoDigitado = txtPesquisa.Text;

            // Instancia o adaptador de usuários do seu projeto
            MensagensTableAdapter dados = new MensagensTableAdapter();

            // Faz a busca usando LINQ (procura tanto no Nome quanto no Email)
            var usuarios = from linha in dados.GetData()
                           where linha.chat_id.ToString().Contains(textoDigitado.ToLower())
                           || linha.conteudo.ToLower().Contains(textoDigitado.ToLower())

                           select linha;

            // Adiciona os usuários filtrados na sua ListBox de usuários
            foreach (var usuario in usuarios)
            {
                lboMensagens.Items.Add(usuario);
            }
        }

        private void btnCadastrarUsuarios_Click(object sender, EventArgs e)
        {

        }

        private void AtualizarLista()
        {
            lboMensagens.Items.Clear();
            MensagensTableAdapter empresas = new MensagensTableAdapter();
            var dados = from linha in empresas.GetData()
                        select linha;
            foreach (MensagensRow dado in dados) lboMensagens.Items.Add(dado);
        }

        private void LimparElementos()
        {
            cboRemetente.SelectedIndex = -1;
            cboChat.SelectedIndex = -1;
            txtConteudo.Clear();
            dtpDataEnvio.Value = DateTime.Now;
            chkLida.Checked = false;
        }
    }
}
