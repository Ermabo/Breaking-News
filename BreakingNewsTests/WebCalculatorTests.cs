using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebLib.Interfaces;
using WebLib.WebFunctions;
using Moq;

namespace BreakingNewsTests
{
    [TestFixture]
    public class WebCalculatorTests
    {
        /// <summary>
        /// All tests that input invalid data (null, string.Empty) looks for the WebCalculator "Fail value" (-1) to be returned
        /// </summary>

        [Test]
        // Test for null WebCollector.
        public void NullObjectTest()
        {
            string keyword = "Trump";

            IWebCalculator calculator = new WebCalculator();
            IWebCollector collector = null;          

            int numberOfMatches = calculator.CalculateNumberOfHits(collector, keyword);

            Assert.AreEqual(-1, numberOfMatches);
        }

        [Test]
        // Test for null HTML code in WebCollector.
        public void HtmlNullCodeTest()
        {
            string keyword = "Trump";

            IWebCalculator calculator = new WebCalculator();
            var mockedCollector = new Mock<IWebCollector>();

            mockedCollector.SetupAllProperties();
            mockedCollector.Object.HtmlCode = null;

            int numberOfMatches = calculator.CalculateNumberOfHits(mockedCollector.Object, keyword);

            Assert.AreEqual(-1, numberOfMatches);
        }

        [Test]
        // Test for string.Empty in WebCollector.HtmlCode.
        public void HtmlStringEmptyTest()
        {
            string keyword = "Trump";

            IWebCalculator calculator = new WebCalculator();
            var mockedCollector = new Mock<IWebCollector>();

            mockedCollector.SetupAllProperties();
            mockedCollector.Object.HtmlCode = string.Empty;

            int numberOfMatches = calculator.CalculateNumberOfHits(mockedCollector.Object, keyword);

            Assert.AreEqual(-1, numberOfMatches);
        }

        [Test]
        // Test for null search-keyword.
        public void KeywordNullTest()
        {
            string keyword = null;

            IWebCalculator calculator = new WebCalculator();
            var mockedCollector = new Mock<IWebCollector>();

            mockedCollector.SetupAllProperties();
            mockedCollector.Object.HtmlCode = "trumptrumptrump";

            int numberOfMatches = calculator.CalculateNumberOfHits(mockedCollector.Object, keyword);

            Assert.AreEqual(-1, numberOfMatches);
        }

        [Test]
        // Test for string.Empty search-keyword.
        public void KeywordStringEmptyTest()
        {
            string keyword = string.Empty;

            IWebCalculator calculator = new WebCalculator();
            var mockedCollector = new Mock<IWebCollector>();

            mockedCollector.SetupAllProperties();
            mockedCollector.Object.HtmlCode = "Sune";

            int numberOfMatches = calculator.CalculateNumberOfHits(mockedCollector.Object, keyword);

            Assert.AreEqual(-1, numberOfMatches);
        }

        [Test]
        // Test to check if inputting valid data works.
        public void ValidDataTest()
        {
            string keyword = "Trump";

            IWebCalculator calculator = new WebCalculator();
            var mockedCollector = new Mock<IWebCollector>();

            mockedCollector.SetupAllProperties();
            mockedCollector.Object.HtmlCode = "trumptrumptrump"; // Simulate HTML code using 3x Trump.

            int numberOfMatches = calculator.CalculateNumberOfHits(mockedCollector.Object, keyword);

            Assert.AreEqual(3, numberOfMatches); // Expects 3 matches of Trump
        }
    }
}
