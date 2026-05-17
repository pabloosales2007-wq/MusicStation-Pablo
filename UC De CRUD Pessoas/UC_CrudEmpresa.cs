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
    public partial class UC_CrudEmpresa : UserControl
    {
        public UC_CrudEmpresa()
        {
            InitializeComponent();
            AtualizarLista();
        }

        private void lboEmpresa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lboEmpresa.SelectedItem == null) return;
            EmpresasRow empresa = lboEmpresa.SelectedItem as EmpresasRow;
            if (empresa == null) return;

            txtNomeEmpresa.Text = empresa.nome_fantasia;
            txtEmail.Text = empresa.email;
            txtRazao_social.Text = empresa.razao_social;
            txtTelefone.Text = empresa.telefone;
            txtDescricao.Text = empresa.descricao;
            txtCNPJ.Text = empresa.cnpj; 
        }

        private void btnDeletarUsuarios_Click(object sender, EventArgs e)
        {
            if (lboEmpresa.SelectedItem == null) return;
            EmpresasRow empresa = lboEmpresa.SelectedItem as EmpresasRow;
            if (empresa == null) return;

            
            DialogResult confirmacao = MessageBox.Show($"Tem certeza que deseja remover a empresa {empresa.nome_fantasia}?", "Confirmar Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirmacao == DialogResult.Yes)
            {
                try
                {
                    EmpresasTableAdapter empresas = new EmpresasTableAdapter();

                    empresas.Delete(empresa.id_empresa, empresa.usuario_id);

                    LimparElementos();
                    AtualizarLista();

                    MessageBox.Show("Empresa removida com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ex.GetType().Name);
                }
            }
        }

        private void btnAtualizarUsuarios_Click(object sender, EventArgs e)
        {
            if (lboEmpresa.SelectedItem == null) return;
            EmpresasRow empresa = lboEmpresa.SelectedItem as EmpresasRow;
            if (empresa == null) return;

            string nomeFantasia = txtNomeEmpresa.Text;
            string razaoSocial = txtRazao_social.Text;
            string cnpj = txtCNPJ.Text;
            string email = txtEmail.Text;
            string telefone = txtTelefone.Text;
            string descricao = txtDescricao.Text;
            string senha = txtSenha.Text;

            try
            {
                EmpresasTableAdapter empresas = new EmpresasTableAdapter();
                empresas.Update(empresa.id_empresa, empresa.usuario_id, nomeFantasia, razaoSocial, cnpj, email, telefone, descricao, senha);

                LimparElementos();
                AtualizarLista();
                MessageBox.Show("Empresa atualizada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

            lboEmpresa.ClearSelected();
            lboEmpresa.Items.Clear();

            string textoDigitado = txtPesquisa.Text;

            // Instancia o adaptador de usuários do seu projeto
            InstrumentosTableAdapter dados = new InstrumentosTableAdapter();

            // Faz a busca usando LINQ (procura tanto no Nome quanto no Email)
            var usuarios = from linha in dados.GetData()
                           where linha.NomeEmpresa.ToLower().Contains(textoDigitado.ToLower())

                           select linha;

            // Adiciona os usuários filtrados na sua ListBox de usuários
            foreach (var usuario in usuarios)
            {
                lboEmpresa.Items.Add(usuario);
            }
        }

        private void btnCadastrarUsuarios_Click(object sender, EventArgs e)
        {
            string nomeFantasia = txtNomeEmpresa.Text;
            string razaoSocial = txtRazao_social.Text;
            string cnpj = txtCNPJ.Text;
            string email = txtEmail.Text;
            string telefone = txtTelefone.Text;
            string descricao = txtDescricao.Text;
            string senha = txtSenha.Text;

            try
            {
                EmpresasTableAdapter empresas = new EmpresasTableAdapter();

                
                empresas.Insert(nomeFantasia, razaoSocial, cnpj, email, telefone, descricao, senha);

                LimparElementos();
                AtualizarLista();

                MessageBox.Show("Empresa cadastrada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().Name);
            }
        }

        private void AtualizarLista()
        {
            lboEmpresa.Items.Clear();
            EmpresasTableAdapter empresas = new EmpresasTableAdapter();
            var dados = from linha in empresas.GetData()
                        select linha;
            foreach (EmpresasRow dado in dados) lboEmpresa.Items.Add(dado);

        }

        private void LimparElementos()
        {
            txtNomeEmpresa.Clear();
            txtPesquisa.Clear();
            txtEmail.Clear();
            txtSenha.Clear();
            txtCNPJ.Clear();
            txtRazao_social.Clear();
            txtTelefone.Clear();
            txtDescricao.Clear();

        }
    }
}
