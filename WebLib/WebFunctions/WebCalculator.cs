using WebLib.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WebLib.WebFunctions
{
    public class WebCalculator : IWebCalculator
    {
        public int CalculateNumberOfHits(IWebCollector webColl, string keyword)
        {
            int numberOfMatches = 0;

            if (webColl == null || webColl.HtmlCode == null || webColl.HtmlCode == string.Empty || keyword == null || keyword == string.Empty)
                return -1; // -1 is the "Fail value".

            else
            {
                //We end up here if we pass all the nullchecks and string.empty checks.
                foreach (Match match in Regex.Matches(webColl.HtmlCode.ToLower(), keyword.ToLower())) //ToLower for case insensetive
                    numberOfMatches++;

                return numberOfMatches;
            }
        }
    }
}
