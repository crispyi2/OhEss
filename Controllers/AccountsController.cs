using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace OhEss.Controllers
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

        public string Login()
        {
            return "This is the Login action method...";
        }
		// 
        // GET: /Accounts/Create/ 

        public string Create()
        {
            return "This is the action for Creating Accounts...";
        }
    }
}