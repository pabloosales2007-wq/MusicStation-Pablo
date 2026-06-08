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
    public partial class UC_CrudPedidos : UserControl
    {
        public UC_CrudPedidos()
        {
            InitializeComponent();
            AtualizarLista();
        }

        private void AtualizarLista()
        {
            lboPedidos.Items.Clear();
            PedidosTableAdapter servicos = new PedidosTableAdapter();
            var dados = from linha in servicos.GetData()
                        select linha;
            foreach (PedidosRow dado in dados) lboPedidos.Items.Add(dado);

        }

        private void LimparElementos()
        {
            txtNome.Clear();
            txtPesquisa.Clear();
            txtEmail.Clear();
            txtTotal.Clear();
            dtpDataPedido.Value = DateTime.Now;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparElementos();
        }

        private void btnDeletarUsuarios_Click(object sender, EventArgs e)
        {
            if (lboPedidos.SelectedItem == null) return;
            var pedido = lboPedidos.SelectedItem as PedidosRow;
            if (pedido == null) return;

            try
            {
                PedidosTableAdapter pedidos = new PedidosTableAdapter();
                pedidos.Delete(pedido.id_pedido);

                LimparElementos();
                AtualizarLista();

                MessageBox.Show("Pedido removido com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().Name);
            }
        }

        private void btnCadastrarUsuarios_Click(object sender, EventArgs e)
        {
            int cliente = int.Parse(txtNome.Text);
            decimal total = decimal.Parse(txtTotal.Text);
            string acompanhamento = cboAcompanhamento.Text; ;

            try
            {
                PedidosTableAdapter pedidos = new PedidosTableAdapter();
                pedidos.Insert(cliente, total, acompanhamento);

                LimparElementos();
                AtualizarLista();

                MessageBox.Show("Pedido cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().Name);
            }
        }

        private void btnAtualizarUsuarios_Click(object sender, EventArgs e)
        {
            if (lboPedidos.SelectedItem == null) return;
            var pedido = lboPedidos.SelectedItem as PedidosRow;
            if (pedido == null) return;

            try
            {

                PedidosTableAdapter pedidos = new PedidosTableAdapter();
                pedidos.Update(pedido.id_pedido, cboAcompanhamento.Text);

                LimparElementos();
                AtualizarLista();

                MessageBox.Show("Pedido atualizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().Name);
            }
        }

        private void lboPedidos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lboPedidos.SelectedItem == null) return;
            PedidosRow pedidos = lboPedidos.SelectedItem as PedidosRow;
            if (pedidos == null) return;

            txtNome.Text = pedidos.NomeCliente;
            txtEmail.Text = pedidos.EmailCliente;
            txtTotal.Text = pedidos.total.ToString();
            dtpDataPedido.Text = pedidos.data_pedido.ToString("dd/MM/yyyy");
            cboAcompanhamento.Text = pedidos.acompanhamento;
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            TextBox pesquisa = sender as TextBox;

            if (pesquisa.Text == "")
            {
                AtualizarLista();
                return;
            }

            lboPedidos.ClearSelected();
            lboPedidos.Items.Clear();

            string textoDigitado = txtPesquisa.Text;


            PedidosTableAdapter dados = new PedidosTableAdapter();

            var usuarios = from linha in dados.GetData()
                           where linha.NomeCliente.ToLower().Contains(textoDigitado.ToLower())
                              || linha.EmailCliente.ToLower().Contains(textoDigitado.ToLower())
                           select linha;

            // Adiciona os usuários filtrados na sua ListBox de usuários
            foreach (var usuario in usuarios)
            {
                lboPedidos.Items.Add(usuario);
            }
        }
    }
}
