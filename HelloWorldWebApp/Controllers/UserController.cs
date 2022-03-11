using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserDaoLibrary;

namespace HelloWorldWebApp.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            UserDao dao = new UserDao();
            List<User> users = dao.GetUsers();
            dao.Close();
            ViewBag.users = users;
            return View();
        }
    }
}
