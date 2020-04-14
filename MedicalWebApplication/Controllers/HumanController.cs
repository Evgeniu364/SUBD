using System.Threading.Tasks;
using MedicalWebApplication.Services;
using Microsoft.AspNetCore.Mvc;

namespace MedicalWebApplication.Controllers
{
    public class HumanController : Controller
    {
        private HumanServices _humanServices;
        public HumanController(HumanServices humanServices)
        {
            _humanServices = humanServices;
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public  IActionResult Login(string login, string password)
        {
            _humanServices.AuthorizationHuman(login,password);
            return RedirectToAction("Index", "Home");
        }
        
        [HttpGet]
        public IActionResult Registration()
        {
            return View();
        }
        
        [HttpPost]
        public IActionResult Registration(string firstname, string lastname, string pat, string login, string password)
        {
            _humanServices.RegistrationHuman(firstname,lastname,pat,
                1,login,password,2);
            return RedirectToAction("Index", "Home");
        }
    }
}