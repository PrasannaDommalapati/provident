using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.ObjectModel;

namespace Survey.Library.Extensions
{
    public static class WebDriver
    {
        /// <summary>
        /// Navigate to is an extension method naviage to 'url'
        /// </summary>
        /// <param name="driver"></param>
        /// <param name="url"></param>
        public static void NavigateTo(this IWebDriver driver, string url) => driver.Navigate().GoToUrl(url);

        public static IWebElement FindWebElement(this IWebDriver driver, By by, int timeoutInSeconds = 5)
        {
            if (timeoutInSeconds > 0)
            {
                var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeoutInSeconds));
                return wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(by));
            }
            return driver.FindElement(by);
        }

        public static ReadOnlyCollection<IWebElement> FindWebElements(this IWebDriver driver, By by, int timeoutInSeconds = 5)
        {
            if (timeoutInSeconds > 0)
            {
                var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeoutInSeconds));
                return wait.Until(drv => (drv.FindElements(by).Count > 0) ? drv.FindElements(by) : null);
            }
            return driver.FindElements(by);
        }
    }
}