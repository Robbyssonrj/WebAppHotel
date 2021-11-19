using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAppHotel.Models
{
    [Table("Servicos")]
    public class Servicos
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Nome")]
        [DisplayName("Tipo")]
        [Column("Nome")]
        public string Nome { get; set; }

        [Required]
        [Display(Name = "Reficao")]
        [DisplayName("Refeição")]
        [Column("refeicao")]
        public string Classe { get; set; }

        [Required]
        [Display(Name = "ValorRefeicao")]
        [DisplayName("Data da Refeição")]
        [DisplayFormat(DataFormatString = "{0,c}")]
        public decimal PrecoReserva { get; set; }

    }        
}
