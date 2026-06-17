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
    public partial class UC_CrudNotificacoes : UserControl
    {
        public UC_CrudNotificacoes()
        {
            InitializeComponent();

            UsuariosTableAdapter clientes = new UsuariosTableAdapter();
            var obterClientes = from linha in clientes.GetData() select linha;
            foreach (var cliente in obterClientes)
            {
                cboUsuario.Items.Add(cliente);
            }
            cboUsuario.SelectedIndex = -1;

            AtualizarLista();
        }

        private void lboNotificacoes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lboNotificacoes.SelectedItem == null) return;
            NotificacoesRow notificacao = lboNotificacoes.SelectedItem as NotificacoesRow;
            if (notificacao == null) return;


            cboUsuario.SelectedValue = notificacao.usuario_id;
            txtTitulo.Text = notificacao.titulo;
            txtMensagem.Text = notificacao.mensagem;
            cboTipo.Text = notificacao.tipo;
            dtpEnvio.Value = notificacao.data_envio;
            chkLida.Checked = notificacao.lida;
        }

        private void btnDeletarUsuarios_Click(object sender, EventArgs e)
        {
            if (lboNotificacoes.SelectedItem == null) return;
            NotificacoesRow notificacao = lboNotificacoes.SelectedItem as NotificacoesRow;
            if (notificacao == null) return;

            NotificacoesTableAdapter adapter = new NotificacoesTableAdapter();
            adapter.Delete(notificacao.id_notificacao);
            LimparElementos();
            AtualizarLista();
        }

        private void btnAtualizarUsuarios_Click(object sender, EventArgs e)
        {
            if (lboNotificacoes.SelectedItem == null) return;
            NotificacoesRow notificacao = lboNotificacoes.SelectedItem as NotificacoesRow;
            if (notificacao == null) return;

            int usuario_id = (int)cboUsuario.SelectedValue;
            string titulo = txtTitulo.Text;
            string mensagem = txtMensagem.Text;
            string tipo = cboTipo.Text;
            DateTime data = dtpEnvio.Value;
            bool lida = chkLida.Checked;

            try
            {
                NotificacoesTableAdapter adapter = new NotificacoesTableAdapter();
                adapter.Update(notificacao.id_notificacao, notificacao.usuario_id, titulo, mensagem, tipo, data, lida);
                LimparElementos();
                AtualizarLista();
                MessageBox.Show("Notificação atualizada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().Name);
            }
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

            lboNotificacoes.ClearSelected();
            lboNotificacoes.Items.Clear();

            string textoDigitado = txtPesquisa.Text;

            // Instancia o adaptador de usuários do seu projeto
            NotificacoesTableAdapter dados = new NotificacoesTableAdapter();

            // Faz a busca usando LINQ (procura tanto no Nome quanto no Email)
            var usuarios = from linha in dados.GetData()
                           where linha.id_notificacao.ToString().Contains(textoDigitado.ToLower())
                           || linha.mensagem.ToLower().Contains(textoDigitado.ToLower())

                           select linha;

            // Adiciona os usuários filtrados na sua ListBox de usuários
            foreach (var usuario in usuarios)
            {
                lboNotificacoes.Items.Add(usuario);
            }
        }

        private void btnCadastrarUsuarios_Click(object sender, EventArgs e)
        {
            int usuario_id = (int)cboUsuario.SelectedValue;
            string titulo = txtTitulo.Text;
            string mensagem = txtMensagem.Text;
            string tipo = cboTipo.Text;
            DateTime data = dtpEnvio.Value;
            bool lida = chkLida.Checked;

            try
            {
                NotificacoesTableAdapter adapter = new NotificacoesTableAdapter();
                adapter.Insert(usuario_id, titulo, mensagem, tipo, data, lida);
                LimparElementos();
                AtualizarLista();
                MessageBox.Show("Notificação cadastrada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().Name);
            }
        }

        private void LimparElementos()
        {
            cboUsuario.SelectedIndex = -1;
            txtTitulo.Clear();
            cboTipo.SelectedIndex = -1;
            dtpEnvio.Value = DateTime.Now;
            txtMensagem.Clear();
        }

        private void AtualizarLista()
        {
            lboNotificacoes.Items.Clear();
            NotificacoesTableAdapter empresas = new NotificacoesTableAdapter();
            var dados = from linha in empresas.GetData()
                        select linha;
            foreach (NotificacoesRow dado in dados) lboNotificacoes.Items.Add(dado);
        }
    }
}
