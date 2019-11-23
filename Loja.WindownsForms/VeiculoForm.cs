using Oficina.Dominio;
using Oficina.Repositorios.SistemasArquivos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loja.WindownsForms
{
    public partial class VeiculoForm : Form
    {
        // construtor - método com o mesmo nome da classe;
        // Executado automaticamente(new).
        public VeiculoForm()
        {
            InitializeComponent();

            PopularControles();
        }

        private void PopularControles()
        {
            marcaComboBox.DataSource = new MarcaRepositorio().Obter();
            marcaComboBox.DisplayMember = "Nome";
            marcaComboBox.ValueMember = "Id";
            marcaComboBox.SelectedIndex = -1;

            corComboBox.DataSource = new CorRepositorio().Obter();
            corComboBox.DisplayMember = "Nome";
            corComboBox.ValueMember = "Id";
            corComboBox.SelectedIndex = -1;

            cambioComboBox.DataSource = Enum.GetValues(typeof(Cambio));
            cambioComboBox.SelectedIndex = -1;

            combustivelComboBox.DataSource = Enum.GetValues(typeof(Combustivel));
            combustivelComboBox.SelectedIndex = -1;

        }

        private void VeiculoForm_Load(object sender, EventArgs e)
        {

        }

        private void marcaComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (marcaComboBox.SelectedIndex ==  -1)

            {
                return;
            }
            var marca = (Marca) marcaComboBox.SelectedItem;

            modeloComboBox.DataSource = new ModeloRepositorio().ObterPorMarca(marca.Id);
            modeloComboBox.DisplayMember = "Nome";
            modeloComboBox.ValueMember = "Id";
            modeloComboBox.SelectedIndex = -1;

        }

        private void gravarButton_Click(object sender, EventArgs e)
        {
            if (Formulario.Validar(this,veiculoErrorProvider))
            {
                GravarVeiculo();
            }
        }

        private void GravarVeiculo()
        {

        }
    }
}
