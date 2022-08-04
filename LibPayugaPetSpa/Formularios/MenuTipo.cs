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
    public partial class MenuTipo : Form
    {
        private int _idSelecionado;
        // Atualizar
        private void AtualizarDgv()
        {
            dgvTipo.DataSource = Banco.TipoDAO.ListarTudo();
        }
        public MenuTipo()
        {
            InitializeComponent();
            // Atribuir a tabela de produtos no dgv:
            dgvTipo.DataSource = Banco.TipoDAO.ListarTudo();

        }

        private void MenuTipo_Load(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            var t = new Tipo();
            var valida = txtNomeCad.Text.Length > 2;
            if (valida)
            {
                t.Nome = txtNomeCad.Text;


                //Chamar Cadastrar:
                if (Banco.TipoDAO.Cadastrar(t))
                {
                    MessageBox.Show("Cadastrado com Sucesso!!");
                    //Limpar os Campos:
                    txtNomeCad.Clear();
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

        private void btnEditar_Click(object sender, EventArgs e)
        {
            var t = new Tipo();
            t.Nome = txtNomeEdit.Text;
            t.Id = _idSelecionado;


            // Chamar a Modificar:
            if (Banco.TipoDAO.Modificar(t))
            {
                MessageBox.Show("Tipo modificado com sucesso");
                // Limpar os campos:
                txtNomeEdit.Clear();
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

        private void dgvTipo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Mostrar o groupbox de editar:
            grbEditarApagar.Enabled = true;
            // Descobrir o numero da linha da celula clicada:
            int numeroLinha = dgvTipo.CurrentCell.RowIndex;
            // Guardar toda a linha em um objeto DataRow:
            var linha = dgvTipo.Rows[numeroLinha];
            // MessageBox.Show(linha.Cells[1].Value.ToString());

            // Atribuir os valores das células aos txb ao editar:
            txtNomeEdit.Text = linha.Cells[1].Value.ToString();
            _idSelecionado = int.Parse(linha.Cells[0].Value.ToString());
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            // Confirmar remoção:
            var t = MessageBox.Show("Deseja realmente apagar?",
                "ATENÇÃO!", MessageBoxButtons.YesNo);
            if (t == DialogResult.Yes)
            {
                Banco.TipoDAO.ApagarPorID(_idSelecionado);
                MessageBox.Show("Tipo apagado com sucesso!!");
            }
            // Limpar o lblApagar
            txtNomeEdit.Clear();
            //Desabilitar o Editar
            grbEditarApagar.Enabled = false;
            // Atualizar o DGV
            AtualizarDgv();
        }
    }
}
