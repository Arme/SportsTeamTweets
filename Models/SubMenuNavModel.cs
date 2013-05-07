using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SportsTeamTweets.Models
{
    public class SubMenuNavModel
    {
        public Dictionary<string, string> Links { get; set; }

        public SubMenuNavModel()
        {
            Links = new Dictionary<string, string>();
        }
    }
}