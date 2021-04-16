using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
using Microsoft.Docs.Samples;

namespace OhEss.Areas.Accounts.Controllers
{
    public class AccountsController : Controller
    {
        // 
        // GET: /Accounts/

        public IActionResult Index()
        {
            return View();
        }

        // 
        // GET: /Accounts/Login/ 

        public IActionResult Login()
        {
            return View("~/Views/Accounts/Login/Login.cshtml");
        }
		// 
        // GET: /Accounts/Create/ 

        public string Create()
        {
            return "This is the action for Creating Accounts...";
        }
		
		public IActionResult LoginBtn()
			{
			return RedirectToAction("Login", "AccountsController");
			}
    }
}