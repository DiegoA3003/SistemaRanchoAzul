using Microsoft.AspNetCore.Mvc;

namespace RANCHO_AZUL.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult PanelAdmin()
        {
            return View();
        }
    }
}
