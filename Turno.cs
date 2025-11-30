using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RANCHO_AZUL.Models
{
    public class Turno
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdTurno { get; set; }

        [Required]
        public DateTime Fecha { get; set; }

        [Required]
        public DateTime HoraInicio { get; set; }

        [Required]
        public DateTime HoraFin { get; set; }

        // Relaciones
        public ICollection<EmpleadoTurno> EmpleadoTurnos { get; set; }
    }
}
