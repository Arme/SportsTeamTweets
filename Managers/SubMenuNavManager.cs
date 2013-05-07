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
        public static SubMenuNavModel Load(string actionName)
        {
            SubMenuNavModel leftNav = new SubMenuNavModel();

            XDocument xDoc = XDocument.Load(HttpContext.Current.Server.MapPath(@"~/Content/XML/NHLNavMenu.xml"));
            
            var links = from node in xDoc.Descendants("node")
                        where (string)node.Attribute("title") == actionName
                        select node.Elements("link");

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