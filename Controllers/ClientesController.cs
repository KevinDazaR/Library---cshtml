using Microsoft.AspNetCore.Mvc;

namespace Mvc.Controllers
{
    public class ClientesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Delete()
        {
            return View();
        }

        public IActionResult Edit()
        {
            return View();
        }
        public IActionResult ModalEdite()
        {
            return View();
        }
        public IActionResult Create()
        {
            return View();
        }
        public IActionResult ModalCreate()
        {
            return View();
        }
    }

}