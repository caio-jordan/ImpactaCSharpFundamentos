using System;
using System.Windows.Forms;

namespace CSharpFundamentos.Capitulo03.Variaveis
{
    public partial class VariaveisForm : Form
    {
        int x = 32; // fildes campo ou atributo é o nome para variavel dentro da classe
        int y = 16;
        int w = 45;
        int z = 32;

        public VariaveisForm()
        {
            InitializeComponent();
        }

        private void operaçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void VariaveisForm_Load(object sender, EventArgs e)
        {

        }

        private void aritmeticasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            resultadoListBox.Items.Clear();

            int x = 42;
            int i = 0;
            string nome = "Jordan";
            char letra = 'a';
            DateTime dataNascimento = new DateTime(1998, 03, 18);
            bool aprovado = true;
            aprovado = false;

            var a = 2;
            int b = 6;
            var c = 10;
            var d = 13;

            decimal valor = 7.8m;
            decimal bimestre1 = 8.5m;
            int numero = 11, outroNumero = 12, esseNumero = 13;
            var @class = "3D";


            //if (j == 5)
            //{

            //}

            resultadoListBox.Items.Add("a = " + a /*.ToString()*/);
            resultadoListBox.Items.Add(string.Concat("b = ", b, ",c=", c));
            resultadoListBox.Items.Add(string.Format("c = {0}, d = {1}", c, d));
            resultadoListBox.Items.Add($"d = {nome} ");

            resultadoListBox.Items.Add($"c * d = {c * d} ");
            resultadoListBox.Items.Add($"d / d = {d / a} ");
            resultadoListBox.Items.Add($"d % a = {d % a} "); // string interpolada
            //resultadoListBox.Items.Add($"d % a = {d % a} "); //Mod







        }

        private void reduzidasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            resultadoListBox.Items.Clear();
            int x = 5;
            resultadoListBox.Items.Add("x = " + x);

            //x = x - 3;
            x -= 3;
            resultadoListBox.Items.Add("x = " + x);
        }

        private void incrementaisDecrementaisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            resultadoListBox.Items.Clear();
            int a;

            a = 5;
            resultadoListBox.Items.Add("Exemplo de pré-incremental");
            resultadoListBox.Items.Add("a = " + a);
            resultadoListBox.Items.Add($"2 + ++a = {2 + ++a} " );
            resultadoListBox.Items.Add("a = " + a);

            a = 5;
            resultadoListBox.Items.Add("Exemplo de pós-incremental");
            resultadoListBox.Items.Add("a = " + a);
            resultadoListBox.Items.Add($"2 + a++ = {2 + a++} ");
            resultadoListBox.Items.Add("a = " + a);
        }

        private void booleanasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExiberValores();
            resultadoListBox.Items.Add($"w <= x = {w <= x}");
            resultadoListBox.Items.Add($"x == z = {x == z}");  //um sinal de "=" atribuição, dois 
            resultadoListBox.Items.Add($"x != z = {x != z}");  //um sinal de "=" atribuição, dois
        }

        private void ExiberValores()
        {
            resultadoListBox.Items.Add("x = " + x);
            resultadoListBox.Items.Add("y = " + y);
            resultadoListBox.Items.Add("w = " + w);
            resultadoListBox.Items.Add("z = " + z);
            resultadoListBox.Items.Add(new string ('-',50)); // shift + ctrl + espaço (saber o que colocar dentro de new string)
        }

        private void logicasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            resultadoListBox.Items.Clear();

            ExiberValores();

            resultadoListBox.Items.Add($"w <= x || y == 16 = {w <= x || y == 16}");
            resultadoListBox.Items.Add($"x == z && x != z = {x == z && x != z}");
            resultadoListBox.Items.Add($"!(y > w) = {!(y > w)}");



        }

        private void terminariasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int ano;

            ano = 2014;

            resultadoListBox.Items
                .Add($"O ano {ano} é bissexto? {(ano % 4 == 0 ? "Sim" : "Não")}.");

            ano = 2016;

            resultadoListBox.Items
                .Add($"O ano {ano} é bissexto? {(DateTime.IsLeapYear (ano) ? "Sim" : "Não")}.");

            //var resposta = "";

            //if (ano % 4 == 0)
            //{
            //    resposta = "Sim";
            //}
            //else
            //{
            //    resposta = "Não";
            //}
        }
    }
}
