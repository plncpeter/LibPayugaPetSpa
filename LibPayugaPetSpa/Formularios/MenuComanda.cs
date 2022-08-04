using LibPayugaPetSpa.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibPayugaPetSpa.Formularios
{
    public partial class MenuComanda : Form
    {
        public MenuComanda()
        {
            InitializeComponent();
            AtualizarDgv();
        }
        // Atualizar o DGV:
        private void AtualizarDgv()
        {
            dgvServicos.DataSource = Banco.ServicosDAO.ListarTudo();
            dgvPet.DataSource = Banco.PetDAO.ListarTudo();
        }
        private void btnContinuar_Click(object sender, EventArgs e)
        {
            // Verificar se os campos estão vazios:
            if (txtPetCont.Text.Length > 0 && txtServicoCont.Text.Length > 0)
            {
                int idServico = int.Parse(txtServicoCont.Text);
                // Buscar o nome do produto:
                var r = Banco.ServicosDAO.BuscarNomePorID(idServico);
                txtServicoLanc.Text = r.Rows[0]["nome"].ToString();

                // Desativar o grbLançamento:
                grbInformacoes.Enabled = false;
                // Ativar o grbInfos:
                grbLanc.Enabled = true;
            }
            else
            {
                MessageBox.Show("Os campos não podem estar vazios!");
            }
        }

        private void dgvServicos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Descobrir o número da linha da célula clicada:
            int numeroLinha = dgvServicos.CurrentCell.RowIndex;
            // Guardar toda a linha em um objeto DataRow:
            var linha = dgvServicos.Rows[numeroLinha];


            txtServicoCont.Text = linha.Cells[0].Value.ToString();
        }

        private void btnLancar_Click(object sender, EventArgs e)
        {
            var lancamento = new Ordem();
            // Variaveis p/ receber os valores dos campos:
            lancamento.IdPet = int.Parse(txtPetCont.Text);
            lancamento.IdServicos = int.Parse(txtServicoCont.Text);


            // Chamar o método do DAO e enviar o objeto lançamento
            if (Banco.OrdemDAO.Lancar(lancamento))
            {
                MessageBox.Show("Serviço atribuido ao pet.");
            }
            else
            {
                MessageBox.Show("Houve um erro ao atribuir ao pet");
            }
            // Ativar/Desativar grb's:
            grbInformacoes.Enabled = true;
            grbLanc.Enabled = false;
            //Limpar campos:
            txtPetCont.Clear();
            txtServicoCont.Clear();
            txtServicoLanc.Clear();
        }

        private void dgvPet_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Descobrir o número da linha da célula clicada:
            int numeroLinha = dgvPet.CurrentCell.RowIndex;
            // Guardar toda a linha em um objeto DataRow:
            var linha = dgvPet.Rows[numeroLinha];


            txtPetCont.Text = linha.Cells[0].Value.ToString();
        }
    }
}
