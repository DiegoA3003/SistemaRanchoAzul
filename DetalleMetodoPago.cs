using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RANCHO_AZUL.Models
{
    public class DetalleMetodoPago
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdDetallePago { get; set; }

        [Required]
        public decimal MontoPago { get; set; }

        // FK Pago
        public int PagoId { get; set; }
        public Pago Pagos { get; set; }

        // FK MetodoPago
        public int MetodoPagoId { get; set; }
        public MetodoPago MetodoPagos { get; set; }
    }
}
