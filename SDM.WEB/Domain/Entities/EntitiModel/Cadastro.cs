using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.EntitiModel
{
    public class Cadastro : BaseEntity.BaseEntity
    {
        public string DataCadastro { get; set; }
        public string NumeroCadastrado { get; set; }
        public string DatadeNascimento { get; set; }
        public string Escolaridade { get; set; }
        public string Cidade { get; set; }

        public string BO { get; set; }
        public string MP { get; set; }

        public string Bairro { get; set; }
        public string EstadoCivil { get; set; }
        public string Filhos { get; set; }
        public string TipodeViolência { get; set; }
        public string UsoDeAlcool_Drogas_Vitima { get; set; }
        public string UsoDeAlcool_Drogas_Agressor { get; set; }
        public string VínculoComAgressor { get; set; }
        public string EncaminhadaPor { get; set; } //:	B.O.	M.P.	
        public string Situacao { get; set; }
        public string Motivododesligamento { get; set; }
        public string Desligamento { get; set; }
        public string Observacoes { get; set; }
    }
}
