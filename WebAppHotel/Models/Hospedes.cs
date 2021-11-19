using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAppHotel.Models
{
    [Table("Hospedes")]
    public class Hospedes
    {
        [Key]
        [Column("Id")]
        public int Id { get; set; }

        [Display(Name = "Nome ", Description = "Nome do Hóspede.")]
        [DisplayName("Nome")]
        [Required(ErrorMessage = "O nome é obrigatório.")]
        [RegularExpression(@"^[a-zA-Z''-'\s]{1,40}$", ErrorMessage =
           "Números e caracteres especiais não são permitidos no nome.")]        
        [Column("Nome")]
        public string Nome { get; set; }

        [Display(Name = "Sobrenome ", Description = "Sobrenome do Hóspede.")]
        [DisplayName("Sobrenome")]
        [Required(ErrorMessage = "O Sobrenome é obrigatório.")]
        [RegularExpression(@"^[a-zA-Z''-'\s]{1,40}$", ErrorMessage =
           "Números e caracteres especiais não são permitidos no Sobrenome.")]
        [Column("Sobrenome")]
        public string Sobrenome { get; set; }

        [Display(Name = "WhatsApp", Description = "Informe somente Números.")]
        [DisplayName("WhatsApp")]
        [Range(1, 99999999999999)]
        [Column("WhatsApp")]
        public string WhatsApp { get; set; }

        [Required(ErrorMessage = "Informe o seu email")]
        [RegularExpression(".+\\@.+\\..+", ErrorMessage = "Informe um email válido...")]
        [Display(Name = "Email")]
        [DisplayName("Email")]
        [Column("Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Cpf Obrigatório")]
        [Display(Name = "CPF", Description = "Informe somente Números.")]
        [DisplayName( "CPF")]
        [Range(1, 99999999999999)]
        [Column("CPF")]
        public string cpf { get; set; }

        [Required(ErrorMessage = "Rg Obrigatório")]
        [Display(Name = "RG", Description = "Informe somente Números.")]
        [DisplayName("RG")]
        [Range(1, 9999999999999)]
        [Column("RG")]
        public string rg { get; set; }

        [Required(ErrorMessage = "Data de Nascimento Obrigatório")]     
        [Display(Name = "Data de Nascimento")]
        [DisplayName("Data Nasc.")]
        [DisplayFormat(DataFormatString = "mm/dd/yyyy")]
        public string DataNasc { get; set; }

        [Required(ErrorMessage = "Informe Passaporte")]
        [Display(Name = "Passaporte")]
        public string passaporte { get; set; }

        public Endereco endereco { get; set; }

    }
    
}
