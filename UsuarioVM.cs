using RANCHO_AZUL.Models;
using System.ComponentModel.DataAnnotations;

namespace RANCHO_AZUL.ViewModels
{
    public class UsuarioVM
    {
        public int IdUsuarioVM { get; set; }
        public string NombreUsuarioVM { get; set; }
        public string CorreoVM { get; set; }
        public string ContrasenaVM { get; set; }
        public string ConfirmarContrasenaVM { get; set; }
        public DateTime FechaCreacionVM { get; set; }
        public bool EstadoVM { get; set; }
        public int RolIdVM { get; set; }
        public List<Rol> ListaRolesVM { get; set; }
    }
}
