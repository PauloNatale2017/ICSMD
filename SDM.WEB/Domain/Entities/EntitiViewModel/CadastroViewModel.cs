using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.EntitiViewModel
{
    public class CadastroViewModel : BaseEntity.BaseEntity
    {

        [Required(ErrorMessage = "O Numero Sequencial Cadastrado", AllowEmptyStrings = false)]
        [Display(Name = "Numero Sequencial Cadastrado")]
        public int NumeroCadastrado { get; set; }
        
        [Display(Name = "Idade", Description = "A idade deve estar entre 0 e 105 anos.")]
        [Range(0,105)]
        public DateTime DatadeNascimento { get; set; }

        [Required(ErrorMessage = "Grau de escolaridade obrigatório", AllowEmptyStrings = false)]
        [Display(Name = "Escolaridade")]
        public string Escolaridade { get; set; }

        [Required(ErrorMessage = "Cidade onde reside é obrigatório", AllowEmptyStrings = false)]
        [Display(Name = "Cidade")]
        public string Cidade { get; set; }

        [Required(ErrorMessage = "Bairro onde reside é obrigatório", AllowEmptyStrings = false)]
        [Display(Name = "Bairro")]
        public string Bairro { get; set; }

        [Required(ErrorMessage = "O Estado Civil é obrigatório", AllowEmptyStrings = false)]
        [Display(Name = "EstadoCivil")]
        public string EstadoCivil { get; set; }

        [Required(ErrorMessage = "Informar o numero de filho(a) é obrigatório", AllowEmptyStrings = false)]
        [Display(Name = "Filhos")]
        public string Filhos { get; set; }

        [Required(ErrorMessage = "O tipo de violencia  é obrigatório", AllowEmptyStrings = false)]
        [Display(Name = "Tipo de Violencia")]
        public string TipodeViolência { get; set; }

        [Required(ErrorMessage = "Informar se a Vitima faz utilização de alcool ou Drogas é obrigatório", AllowEmptyStrings = false)]
        [Display(Name = "Use de Alcool ou Drogas Vitima")]
        public string UsoDeAlcool_Drogas_Vitima { get; set; }

        [Required(ErrorMessage = "Informar se a Agressor faz utilização de alcool ou Drogas é obrigatório", AllowEmptyStrings = false)]
        [Display(Name = "Use de Alcool ou Drogas Agressor")]
        public string UsoDeAlcool_Drogas_Agressor { get; set; }

        [Required(ErrorMessage = "Informar grau de Vinculo com o agressor é obrigatório", AllowEmptyStrings = false)]
        [Display(Name = "Vinculo com o Agressor")]
        public string VínculoComAgressor { get; set; }

        [Required(ErrorMessage = "Informar o meio por onde via a informação é obrigatório", AllowEmptyStrings = false)]
        [Display(Name = "Encaminhada Por")]
        public string EncaminhadaPor { get; set; } //:	B.O.	M.P.	

        [Required(ErrorMessage = "Informar a situação é obrigatório", AllowEmptyStrings = false)]
        [Display(Name = "Situação")]
        public string Situacao { get; set; }

        [Required(ErrorMessage = "Motivo da desistencia do processo é obrigatório", AllowEmptyStrings = false)]
        [Display(Name = "Motivo de Desligamento")]
        public string Motivododesligamento { get; set; }

        [Required(ErrorMessage = "Desligamento é obrigatório", AllowEmptyStrings = false)]
        [Display(Name = "Desligamento")]
        public string Desligamento { get; set; }

        [Required(ErrorMessage = "Campo Observações é obrigatório", AllowEmptyStrings = false)]
        [Display(Name = "Observações")]
        public string Observacoes { get; set; }    

        //[Required]
        //[DataType(DataType.Password)]
        //[StringLength(10, MinimumLength = 4)]
        //[Display(Name = "Password")]
        //public string Password { get; set; }

        ////Id
        //[Display(Name = "Código", Description = "Informe um inteiro entre 1 e 99999.")]
        //[Range(1, 99999)]
        //public int Id { get; set; }

        ////Nome
        //[Display(Name = "Nome Completo", Description = "Nome e Sobrenome.")]
        //[Required(ErrorMessage = "O nome completo é obrigatório.")]
        //[RegularExpression(@"^[a-zA-Z''-'\s]{1,40}$", ErrorMessage =
        //    "Números e caracteres especiais não são permitidos no nome.")]
        //public string Nome { get; set; }

        ////Email
        //[Required(ErrorMessage = "O Email é obrigatório.")]
        //[StringLength(100, MinimumLength = 5, ErrorMessage =
        //    "O Email deve ter no mínimo 5 e no máximo 100 caracteres.")]
        //public string Email { get; set; }

        ////Idade
        //[Display(Name = "Idade", Description = "A idade deve estar entre 15 e 24 anos.")]
        //[Range(15, 24)]
        //public int Idade { get; set; }

    }
}
