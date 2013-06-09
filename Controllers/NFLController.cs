using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Xml.Linq;

namespace SportsTeamTweets.Controllers
{
    public class NFLController : Controller
    {
        public ActionResult Index()
        {
            return View(model: GetWidgetId("NFL"));
        }

        public ActionResult ARI()
        {
            return View();
        }

        public ActionResult ATL()
        {
            return View();
        }

        public ActionResult BAL()
        {
            return View();
        }

        public ActionResult BUF()
        {
            return View();
        }

        public ActionResult CAR()
        {
            return View();
        }

        public ActionResult CHI()
        {
            return View();
        }

        public ActionResult CIN()
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

        public ActionResult GBP()
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

        public ActionResult JAC()
        {
            return View();
        }

        public ActionResult KCC()
        {
            return View();
        }

        public ActionResult MIA()
        {
            return View();
        }

        public ActionResult MIN()
        {
            return View();
        }

        public ActionResult NEP()
        {
            return View();
        }

        public ActionResult NOS()
        {
            return View();
        }

        public ActionResult NYG()
        {
            return View();
        }

        public ActionResult NYJ()
        {
            return View();
        }

        public ActionResult OAK()
        {
            return View();
        }

        public ActionResult PHI()
        {
            return View();
        }

        public ActionResult PIT()
        {
            return View();
        }

        public ActionResult SDC()
        {
            return View();
        }

        public ActionResult SEA()
        {
            return View();
        }

        public ActionResult SFF()
        {
            return View();
        }

        public ActionResult STL()
        {
            return View();
        }

        public ActionResult TBB()
        {
            return View();
        }

        public ActionResult TEN()
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
