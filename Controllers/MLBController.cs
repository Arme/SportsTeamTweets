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

        //Western Conference

        public ActionResult CHI()
        {
            return View(model: GetWidgetId("CHI"));
        }
        public ActionResult CBJ()
        {
            return View(model: GetWidgetId("CBJ"));
        }
        public ActionResult DET()
        {
            return View(model: GetWidgetId("DET"));
        }
        public ActionResult NSH()
        {
            return View(model: GetWidgetId("NSH"));
        }
        public ActionResult STL()
        {
            return View(model: GetWidgetId("STL"));
        }
        public ActionResult CGY()
        {
            return View(model: GetWidgetId("CGY"));
        }
        public ActionResult COL()
        {
            return View(model: GetWidgetId("COL"));
        }
        public ActionResult EDM()
        {
            return View(model: GetWidgetId("EDM"));
        }
        public ActionResult MIN()
        {
            return View(model: GetWidgetId("MIN"));
        }
        public ActionResult VAN()
        {
            return View(model: GetWidgetId("VAN"));
        }
        public ActionResult ANA()
        {
            return View(model: GetWidgetId("ANA"));
        }
        public ActionResult DAL()
        {
            return View(model: GetWidgetId("DAL"));
        }
        public ActionResult LAK()
        {
            return View(model: GetWidgetId("LAK"));
        }
        public ActionResult PHX()
        {
            return View(model: GetWidgetId("PHX"));
        }
        public ActionResult SJS()
        {
            return View(model: GetWidgetId("SJS"));
        }
        
        //Eastern Conference

        public ActionResult NJD()
        {
            return View(model: GetWidgetId("NJD"));
        }
        public ActionResult NYI()
        {
            return View(model: GetWidgetId("NYI"));
        }
        public ActionResult NYR()
        {
            return View(model: GetWidgetId("NYR"));
        }
        public ActionResult PHI()
        {
            return View(model: GetWidgetId("PHI"));
        }
        public ActionResult PIT()
        {
            return View(model: GetWidgetId("PIT"));
        }
        public ActionResult BOS()
        {
            return View(model: GetWidgetId("BOS"));
        }
        public ActionResult BUF()
        {
            return View(model: GetWidgetId("BUF"));
        }
        public ActionResult MTL()
        {
            return View(model: GetWidgetId("MTL"));
        }
        public ActionResult OTT()
        {
            return View(model: GetWidgetId("OTT"));
        }
        public ActionResult TOR()
        {
            return View(model: GetWidgetId("TOR"));
        }
        public ActionResult CAR()
        {
            return View(model: GetWidgetId("CAR"));
        }
        public ActionResult FLA()
        {
            return View(model: GetWidgetId("FLA"));
        }
        public ActionResult TBL()
        {
            return View(model: GetWidgetId("TBL"));
        }
        public ActionResult WSH()
        {
            return View(model: GetWidgetId("WSH"));
        }
        public ActionResult WPG()
        {
            return View(model: GetWidgetId("WPG"));
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
