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
    public partial class UC_CrudClientes : UserControl
    {
        public UC_CrudClientes()
        {
            InitializeComponent();
            AtualizarLista();
        }

        private void lboClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lboClientes.SelectedItem == null) return;
            ClientesRow cliente = lboClientes.SelectedItem as ClientesRow;
            if (cliente == null) return;

            txtNomeCliente.Text = cliente.NomeCliente;
            txtTelefone.Text = cliente.telefone;
            txtRua.Text = cliente.rua;
            txtNumero.Text = cliente.numero;
            txtNomeCliente.Text = cliente.NomeCliente;
            txtEmail.Text = cliente.EmailCliente;
        }

        private void btnAtualizarUsuarios_Click(object sender, EventArgs e)
        {
            if (lboClientes.SelectedItem == null) return;
            ClientesRow cliente = lboClientes.SelectedItem as ClientesRow;
            if (cliente == null) return;

            string nome = txtNomeCliente.Text;
            string email = txtEmail.Text;
            string senha = txtSenha.Text;
            string telefone = txtTelefone.Text;
            string rua = txtRua.Text;
            string numero = txtNumero.Text;

            try
            {
                ClientesTableAdapter clientes = new ClientesTableAdapter();

                // Passa os IDs do registro selecionado + os novos dados da tela
                clientes.Update(cliente.id_cliente, cliente.usuario_id, nome, email, senha, telefone, rua, numero);

                LimparElementos();
                AtualizarLista();

                MessageBox.Show("Cliente atualizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().Name);
            }
        }

        private void btnCadastrarUsuarios_Click(object sender, EventArgs e)
        {
            string nome = txtNomeCliente.Text;
            string email = txtEmail.Text;
            string senha = txtSenha.Text;
            string telefone = txtTelefone.Text;
            string rua = txtRua.Text;
            string numero = txtNumero.Text;

            try
            {
                ClientesTableAdapter clientes = new ClientesTableAdapter();

                clientes.Insert(nome, email, senha, telefone, rua, numero);

                LimparElementos();
                AtualizarLista();

                MessageBox.Show("Cliente cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().Name);
            }
        }

        private void btnDeletarUsuarios_Click(object sender, EventArgs e)
        {
            if (lboClientes.SelectedItem == null) return;
            ClientesRow cliente = lboClientes.SelectedItem as ClientesRow;
            if (cliente == null) return;



            ClientesTableAdapter clientes = new ClientesTableAdapter();
            clientes.Delete(cliente.id_cliente, cliente.usuario_id);



            // Reseta a interface após a exclusão
            AtualizarLista();
            LimparElementos();

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

            lboClientes.ClearSelected();
            lboClientes.Items.Clear();

            string textoDigitado = txtPesquisa.Text;

            // Instancia o adaptador de usuários do seu projeto
            ClientesTableAdapter dados = new ClientesTableAdapter();

            // Faz a busca usando LINQ (procura tanto no Nome quanto no Email)
            var usuarios = from linha in dados.GetData()
                           where linha.NomeCliente.ToLower().Contains(textoDigitado.ToLower())

                           select linha;

            // Adiciona os usuários filtrados na sua ListBox de usuários
            foreach (var usuario in usuarios)
            {
                lboClientes.Items.Add(usuario);
            }
        }

        private void AtualizarLista()
        {
            lboClientes.Items.Clear();
            ClientesTableAdapter cargos = new ClientesTableAdapter();
            var dados = from linha in cargos.GetData()
                        select linha;
            foreach (ClientesRow dado in dados) lboClientes.Items.Add(dado);

        }

        private void LimparElementos()
        {
            txtNomeCliente.Clear();
            txtPesquisa.Clear();
            txtRua.Clear();
            txtTelefone.Clear();
            txtNumero.Clear();
            txtEmail.Clear();
            txtSenha.Clear();

        }
    }
}
