using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Xml.Linq;

namespace SportsTeamTweets.Controllers
{
    public class MLBController : Controller
    {
        public ActionResult Index()
        {
            return View(model: GetWidgetId("MLB"));
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

        public ActionResult BOS()
        {
            return View();
        }

        public ActionResult CHC()
        {
            return View();
        }

        public ActionResult CHW()
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

        public ActionResult COL()
        {
            return View();
        }

        public ActionResult DET()
        {
            return View();
        }

        public ActionResult HOU()
        {
            return View();
        }

        public ActionResult KCR()
        {
            return View();
        }

        public ActionResult LAA()
        {
            return View();
        }

        public ActionResult LAD()
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

        public ActionResult NYM()
        {
            return View();
        }

        public ActionResult NYY()
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

        public ActionResult SDP()
        {
            return View();
        }

        public ActionResult SEA()
        {
            return View();
        }

        public ActionResult SFG()
        {
            return View();
        }

        public ActionResult STL()
        {
            return View();
        }

        public ActionResult TBR()
        {
            return View();
        }

        public ActionResult TEX()
        {
            return View();
        }

        public ActionResult TOR()
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
