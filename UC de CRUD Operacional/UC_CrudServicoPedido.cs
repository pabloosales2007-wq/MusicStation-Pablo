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
    public partial class UC_CrudServicoPedido : UserControl
    {
        public UC_CrudServicoPedido()
        {
            InitializeComponent();
            AtualizarLista();

            ServicosTableAdapter funcionarios = new ServicosTableAdapter();
            var obterFuncionarios = from linha in funcionarios.GetData() select linha;
            foreach (var funcionario in obterFuncionarios)
            {
                cboServico.Items.Add(funcionario);
            }
            cboServico.SelectedIndex = -1;

            // Carrega todas as requisições (empréstimos ativos) na ListBox
            ProfissionaisTableAdapter requisicoes = new ProfissionaisTableAdapter();
            var obterRequisicao = from linha in requisicoes.GetData() select linha;
            foreach (var requisicao in obterRequisicao)
            {
                cboProfissional.Items.Add(requisicao);
            }
            cboProfissional.SelectedIndex = -1;



        }

        private void AtualizarLista()
        {
            lboServicosPedidos.Items.Clear();
            Servicos_PedidosTableAdapter servicos = new Servicos_PedidosTableAdapter();
            var dados = from linha in servicos.GetData()
                        select linha;
            foreach (Servicos_PedidosRow dado in dados) lboServicosPedidos.Items.Add(dado);

        }



        private void LimparElementos()
        {
            txtValorServico.Clear();
            cboProfissional.SelectedIndex = 0;
            cboServico.SelectedIndex = 0;
            txtObs.Clear();
            lblPedidoInfo.Text = "Itens do Pedido: Cliente - Data";
        }


        private void lboServicosPedidos_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (lboServicosPedidos.SelectedItem == null) return;
            Servicos_PedidosRow pedidos = lboServicosPedidos.SelectedItem as Servicos_PedidosRow;
            if (pedidos == null) return;

            txtObs.Text = pedidos.observacao;
            txtValorServico.Text = pedidos.valor_servico.ToString();
            cboProfissional.Text = pedidos.NomeProfissional;
            cboServico.Text = pedidos.NomeServico;


            lblPedidoInfo.Text = $"Itens do Pedido: Cliente {pedidos.NomeCliente} - Data {pedidos.data_pedido.ToString("dd/MM/yyyy")}";
        }

        private void btnDeletarUsuarios_Click(object sender, EventArgs e)
        {
            if (lboServicosPedidos.SelectedItem == null) return;
            var pedido = lboServicosPedidos.SelectedItem as Servicos_PedidosRow;
            if (pedido == null) return;

            try
            {
                Servicos_PedidosTableAdapter pedidos = new Servicos_PedidosTableAdapter();
                pedidos.Delete(pedido.id_item);

                LimparElementos();
                AtualizarLista();

                MessageBox.Show("Pedido removido com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void btnAtualizarUsuarios_Click(object sender, EventArgs e)
        {
            if (lboServicosPedidos.SelectedItem == null) return;
            Servicos_PedidosRow servico = lboServicosPedidos.SelectedItem as Servicos_PedidosRow;
            if (servico == null) return;

            string servicoss = cboServico.Text;
            string profissional = cboProfissional.Text;
            decimal valorServico = decimal.Parse(txtValorServico.Text);
            string obs = txtObs.Text;


            try
            {
                Servicos_PedidosTableAdapter servicos = new Servicos_PedidosTableAdapter();
                servicos.Update(servico.id_item, servico.servico_id,servico.profissional_id, valorServico, obs);

                LimparElementos();
                AtualizarLista();
                MessageBox.Show("Pedido Serviço atualizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().Name);
            }
        }

        private void btnCadastrarUsuarios_Click(object sender, EventArgs e)
        {
            int pedido_id = Convert.ToInt32(cboServico.SelectedValue);
            int servico_id = Convert.ToInt32(cboServico.SelectedValue);
            int profissional_id = Convert.ToInt32(cboProfissional.SelectedValue);

            decimal valorServico = decimal.Parse(txtValorServico.Text);
            string observacao = txtObs.Text;

            try
            {
                Servicos_PedidosTableAdapter pedidos = new Servicos_PedidosTableAdapter();

                pedidos.Insert( pedido_id,servico_id,profissional_id,valorServico,observacao);

                LimparElementos();
                AtualizarLista();

                MessageBox.Show(
                    "Pedido cadastrado com sucesso!",
                    "Sucesso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
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
                AtualizarLista();
                return;
            }

            lboServicosPedidos.ClearSelected();
            lboServicosPedidos.Items.Clear();

            string textoDigitado = txtPesquisa.Text;


            Servicos_PedidosTableAdapter dados = new Servicos_PedidosTableAdapter();

            var usuarios = from linha in dados.GetData()
                           where linha.NomeProfissional.ToLower().Contains(textoDigitado.ToLower())
                              || linha.NomeServico.ToLower().Contains(textoDigitado.ToLower())
                           select linha;

            // Adiciona os usuários filtrados na sua ListBox de usuários
            foreach (var usuario in usuarios)
            {
                lboServicosPedidos.Items.Add(usuario);
            }
        }
    }
}
