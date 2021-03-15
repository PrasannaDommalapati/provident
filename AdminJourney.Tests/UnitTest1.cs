using NUnit.Framework;
using Survey.Library.Pages;

namespace AdminJourney.Tests
{
    public class Tests : BaseTest
    {
        [Test]
        public void Test1()
        {
            Assert.AreEqual("Google", _driver.Title);

            var searchpage = new SearchPage(_driver);

            searchpage.Search();

        }

    }
}