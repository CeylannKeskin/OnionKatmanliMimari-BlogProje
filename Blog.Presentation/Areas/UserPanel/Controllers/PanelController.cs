using Microsoft.AspNetCore.Mvc;

namespace Blog.Presentation.Areas.UserPanel.Controllers
{
    [Area("UserPanel")]
    public class PanelController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
