using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAppHotel.Models
{
    [Table("Reservas")]
    public class Reservas
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Reserva")]
        [DisplayName("Número Reserva")]
        public string complemento { get; set; }

        [Required(ErrorMessage = "Informar Entrada")]
        [Display(Name = "DataEntrada")]
        [DisplayName("Data de Entrada")]
        [DisplayFormat(DataFormatString = "mm/dd/yyyy")]
        public string DataEntrada { get; set; }
        
        [Required(ErrorMessage = "Informar Saída")]
        [Display(Name = "DataSaida")]
        [DisplayName("Data de Saída")]
        [DisplayFormat(DataFormatString = "mm/dd/yyyy")]
        public string DataSaida { get; set; }
        
        [Required]
        [Display(Name = "ValorDiaria")]
        [DisplayName("Valor Díaria")]
        [DisplayFormat(DataFormatString = "{0,c}")]
        public float PrecoReserva { get; set; }
        

        [Display(Name = "Classificacao")]
        [DisplayName("Classificação")]
        public string classificacao { get; set; }

    }
}
