using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.EntitiViewModel
{
    public class UserViewModel
    {
        [Required(ErrorMessage = "O nome do usuário é obrigatório", AllowEmptyStrings = false)]
        [Display(Name = "Login")]
        public string Login { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [StringLength(10, MinimumLength = 4)]
        [Display(Name = "Password")]
        public string Password { get; set; }

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
