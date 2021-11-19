using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAppHotel.Models
{
    [Table("Endereco")]
    public class Endereco
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Rua", Description = "Nome da Rua.")]
        [DisplayName("Rua")]
        [Required(ErrorMessage = "Obrigatório informar Rua.")]
        [RegularExpression(@"^[a-zA-Z''-'\s]{1,40}$", ErrorMessage =
           "Números e caracteres especiais não são permitidos no nome da rua.")]
        [Column("Rua")]
        public string rua { get; set; }

        [Display(Name = "Numero", Description = "Informe somente Números.")]
        [DisplayName("Número")]
        [Required(ErrorMessage = "Campo obrigatório.")]
        [Range(1, 99999)]
        public string numero { get; set; }

        [Required(ErrorMessage = "Campo obrigatório.")]
        [Display(Name = "Bairro")]
        public string bairro { get; set; }

        [Display(Name = "CEP", Description = "Informe somente Números.")]
        [DisplayName("CEP")]
        [Required(ErrorMessage = "Campo obrigatório.")]
        [Range(1, 99999)]
        public string cep { get; set; }

        [Display(Name = "Cidade", Description = "Nome da Cidade.")]
        [DisplayName("Cidade")]
        [Required(ErrorMessage = "Obrigatório informar Cidade.")]
        [RegularExpression(@"^[a-zA-Z''-'\s]{1,40}$", ErrorMessage =
          "Números e caracteres especiais não são permitidos no nome da Cidade.")]
        [Column("Cidade")]
        public string Cidade { get; set; }
        

        [Display(Name = "Estado", Description = "Nome da Estado.")]
        [DisplayName("Estado")]
        [Required(ErrorMessage = "Obrigatório informar Estado.")]
        [RegularExpression(@"^[a-zA-Z''-'\s]{1,40}$", ErrorMessage =
          "Números e caracteres especiais não são permitidos no nome da Estado.")]
        [Column("Estado")]
        public string estado { get; set; }
        

        [Display(Name = "Pais", Description = "Nome do País")]
        [DisplayName("Pais")]
        [Required(ErrorMessage = "Obrigatório informar País.")]
        [RegularExpression(@"^[a-zA-Z''-'\s]{1,40}$", ErrorMessage =
       "Números e caracteres especiais não são permitidos no nome da País.")]
        [Column("Estado")]
        public string pais { get; set; }
        

        public Endereco endereco { get; set; }

                     
    }
}
