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
    public partial class MenuCaixa : Form
    {
        public MenuCaixa()
        {
            InitializeComponent();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtPet.Text, out int numComanda))
            {
                // Se a conversão der certo:
                var r = Banco.OrdemDAO.BuscarFicha(numComanda);
                // Verificar se tem ficha de lançamento
                if (r.Rows.Count > 0)
                {
                    // Popular o DGV com as infos:
                    dgvComanda.DataSource = r;
                    var totalComanda = r.Compute("SUM(Valor)", string.Empty);
                    lblValor.Text = "R$ " + totalComanda.ToString();
                }
                else
                {
                    MessageBox.Show("N existe lanç p comanda");
                }

            }
            else
            {
                // Se der errado:
                MessageBox.Show("Informe um valor válido");
            }
        }
        private void chbPagamentos_CheckedChanged_1(object sender, EventArgs e)
        {
            btnEncerrar.Enabled = chbPagamentos.Checked;
        }

        private void btnEncerrar_Click_1(object sender, EventArgs e)
        {
            if (Banco.OrdemDAO.Encerrar(int.Parse(txtPet.Text)))
            {
                MessageBox.Show("Comanda encerrada com sucesso!");
                txtPet.Clear();
                dgvComanda.DataSource = null;
                chbPagamentos.Checked = false;
                btnEncerrar.Enabled = false;
                lblValor.Text = "";
            }
            else
            {
                MessageBox.Show("Houve um erro!");
            }
        }
    }
}
