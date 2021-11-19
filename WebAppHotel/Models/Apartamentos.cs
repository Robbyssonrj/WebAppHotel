using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAppHotel.Models
{
    [Table("Apartamentos")]
    public class Apartamentos
    {
        [Key]
        public int Id { get; set; }


        [Required]
        [Display(Name = "Nome")]
        [DisplayName("Nome")]
        [Column("Nome")]
        public string Nome { get; set; }

        [Required]
        [Display(Name = "Tipo Apartamento")]
        [DisplayName("Tipo")]
        [Column("TipoApartamento")]
        public string TipoApto { get; set; }

        [Required]
        [Display(Name ="Categoria")]
        [DisplayName("Categoria")]
        [Column("Categoria")]
        public string Categoria { get; set; }

    }

    [Table("TipoApartamentos")]
    public class TipoApartamento 
    {

        [Key]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Nome")]
        [DisplayName("Tipo")]
        [Column("Nome")]
        public string Nome { get; set; }
        
        [Required]
        [Display(Name ="Classe")]
        [DisplayName("Tipo Apartamento")]
        [Column("Classe")]
        public string Classe { get; set; }

        [Required]
        [Display(Name = "ValorReserva")]
        [DisplayName("Data da Reserva")]
        [DisplayFormat(DataFormatString = "{0,c}")]
        public decimal PrecoReserva { get; set; }
               
    }
}
