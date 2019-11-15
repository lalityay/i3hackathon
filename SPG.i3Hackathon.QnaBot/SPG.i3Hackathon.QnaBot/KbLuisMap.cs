using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SPG.i3Hackathon.QnaBot
{
    public class KbLuisMap
    {
        public static Dictionary<string,string> GetMap()
        {
            Dictionary<string, string> dict = new Dictionary<string, string>();

            dict.Add("People", "63a1f89b-7151-475c-a7c1-8debbc90a5b7");
            dict.Add("Governance", "88f5af41-24e9-4149-947c-c1e823558cd1");
            //dict.Add("Environment", "88f5af41-24e9-4149-947c-c1e823558cd1");

            return dict;
        }

    }
}
