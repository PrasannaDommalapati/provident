using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Survey.Library.Extensions;


namespace AdminJourney.Tests
{
    public class BaseTest
    {
        protected IWebDriver _driver;

        [SetUp]
        public void Setup()
        {
            var url = TestContext.Parameters["webAppUrl"];
            ChromeOptions options = new ChromeOptions();
            options.AddArguments("ignore-certificate-errors", "no-sandbox", "--test-type", "--incognito");

            _driver = new ChromeDriver(options);
            _driver.NavigateTo(url);
        }


        [TearDown]
        public void Cleanup()
        {
            _driver.Close();
        }
    }
}