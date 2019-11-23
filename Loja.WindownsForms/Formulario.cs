using System;
using System.Windows.Forms;

namespace Loja.WindownsForms
{
    internal class Formulario
    {
        internal static bool Validar(Form Formulario, ErrorProvider provedorErro)
        {
            var validacao = true;

            foreach (Control controle in Formulario.Controls)
            {
                if (controle.Tag == null)
                {
                    continue;
                }

                if (controle.Tag.ToString().Contains("*") && controle.Text == string.Empty)
                {
                    provedorErro.SetError(controle, "Campo obrigatório.");
                    validacao = false;
                }
            }

            return validacao;
        }
    }
}