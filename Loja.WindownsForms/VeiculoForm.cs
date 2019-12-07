using Oficina.Dominio;
using Oficina.Repositorios.SistemasArquivos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
            try
            {
                if (Formulario.Validar(this, veiculoErrorProvider))
                {
                    GravarVeiculo();
                    MessageBox.Show("Veículo gravado com sucesso!");
                    Formulario.Limpar(this);
                    placaMaskedTextBox.Focus();
                }
            }
            catch (FileNotFoundException excecao)
            {
                MessageBox.Show($"O arquivo {excecao.FileName} não foi encontrado.");
            }

            catch (UnauthorizedAccessException)
            {
                MessageBox.Show("O arquivo Veiculo.xml está com o atributo Somente Leitura.");
            }
            catch (Exception)
            {
                MessageBox.Show("Eita! Algo deu errado e em breve teremos uma solução. ");
                //Logar(ex) - LOG4NET para implementar  ; um metodo para registrar o erro

                throw;
            }
            finally
            {
                // É executado sempre! Mesmo qeu haja algum return no código. Independente de erro

            }
        }

        private void GravarVeiculo()
        {
                var veiculo = new VeiculoPasseio();

                veiculo.Ano = Convert.ToInt32(anoMaskedTextBox.Text);
                veiculo.Cambio = (Cambio)cambioComboBox.SelectedItem;
                veiculo.Carroceria = Carroceria.Hatch;
                veiculo.Combustivel = (Combustivel)combustivelComboBox.SelectedItem;
                veiculo.Cor = (Cor)corComboBox.SelectedItem;
                veiculo.Observacao = observacaoTextBox.Text;
                veiculo.Placa = placaMaskedTextBox.Text;

                new VeiculoRepositorio().Inserir(veiculo);

        }        
        private void limparButton_Click(object sender, EventArgs e)
        {
            Formulario.Limpar(this);
        }
    }
}
