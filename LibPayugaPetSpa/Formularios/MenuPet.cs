using LibPayugaPetSpa.Classes;
using System;
using System.Collections;
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
    public partial class MenuPet : Form
    {
        private int _idSelecionado;
        public MenuPet()
        {
            InitializeComponent();
            //Carregar dados para o DataGridView:
            dgvPet.DataSource = Banco.PetDAO.ListarTudo();
            // Salvar o resultado da listagem de categorias em um objeto:
            var r = Banco.TipoDAO.ListarTudo();
            ArrayList rows = new ArrayList();
            // Converter esse objeto para array:
            foreach (DataRow dataRow in r.Rows)
            {
                rows.Add(string.Join(" - ", dataRow.ItemArray.Select(item => item.ToString())));
            }
            // Salvar o resultado da listagem de categorias em um objeto:
            var z = Banco.ClienteDAO.ListarPorNome();
            ArrayList row = new ArrayList();
            // Converter esse objeto para array:
            foreach (DataRow dataRow in z.Rows)
            {
                row.Add(string.Join(" - ", dataRow.ItemArray.Select(item => item.ToString())));
            }
            // Atribuir os valores nos cmbs:
            cmbPetCad.DataSource = rows;
            cmbPetEdit.DataSource = rows.Clone();
            // Atribuir os valores nos cmbs:
            cmbDonoCad.DataSource = row;
            cmbDonoEdit.DataSource = row.Clone();
            // Atribuir a tabela de produtos no dgv:
            dgvPet.DataSource = Banco.PetDAO.ListarTudo();
        }
        // Atualizar
        private void AtualizarDgv()
        {
            dgvPet.DataSource = Banco.PetDAO.ListarTudo();
        }
        // Obter o Id do Combo Box
        private int obterIDdaString(string texto)
        {
            return int.Parse(texto.Split(' ')[0]);
        }
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            var p = new Pet();
            var valida = txtNomeCad.Text.Length > 2;
            if (valida)
            {
                p.Nome = txtNomeCad.Text;
                p.IdTipo = obterIDdaString(cmbPetCad.Text);
                p.IdCliente = obterIDdaString(cmbDonoCad.Text);


                //Chamar Cadastrar:
                if (Banco.PetDAO.Cadastrar(p))
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
        private void dgvPet_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Mostrar o groupbox de editar:
            grbEditarApagar.Enabled = true;
            // Descobrir o numero da linha da celula clicada:
            int numeroLinha = dgvPet.CurrentCell.RowIndex;
            // Guardar toda a linha em um objeto DataRow:
            var linha = dgvPet.Rows[numeroLinha];
            // MessageBox.Show(linha.Cells[1].Value.ToString());

            // Atribuir os valores das células aos txb ao editar:
            txtNomeEdit.Text = linha.Cells[1].Value.ToString();
            _idSelecionado = int.Parse(linha.Cells[0].Value.ToString());
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            // Confirmar remoção:
            var r = MessageBox.Show("Deseja realmente apagar?",
                "ATENÇÃO!", MessageBoxButtons.YesNo);
            if (r == DialogResult.Yes)
            {
                Banco.PetDAO.ApagarPorID(_idSelecionado);
                MessageBox.Show("Pet apagado com sucesso!!");
            }
            // Limpar o lblApagar
            txtNomeEdit.Clear();
            //Desabilitar o Editar
            grbEditarApagar.Enabled = false;
            // Atualizar o DGV
            AtualizarDgv();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            var p = new Pet();
            p.Nome = txtNomeEdit.Text;
            p.IdTipo = obterIDdaString(cmbPetEdit.Text);
            p.IdCliente = obterIDdaString(cmbDonoEdit.Text);
            p.Id = _idSelecionado;


            // Chamar a Modificar:
            if (Banco.PetDAO.Modificar(p))
            {
                MessageBox.Show("Usuário modificado com sucesso");
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
    }
}
