using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Xml.Linq;

namespace SportsTeamTweets.Controllers
{
    public class NBAController : Controller
    {
        public ActionResult Index()
        {
            return View(model: GetWidgetId("NBA"));
        }

        public ActionResult ATL()
        {
            return View();
        }

        public ActionResult BKN()
        {
            return View();
        }

        public ActionResult BOS()
        {
            return View();
        }

        public ActionResult CHA()
        {
            return View();
        }

        public ActionResult CHI()
        {
            return View();
        }

        public ActionResult CLE()
        {
            return View();
        }

        public ActionResult DAL()
        {
            return View();
        }

        public ActionResult DEN()
        {
            return View();
        }

        public ActionResult DET()
        {
            return View();
        }

        public ActionResult GSW()
        {
            return View();
        }

        public ActionResult HOU()
        {
            return View();
        }

        public ActionResult IND()
        {
            return View();
        }

        public ActionResult LAC()
        {
            return View();
        }

        public ActionResult LAL()
        {
            return View();
        }

        public ActionResult MEM()
        {
            return View();
        }

        public ActionResult MIA()
        {
            return View();
        }

        public ActionResult MIL()
        {
            return View();
        }

        public ActionResult MIN()
        {
            return View();
        }

        public ActionResult NOP()
        {
            return View();
        }

        public ActionResult NYK()
        {
            return View();
        }

        public ActionResult OKC()
        {
            return View();
        }

        public ActionResult ORL()
        {
            return View();
        }

        public ActionResult PHI()
        {
            return View();
        }

        public ActionResult PHX()
        {
            return View();
        }

        public ActionResult POR()
        {
            return View();
        }

        public ActionResult SAC()
        {
            return View();
        }

        public ActionResult SAS()
        {
            return View();
        }

        public ActionResult TOR()
        {
            return View();
        }

        public ActionResult UTA()
        {
            return View();
        }

        public ActionResult WSH()
        {
            return View();
        }

        public string GetWidgetId(string team)
        {
            XDocument widgetXML = XDocument.Load(System.Web.HttpContext.Current.Server.MapPath("~/App_Data/WidgetIds.xml"));

            var widgetId = from widget in widgetXML.Descendants("widget")
                           where (string)widget.Attribute("team") == team
                           select (string)widget.Attribute("wid");

            return widgetId.First();
        }
    }
}
