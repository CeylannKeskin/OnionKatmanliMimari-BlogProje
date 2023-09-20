using Microsoft.AspNetCore.Mvc;

namespace Blog.Presentation.Areas.AdminPanel.Controllers
{
    [Area("AdminPanel")]
    public class PanelController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
