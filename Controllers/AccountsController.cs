using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace OhEss.Controllers
{
    public class AccountsController : Controller
    {
        // 
        // GET: /Accounts/

        public string Index()
        {
            return "This is the default page...";
        }

        // 
        // GET: /Accounts/Login/ 

        public string Login()
        {
            return "This is the Login action method...";
        }
		// 
        // GET: /Accounts/Signup/ 

        public string Signup()
        {
            return "This is the Signup action method...";
        }
    }
}