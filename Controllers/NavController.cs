using SportsTeamTweets.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SportsTeamTweets.Controllers
{
    public class NavController : Controller
    {
        public ViewResult Menu()
        {
            return View();
        }

        public PartialViewResult SubMenu(string conference)
        {
            return PartialView("~/Views/Nav/SubMenu.cshtml",
                SubMenuNavManager.Load(conference));
        }

    }
}
