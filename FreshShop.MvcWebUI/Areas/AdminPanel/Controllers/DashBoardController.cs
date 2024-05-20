using FreshShop.MvcWebUI.ActionFilters;
using Microsoft.AspNetCore.Mvc;

namespace FreshShop.MvcWebUI.Areas.AdminPanel.Controllers
{
    [Area("AdminPanel")]
    [ActiveManagerAF]
    public class DashBoardController : Controller
    {       
        public IActionResult Index()
        {
            return View();
        }
    }
}
