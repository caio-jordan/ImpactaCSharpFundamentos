using System;
using System.Collections.Generic;

namespace Oficina.Dominio
{
    //ToDo: OO - classe ou abstração
    public abstract class Veiculo
    {
        //ToDo: OO - encapsulamento 
        private string  placa;
        public string Placa
        {
            get { return placa.ToUpper(); }
            set { placa = value.ToUpper(); }
        }
        public int Ano { get; set; }
        public Cor Cor { get; set; }
        public string Observacao { get; set; }
        public Modelo Modelo { get; set; }
        public Cambio Cambio { get; set; }
        public Combustivel Combustivel { get; set; }

        public abstract List<string> Validar();

        //Protected acessível apenas para as derivadas (Filhos)
        protected List<string> ValidarBase()
        {
            var erros = new List<string>();

            if (Ano < 1980 || (Ano - DateTime.Now.Year) > 1)
            {
                erros.Add($"O ano informado ({Ano}) não é válido.");
            }
            return erros;
        }
    }
}
