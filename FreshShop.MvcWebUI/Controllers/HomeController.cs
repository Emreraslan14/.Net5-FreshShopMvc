using FreshShop.Business.Abstract;
using FreshShop.Business.Concrete;
using FreshShop.MvcWebUI.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace FreshShop.MvcWebUI.Controllers
{
    //IOC Container
    public class HomeController : Controller
    {
        private readonly IManagerBs _ManagerBs;
        public HomeController(IManagerBs ManagerBs)
        {
            _ManagerBs = ManagerBs;
        }               
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
