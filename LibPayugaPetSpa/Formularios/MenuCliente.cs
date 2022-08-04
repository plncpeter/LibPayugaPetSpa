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
    public partial class MenuCliente : Form
    {
        private int _idSelecionado;
        public MenuCliente()
        {
            InitializeComponent();
            //Carregar dados para o DataGridView:
            dgvClientes.DataSource = Banco.ClienteDAO.ListarTudo();
        }
        // Atualizar
        private void AtualizarDgv()
        {
            dgvClientes.DataSource = Banco.ClienteDAO.ListarTudo();
        }
 
        private void MenuCliente_Load(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            var c = new Cliente();
            var valida = txtNomeCad.Text.Length > 2
                && txtTelefoneCad.Text.Length > 0 && txtTelefoneCad.Text.Length <= 15;
            if (valida)
            {
                c.Nome = txtNomeCad.Text;
                c.Telefone = txtTelefoneCad.Text;

                //Chamar Cadastrar:
                if (Banco.ClienteDAO.Cadastrar(c))
                {
                    MessageBox.Show("Cadastrado com Sucesso!!");
                    //Limpar os Campos:
                    txtNomeCad.Clear();
                    txtTelefoneCad.Clear();
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

        private void btnApagar_Click(object sender, EventArgs e)
        {
            // Confirmar remoção:
            var r = MessageBox.Show("Deseja realmente apagar?",
                "ATENÇÃO!", MessageBoxButtons.YesNo);
            if (r == DialogResult.Yes)
            {
                Banco.ClienteDAO.ApagarPorID(_idSelecionado);
                MessageBox.Show("Cliente apagado com sucesso!!");
            }
            // Limpar o lblApagar
            txtNomeEdit.Clear();
            txtTelefoneEdit.Clear();
            //Desabilitar o Editar
            grbEditarApagar.Enabled = false;
            // Atualizar o DGV
            AtualizarDgv();
        }

        private void dgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Mostrar o groupbox de editar:
            grbEditarApagar.Enabled = true;
            // Descobrir o numero da linha da celula clicada:
            int numeroLinha = dgvClientes.CurrentCell.RowIndex;
            // Guardar toda a linha em um objeto DataRow:
            var linha = dgvClientes.Rows[numeroLinha];
            // MessageBox.Show(linha.Cells[1].Value.ToString());

            // Atribuir os valores das células aos txb ao editar:
            txtNomeEdit.Text = linha.Cells[1].Value.ToString();
            txtTelefoneEdit.Text = linha.Cells[2].Value.ToString();
            _idSelecionado = int.Parse(linha.Cells[0].Value.ToString());
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            var c = new Cliente();
            c.Nome = txtNomeEdit.Text;
            c.Telefone = txtTelefoneEdit.Text;
            c.Id = _idSelecionado;


            // Chamar a Modificar:
            if (Banco.ClienteDAO.Modificar(c))
            {
                MessageBox.Show("Usuário modificado com sucesso");
                // Limpar os campos:
                txtNomeEdit.Clear();
                txtTelefoneEdit.Clear();
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

        private void btnMenuPet_Click(object sender, EventArgs e)
        {
        }
    }
}
