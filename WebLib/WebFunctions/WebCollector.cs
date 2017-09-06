using WebLib.Interfaces;
using System.Net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebLib.WebFunctions
{
    public class WebCollector : IWebCollector
    {
        public string HtmlCode { get; set; }

        public void GetHTMLFromUrl(string url)
        {
            // Failchecks.
            if (url == null || url == string.Empty || !url.Contains("http://"))
                HtmlCode = string.Empty;

            else
            {
                // We end up here if we have a valid url.
                try
                {
                    WebClient webClient = new WebClient();

                    Task<String> getHtmlCode = Task.Run(async () => await webClient.DownloadStringTaskAsync(url));
                    HtmlCode = getHtmlCode.Result;
                }

                catch
                {
                    // Sets the Htmlcode to "Fail value" if we don't pass failchecks.
                    HtmlCode = string.Empty;
                }               
            }
        }
    }
}
