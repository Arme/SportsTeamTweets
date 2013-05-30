using SportsTeamTweets.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Linq;

namespace SportsTeamTweets.Managers
{
    public class SubMenuNavManager
    {
        public static SubMenuNavModel Load(string league, string conference)
        {
            SubMenuNavModel leftNav = new SubMenuNavModel();

            XDocument xDoc = XDocument.Load(HttpContext.Current.Server.MapPath(@"~/Content/XML/Teams.xml"));

            var conferences = from lg in xDoc.Descendants("league")
                              where (string)lg.Attribute("title") == league
                              select lg;
            var links =       from conf in conferences.Descendants("conference")
                              where (string)conf.Attribute("title") == conference
                              select conf.Elements("link");

            if (links.Count() > 0)
            {
                foreach (var link in links.First())
                {
                    leftNav.Links.Add((string)link.Attribute("title"), (string)link.Attribute("href"));
                }
            }

            return leftNav;
        }

        public static SubMenuNavModel LeagueLoad(string league)
        {
            SubMenuNavModel leftNav = new SubMenuNavModel();

            XDocument xDoc = XDocument.Load(HttpContext.Current.Server.MapPath(@"~/Content/XML/Teams.xml"));

            var links =       from lg in xDoc.Descendants("league")
                              where (string)lg.Attribute("title") == league
                              select lg.Descendants("conference").Elements("link");

            if (links.Count() > 0)
            {
                foreach (var link in links.First())
                {
                    leftNav.Links.Add((string)link.Attribute("title"), (string)link.Attribute("href"));
                }
            }

            return leftNav;
        }
    }
}