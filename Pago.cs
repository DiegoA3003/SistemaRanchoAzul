using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RANCHO_AZUL.Models
{
    public class Pago
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdPago { get; set; }

        [Required]
        public DateTime FechaPago { get; set; }

        // FK Boleta
        public int BoletaId { get; set; }
        public Boleta Boleta { get; set; }

        // Relaciones
        public ICollection<DetalleMetodoPago> DetallesMetodoPagos { get; set; }
    }
}
