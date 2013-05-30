using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Xml.Linq;

namespace SportsTeamTweets.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            List<string> leagueWids = new List<string>();
            leagueWids.Add(GetWidgetId("NHL"));
            leagueWids.Add(GetWidgetId("NFL"));
            leagueWids.Add(GetWidgetId("NBA"));
            leagueWids.Add(GetWidgetId("MLB"));
            return View(model: leagueWids);
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