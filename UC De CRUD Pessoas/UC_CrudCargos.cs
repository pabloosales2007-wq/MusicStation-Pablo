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
    public partial class UC_CrudCargos : UserControl
    {
        public UC_CrudCargos()
        {
            InitializeComponent();
            AtualizarLista();
        }

        private void lboCargos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lboCargos.SelectedItem == null) return;
            CargosRow usuarios = lboCargos.SelectedItem as CargosRow;
            if (usuarios == null) return;

            txtNome.Text = usuarios.nome;
            txtDescricao.Text = usuarios.descricao;
        }

        private void btnCadastrarUsuarios_Click(object sender, EventArgs e)
        {
            {
                string nomeCargo = txtNome.Text;
                string descricao = txtDescricao.Text;

                try
                {
                    CargosTableAdapter cargosAdapter = new CargosTableAdapter();

                    // Insere direto passando os textos da tela
                    cargosAdapter.Insert(nomeCargo, descricao);

                    LimparElementos();
                    AtualizarLista();

                    MessageBox.Show("Cargo cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao cadastrar: " + ex.Message, "Erro");
                }
            }
        }

        private void btnAtualizarUsuarios_Click(object sender, EventArgs e)
        {
            {
                if (lboCargos.SelectedItem == null) return;
                CargosRow cargo = lboCargos.SelectedItem as CargosRow;
                if (cargo == null) return;
    
                cargo.nome = txtNome.Text;
                cargo.descricao = txtDescricao.Text;

                try
                {
                    CargosTableAdapter cargosAdapter = new CargosTableAdapter();


                    cargosAdapter.Update(cargo);

                    AtualizarLista();
                    LimparElementos();

                    MessageBox.Show("Cargo atualizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao atualizar: " + ex.Message, "Erro");
                }
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparElementos();
        }

        private void btnDeletarUsuarios_Click(object sender, EventArgs e)
        {
            if (lboCargos.SelectedItem == null) return;
            CargosRow cargo = lboCargos.SelectedItem as CargosRow;
            if (cargo == null) return;

            try
            {
                CargosTableAdapter cargosAdapter = new CargosTableAdapter();

                // Chama a procedure de exclusão que criamos passando o ID do cargo
                cargosAdapter.Delete(cargo.id_cargo);

                AtualizarLista();
                LimparElementos();

                MessageBox.Show("Cargo deletado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao deletar: " + ex.Message, "Erro");
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

            lboCargos.ClearSelected();
            lboCargos.Items.Clear();

            string textoDigitado = txtPesquisa.Text;

            // Instancia o adaptador de usuários do seu projeto
            CargosTableAdapter dados = new CargosTableAdapter();

            // Faz a busca usando LINQ (procura tanto no Nome quanto no Email)
            var cargos = from linha in dados.GetData()
                           where linha.nome.ToLower().Contains(textoDigitado.ToLower())
                              || linha.descricao.ToLower().Contains(textoDigitado.ToLower())
                           select linha;

            // Adiciona os usuários filtrados na sua ListBox de usuários
            foreach (var cargo in cargos)
            {
                lboCargos.Items.Add(cargo);
            }
        }

        private void AtualizarLista()
        {
            lboCargos.Items.Clear();
            CargosTableAdapter cargos = new CargosTableAdapter();
            var dados = from linha in cargos.GetData()
                        select linha;
            foreach (CargosRow dado in dados) lboCargos.Items.Add(dado);

        }

        private void LimparElementos()
        {
            txtNome.Clear();
            txtDescricao.Clear();
            txtPesquisa.Clear();
            
        }
    }
}
