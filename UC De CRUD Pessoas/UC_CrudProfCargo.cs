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
    public partial class UC_CrudProfCargo : UserControl
    {
        public UC_CrudProfCargo()
        {
            InitializeComponent();
            AtualizarLista();

            CargosTableAdapter cargosAdapter = new CargosTableAdapter();

            var obterCargos = from linha in cargosAdapter.GetData()
                              select linha;

            foreach (var cargo in obterCargos)
            {
                cboCargo.Items.Add(cargo);
            }

            cboCargo.SelectedIndex = 0;


        }

        private void lboCargos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lboProfCargos.SelectedItem == null) return;
            Profissional_CargoRow profCargo = lboProfCargos.SelectedItem as Profissional_CargoRow;
            if (profCargo == null) return;

            txtNome.Text = profCargo.NomeProfissional;
            cboCargo.Text = profCargo.NomeCargo;

        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            // Filtra a ListBox em tempo real conforme o usuário digita o Nome do Profissional ou do Cargo
            TextBox pesquisa = sender as TextBox;

            if (pesquisa.Text == "")
            {
                AtualizarLista(); // Recarrega tudo se o campo estiver vazio
                return;
            }

            lboProfCargos.ClearSelected();
            lboProfCargos.Items.Clear();

            string textoDigitado = txtPesquisa.Text.ToLower();

            Profissional_CargoTableAdapter dados = new Profissional_CargoTableAdapter();

            // Faz a busca procurando pelos nomes (textos) trazidos pelos JOINs
            var cargos = from linha in dados.GetData()
                         where linha.ProfissionaisRow.ToString().Contains(textoDigitado)
                            || linha.CargosRow.ToString().Contains(textoDigitado)
                         select linha;

            // Adiciona os registros filtrados na sua ListBox
            foreach (var cargo in cargos)
            {
                lboProfCargos.Items.Add(cargo);
            }
        }

        private void btnAtualizarUsuarios_Click(object sender, EventArgs e)
        {
            if (lboProfCargos.SelectedItem == null) return;
            Profissional_CargoRow linhaAntiga = lboProfCargos.SelectedItem as Profissional_CargoRow;
            if (linhaAntiga == null) return;

            string nomeProfissionalTela = txtNome.Text;

            try
            {
                ProfissionaisTableAdapter profAdapter = new ProfissionaisTableAdapter();
                int novoIdProfissional = 0;

                foreach (var p in profAdapter.GetData())
                {
                    if (p.nome.ToLower() == nomeProfissionalTela.ToLower())
                    {
                        novoIdProfissional = p.id_profissional;
                        break;
                    }
                }

                if (novoIdProfissional == 0)
                {
                    MessageBox.Show("Profissional não encontrado! Verifique o nome.", "Aviso");
                    return;
                }

                CargosRow cargoSelecionado = cboCargo.SelectedItem as CargosRow;
                if (cargoSelecionado == null)
                {
                    MessageBox.Show("Por favor, selecione um cargo válido.", "Aviso");
                    return;
                }
                int novoIdCargo = cargoSelecionado.id_cargo;

                Profissional_CargoTableAdapter profCargo = new Profissional_CargoTableAdapter();
                profCargo.Update(
                    linhaAntiga.id_profissional,
                    linhaAntiga.id_cargo,
                    novoIdProfissional,
                    novoIdCargo
                );

                LimparElementos();
                AtualizarLista();

                MessageBox.Show("Vínculo atualizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar o vínculo: " + ex.Message, "Erro");
            }
        }

        private void btnCadastrarUsuarios_Click(object sender, EventArgs e)
        {
            string nomeDigitado = txtNome.Text;

            try
            {

                ProfissionaisTableAdapter profAdapter = new ProfissionaisTableAdapter();

                int idProfissional = 0;

                foreach (var p in profAdapter.GetData())
                {
                    if (p.nome.ToLower() == nomeDigitado.ToLower())
                    {
                        idProfissional = p.id_profissional;
                        break;
                    }
                }

                if (idProfissional == 0)
                {
                    MessageBox.Show("Profissional não encontrado! Verifique se o nome foi digitado corretamente.", "Aviso");
                    return;
                }

                CargosRow cargoSelecionado = cboCargo.SelectedItem as CargosRow;
                if (cargoSelecionado == null)
                {
                    MessageBox.Show("Por favor, selecione um cargo válido.", "Aviso");
                    return;
                }
                int idCargo = cargoSelecionado.id_cargo;

                Profissional_CargoTableAdapter profCargo = new Profissional_CargoTableAdapter();
                profCargo.Insert(idProfissional, idCargo);

                LimparElementos();
                AtualizarLista();

                MessageBox.Show("Vínculo cadastrado com sucesso usando os nomes!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar: " + ex.Message, "Erro");
            }
        }

        private void btnDeletarUsuarios_Click(object sender, EventArgs e)
        {
            if (lboProfCargos.SelectedItem == null) return;
            Profissional_CargoRow profissional = lboProfCargos.SelectedItem as Profissional_CargoRow;
            if (profissional == null) return;

            try
            {
                Profissional_CargoTableAdapter profissionais = new Profissional_CargoTableAdapter();

                profissionais.Delete(profissional.id_profissional, profissional.id_cargo);

                AtualizarLista();
                LimparElementos();

                MessageBox.Show("Vínculo removido com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao deletar: " + ex.Message);
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparElementos();
        }

        private void AtualizarLista()
        {
            lboProfCargos.Items.Clear();
            Profissional_CargoTableAdapter cargos = new Profissional_CargoTableAdapter();
            var dados = from linha in cargos.GetData()
                        select linha;
            foreach (Profissional_CargoRow dado in dados) lboProfCargos.Items.Add(dado);

        }

        private void LimparElementos()
        {
            txtNome.Clear();
            cboCargo.Text ="";
            txtPesquisa.Clear();

        }
    }
}
