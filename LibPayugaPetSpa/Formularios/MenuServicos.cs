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
    public partial class MenuServicos : Form
    {
        private int _idSelecionado;
        // Atualizar
        private void AtualizarDgv()
        {
            dgvServico.DataSource = Banco.ServicosDAO.ListarTudo();
        }
        public MenuServicos()
        {
            InitializeComponent();
            // Atribuir a tabela de produtos no dgv:
            dgvServico.DataSource = Banco.ServicosDAO.ListarTudo();

        }

        private void btnMenuPet_Click(object sender, EventArgs e)
        {

        }

        private void lblCadastro1_Click(object sender, EventArgs e)
        {

        }
        // Cadastrar um Serviço
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            var s = new Servicos();
            var valida = txtNomeCad.Text.Length > 2
                && double.Parse(txtPrecoCad.Text) > 0;
            if (valida)
            {
                s.Nome = txtNomeCad.Text;
                s.Preco = double.Parse(txtPrecoCad.Text);


                //Chamar Cadastrar:
                if (Banco.ServicosDAO.Cadastrar(s))
                {
                    MessageBox.Show("Cadastrado com Sucesso!!");
                    //Limpar os Campos:
                    txtNomeCad.Clear();
                    txtPrecoCad.Clear();
                    //Atualizar o dgv:
                    AtualizarDgv();
                }
                else
                {
                    MessageBox.Show("Houve um erro no cadastro!");
                }

            }
            else
            {
                MessageBox.Show("Verifique as informações digitadas");
            }
        }
        // Editar Serviços
        private void btnEditar_Click(object sender, EventArgs e)
        {
            var s = new Servicos();
            s.Nome = txtNomeEdit.Text;
            s.Preco = double.Parse(txtPrecoEdit.Text);
            s.Id = _idSelecionado;


            // Chamar a Modificar:
            if (Banco.ServicosDAO.Modificar(s))
            {
                MessageBox.Show("Serviço modificado com sucesso");
                // Limpar os campos:
                txtNomeEdit.Clear();
                txtPrecoEdit.Clear();
                // Atualizar o dgv:
                AtualizarDgv();
                // Esconder o grb de editar:
                grbEditarApagar.Enabled = false;
            }
            else
            {
                MessageBox.Show("Verique as informações inseridas.");
            }
        }

        private void dgvServico_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Mostrar o groupbox de editar:
            grbEditarApagar.Enabled = true;
            // Descobrir o numero da linha da celula clicada:
            int numeroLinha = dgvServico.CurrentCell.RowIndex;
            // Guardar toda a linha em um objeto DataRow:
            var linha = dgvServico.Rows[numeroLinha];
            // MessageBox.Show(linha.Cells[1].Value.ToString());

            // Atribuir os valores das células aos txb ao editar:
            txtNomeEdit.Text = linha.Cells[1].Value.ToString();
            txtPrecoEdit.Text = linha.Cells[2].Value.ToString();
            _idSelecionado = int.Parse(linha.Cells[0].Value.ToString());
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            // Confirmar remoção:
            var r = MessageBox.Show("Deseja realmente apagar?",
                "ATENÇÃO!", MessageBoxButtons.YesNo);
            if (r == DialogResult.Yes)
            {
                Banco.ServicosDAO.ApagarPorID(_idSelecionado);
                MessageBox.Show("Serviço apagado com sucesso!!");
            }
            // Limpar o lblApagar
            txtNomeEdit.Clear();
            txtPrecoEdit.Clear();
            //Desabilitar o Editar
            grbEditarApagar.Enabled = false;
            // Atualizar o DGV
            AtualizarDgv();
        }
    }
}
