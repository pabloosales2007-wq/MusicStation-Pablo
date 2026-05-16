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
    public partial class UC_CrudProfissionais : UserControl
    {
        public UC_CrudProfissionais()
        {
            InitializeComponent();
            AtualizarLista();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparElementos();
        }

        private void btnDeletarUsuarios_Click(object sender, EventArgs e)
        {
            {
                if (lboProfissional.SelectedItem == null) return;
                ProfissionaisRow profissional = lboProfissional.SelectedItem as ProfissionaisRow;
                if (profissional == null) return;

                try
                {
                    // 2. Instancia o adaptador de profissionais
                    ProfissionaisTableAdapter profissionaisAdapter = new ProfissionaisTableAdapter();

                    profissionaisAdapter.Delete(profissional.id_profissional);


                    AtualizarLista();
                    LimparElementos();

                    MessageBox.Show("Profissional deletado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao deletar profissional: " + ex.Message, "Erro");
                }
            }
        }

        private void btnCadastrarUsuarios_Click(object sender, EventArgs e)
        {
            // Pegamos o e-mail e o telefone digitados na tela
            string emailDigitado = txtEmail.Text;
            string telefone = txtTelefone.Text;

            try
            {
                
                UsuariosTableAdapter usuariosAdapter = new UsuariosTableAdapter();
                ProfissionaisTableAdapter profissionaisAdapter = new ProfissionaisTableAdapter();

                var usuarioExistente = (from u in usuariosAdapter.GetData()
                                        where u.email.ToLower() == emailDigitado.ToLower()
                                        select u).FirstOrDefault();

                if (usuarioExistente == null)
                {
                    MessageBox.Show("Não foi possível cadastrar. Este e-mail não corresponde a nenhum usuário cadastrado no sistema!", "Usuário Não Encontrado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                
                profissionaisAdapter.Insert(usuarioExistente.id_usuario, telefone);

              
                LimparElementos();
                AtualizarLista();

                MessageBox.Show("Perfil de Profissional vinculado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar profissional: " + ex.Message, "Erro");
            }
        }

        private void btnAtualizarUsuarios_Click(object sender, EventArgs e)
        {
            if (lboProfissional.SelectedItem == null) return;
            ProfissionaisRow profissional = lboProfissional.SelectedItem as ProfissionaisRow;
            if (profissional == null) return;

            // 1. Atualiza o dado da linha na memória (focado na tabela de Profissionais)
            profissional.telefone = txtTelefone.Text;

            try
            {
                ProfissionaisTableAdapter profissionais = new ProfissionaisTableAdapter();

                // 2. Passa o objeto do profissional INTEIRO para o Update salvar no banco
                profissionais.Update(profissional);

                // 3. Reseta a interface
                AtualizarLista();
                LimparElementos();

                MessageBox.Show("Profissional atualizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar o Profissional: " + ex.Message, "Erro");
            }
        }

        private void AtualizarLista()
        {
            lboProfissional.Items.Clear();
            ProfissionaisTableAdapter profissionaisDados = new ProfissionaisTableAdapter();
            var dados = from linha in profissionaisDados.GetData()
                        select linha;
            foreach (ProfissionaisRow dado in dados) lboProfissional.Items.Add(dado);

        }

        private void LimparElementos()
        {
            txtNome.Clear();
            txtEmail.Clear();
            txtPesquisa.Clear();
            txtTelefone.Clear();
            
        }

        private void lboProfissional_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lboProfissional.SelectedItem == null) return;
            ProfissionaisRow Profissionais = lboProfissional.SelectedItem as ProfissionaisRow;
            if (Profissionais == null) return;

            txtNome.Text = Profissionais.nome;
            txtEmail.Text = Profissionais.email;
            txtTelefone.Text = Profissionais.telefone;
            
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

            lboProfissional.ClearSelected();
            lboProfissional.Items.Clear();

            string textoDigitado = txtPesquisa.Text;

            // Instancia o adaptador de usuários do seu projeto
            ProfissionaisTableAdapter dados = new ProfissionaisTableAdapter();

            // Faz a busca usando LINQ (procura tanto no Nome quanto no Email)
            var profissionais = from linha in dados.GetData()
                           where linha.nome.ToLower().Contains(textoDigitado.ToLower())
                              || linha.email.ToLower().Contains(textoDigitado.ToLower())
                           select linha;

            // Adiciona os usuários filtrados na sua ListBox de usuários
            foreach (var profissional in profissionais)
            {
                lboProfissional.Items.Add(profissional);
            }
        }
    }
}
