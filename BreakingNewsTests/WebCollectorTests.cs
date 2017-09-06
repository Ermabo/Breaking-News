using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using System.Net;
using WebLib.Interfaces;
using WebLib.WebFunctions;

namespace BreakingNewsTests
{
    [TestFixture]
    public class WebCollectorTests
    {
        /// <summary>
        /// All tests that input invalid data (null, string.Empty) looks for the WebCollector "Fail value" (string.Empty) to be returned.
        /// </summary>

        [Test]
        // Test for null URL.
        public void NullTest()
        {
            IWebCollector collector = new WebCollector();
            string url = null;

            collector.GetHTMLFromUrl(url);

            Assert.AreEqual(string.Empty, collector.HtmlCode);

        }

        [Test]
        // Test for string.Empty URL.
        public void UrlStringEmptyTest()
        {
            IWebCollector collector = new WebCollector();
            string url = string.Empty;

            collector.GetHTMLFromUrl(url);

            Assert.AreEqual(string.Empty, collector.HtmlCode);
            
        }

        [Test]
        // Test for no http:// in URL.
        public void UrlNoHttpTest()
        {
            IWebCollector collector = new WebCollector();
            string url = "aftonbladet.se";

            collector.GetHTMLFromUrl(url);

            Assert.AreEqual(string.Empty, collector.HtmlCode);
        }

        [Test]
        // Test to see if inputting valid data works
        public void ValidDataTest()
        {
            IWebCollector collector = new WebCollector();
            string url = "http://aftonbladet.se";

            collector.GetHTMLFromUrl(url);

            if (collector.HtmlCode == string.Empty)
                Assert.Fail("String is empty when it should contain HTML code");
        }
    }
}
