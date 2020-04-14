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
           int active =  _humanServices.AuthorizationHuman(login,password);

           if (active == 1)
           {
               AuthorizatedHuman.authorizatedHuman = login;
               return RedirectToAction("Index", "Home" );
           }
           if (active == 2)
           {
               ViewBag.Error = "пользователен не активен";
               return View();
           }
           if (active == 3)
           {
               ViewBag.Error = "пользователен заблокирован";
               return View();
           }
           
           return RedirectToAction("Login", "Human");
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
        
        [HttpGet]
        public IActionResult Update()
        {
            return View();
        }
        
        [HttpPost]
        public IActionResult Update(string firstname, string lastname, string pat, string password)
        {
            _humanServices.UpdateHuman(AuthorizatedHuman.authorizatedHuman, firstname,lastname,pat,password);
            return RedirectToAction("Index", "Home");
        }
    }
}