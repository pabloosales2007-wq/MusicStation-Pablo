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
    public partial class UC_CrudLocacoes : UserControl
    {
        public UC_CrudLocacoes()
        {
            InitializeComponent();

            ClientesTableAdapter clientes = new ClientesTableAdapter();
            var obterClientes = from linha in clientes.GetData() select linha;
            foreach (var cliente in obterClientes)
            {
                cboCliente.Items.Add(cliente);
            }
            cboCliente.SelectedIndex = -1;



            AtualizarLista();
        }

        private void lboLocacoes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lboLocacoes.SelectedItem == null) return;
            LocacoesRow locacao = lboLocacoes.SelectedItem as LocacoesRow;
            if (locacao == null) return;

            dtpInicio.Value = locacao.data_inicio;
            dtpFim.Value = locacao.data_fim;
            txtTotal.Text = locacao.valor_total.ToString("F2");
            cboStatus.Text = locacao.status;
            cboCliente.Text = locacao.NomeCliente;

            lblNomeLocacao.Text = $"N° da Locação:  {locacao.id_locacao} "; 
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            TextBox pesquisa = sender as TextBox;

            if (pesquisa.Text == "")
            {
                AtualizarLista();
                return;
            }

            lboLocacoes.ClearSelected();
            lboLocacoes.Items.Clear();

            string textoDigitado = txtPesquisa.Text;


            LocacoesTableAdapter dados = new LocacoesTableAdapter();

            var usuarios = from linha in dados.GetData()
                           where linha.NomeCliente.ToLower().Contains(textoDigitado.ToLower())
                              || linha.id_locacao.ToString().Contains(textoDigitado.ToLower())
                           select linha;

            // Adiciona os usuários filtrados na sua ListBox de usuários
            foreach (var usuario in usuarios)
            {
                lboLocacoes.Items.Add(usuario);
            }
        }

        private void btnDeletarUsuarios_Click(object sender, EventArgs e)
        {

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {

        }

        private void btnAtualizarUsuarios_Click(object sender, EventArgs e)
        {

        }

        private void btnCadastrarUsuarios_Click(object sender, EventArgs e)
        {

        }

        private void AtualizarLista()
        {
            lboLocacoes.Items.Clear();
            LocacoesTableAdapter servicos = new LocacoesTableAdapter();
            var dados = from linha in servicos.GetData()
                        select linha;
            foreach (LocacoesRow dado in dados) lboLocacoes.Items.Add(dado);

        }



        private void LimparElementos()
        {
            txtTotal.Clear();
            lboLocacoes.Text = "N° da Locação";
            cboStatus.SelectedIndex = 0;
            dtpInicio.Value = DateTime.Now;
            dtpFim.Value = DateTime.Now;
        }
    }
}
