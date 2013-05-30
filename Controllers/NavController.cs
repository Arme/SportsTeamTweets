﻿using SportsTeamTweets.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SportsTeamTweets.Controllers
{
    public class NavController : Controller
    {
        public ViewResult HomeMenu()
        {
            return View();
        }

        public ViewResult NHLMenu()
        {
            return View();
        }

        public PartialViewResult HomeSubMenu(string league)
        {
            string viewLoc = "~/Views/Nav/" + league + "SubMenu.cshtml";
            return PartialView(viewLoc,
                SubMenuNavManager.LeagueLoad(league));
        }

        public PartialViewResult NHLSubMenu(string conference)
        {
            return PartialView("~/Views/Nav/NHLSubMenu.cshtml",
                SubMenuNavManager.Load("NHL", conference));
        }


    }
}
