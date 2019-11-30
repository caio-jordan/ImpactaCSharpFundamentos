using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oficina.Dominio
{
    //ToDo: OO - herança (:).
   public class VeiculoPasseio : Veiculo

        //Todo: OO polimorfismo por sobrescrita(override)
    {
        public Carroceria Carroceria { get; set; }

        public override List<string> Validar()
        {
            var erros = ValidarBase();

            if (!Enum.IsDefined(typeof(Carroceria), Carroceria))
            {
                erros.Add($"A Carroceria Informada ({Carroceria}) não é válida");
            }

            return erros;
        }
    }
}
