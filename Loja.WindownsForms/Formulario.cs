using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Loja.WindownsForms
{
    internal static class Formulario
    {
        internal static bool Validar(Form Formulario, ErrorProvider provedorErro)
        {
            var validacao = true;
            provedorErro.Clear();


            foreach (Control controle in Formulario.Controls)
            {
                if (controle.Tag == null)
                {
                    continue;
                }


                if (controle.Tag.ToString().Contains("*") && controle.Text == string.Empty)
                {
                    validacao = DefinirErro(provedorErro, controle, "Campo obrigatório.");
                }
                else
                {
                    validacao = ValidarTipoDado(controle, provedorErro);
                }
            }

            return validacao;
        }

        private static bool DefinirErro(ErrorProvider provedorErro, Control controle, string mensagem)
        {
            provedorErro.SetError(controle, mensagem);
            controle.Focus();
            return false;
        }

        private static bool ValidarTipoDado(Control controle, ErrorProvider provedorErro)
        {
            var validacao = true;
            var controleTag = controle.Tag.ToString().ToUpper();

            if (controleTag.Contains("PLACA"))
            {
                if (!Regex.IsMatch(controle.Text, @"^[A-Z]{3}[0-9]{4}$"))
                {
                    validacao = DefinirErro(provedorErro, controle, "Digite a placa no formato AAA-0000");
                }
            }
            else if (controleTag.Contains("ANO"))
            {
                if (!Regex.IsMatch(controle.Text, @"[0-9]{4}")) // ou \d para numeros tbm regular expresion
                {
                    validacao = DefinirErro(provedorErro, controle, "Digite o ano no formato 0000");
                }
            }
            return validacao;
        }

        //internal static void Limpar(Form formulario)
        //{
        //    foreach (Control controle in formulario.Controls)
        //    {
        //        if (controle is TextBox || controle is MaskedTextBox)
        //        {
        //            controle.Text = string.Empty;
        //        }
        //        else if (controle is ComboBox)
        //        {
        //            ((ComboBox)controle).SelectedIndex = -1;
        //        }
        //    }
        //}

        public static void Limpar(Control controle)
        {
            foreach (Control controleFor in controle.Controls)
            {
                if (controleFor is TextBox || controleFor is MaskedTextBox || controleFor is ComboBox)
                {
                    controleFor.ResetText();
                }

                Limpar(controleFor);
            }
        }

    }
}