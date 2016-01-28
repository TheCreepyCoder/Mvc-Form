using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using System.Web;
using System.Web.Mvc;
using MvcLogin.ViewModels;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace MvcLogin.Controllers
{
    public class AccountController : Controller
    {
        // GET: /<controller>/
        public ActionResult Index()
        {
            Session["username"] = avm.account.Username;
            return View("Welcome");
        }
        // Post: /<controller>/
        public ActionResult Login(AccountViewModel avm)
        {
            if(avm.account.Username.equals("Elias") && avm.account.Password.equals("12345yougotitright"))
            {

            }
            else
            {
                ViewBag.Error = "Account Is Invalid";
                return View("Index");
            }
        }
    }
}
