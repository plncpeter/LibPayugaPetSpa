using LibPayugaPetSpa.Formularios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibPayugaPetSpa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            var menucliente = new MenuCliente();
            menucliente.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnServicos_Click(object sender, EventArgs e)
        {
            var menuservicos = new MenuServicos();
            menuservicos.ShowDialog();
        }

        private void btnPetsCad_Click(object sender, EventArgs e)
        {
            var menupets = new MenuPet();
            menupets.ShowDialog();
        }

        private void btnMenuTipo_Click(object sender, EventArgs e)
        {
            var menutipo = new MenuTipo();
            menutipo.ShowDialog();
        }

        private void btnComanda_Click(object sender, EventArgs e)
        {
            var menucomanda = new MenuComanda();
            menucomanda.ShowDialog();
        }

        private void btnCaixa_Click(object sender, EventArgs e)
        {
            var menucaixa = new MenuCaixa();
            menucaixa.ShowDialog();
        }
    }
}
