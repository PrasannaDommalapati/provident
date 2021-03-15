using OpenQA.Selenium;

namespace Survey.Library
{
    public class BasePage
    {
        public IWebDriver Driver { get; set; }

        public BasePage(IWebDriver driver) => Driver = driver;
    }
}
