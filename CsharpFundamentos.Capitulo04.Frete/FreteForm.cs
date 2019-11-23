using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CsharpFundamentos.Capitulo04.Frete
{
    public partial class freteForm1 : Form
    {
        public freteForm1()
        {
            InitializeComponent();
        }

        private void calcularbutton_Click(object sender, EventArgs e)
        {
            if (ValidarFormulario())
            {
                Calcular();
            }
        }

        private void Calcular()
        {
            
        }

        private bool ValidarFormulario()
        {
            var validacao = true;


            return validacao;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ufComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
