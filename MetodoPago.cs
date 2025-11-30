using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RANCHO_AZUL.Models
{
    public class MetodoPago
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdMetodoDePago { get; set; }

        [Required, StringLength(50)]
        public string Nombre { get; set; }

        // Relaciones
        public ICollection<DetalleMetodoPago> DetalleMetodoPagos { get; set; }
    }
}
