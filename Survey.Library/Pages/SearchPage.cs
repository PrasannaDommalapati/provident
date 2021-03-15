using OpenQA.Selenium;
using Survey.Library.Extensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Survey.Library.Pages
{
    public class SearchPage : BasePage
    {
        public SearchPage(IWebDriver driver) : base(driver)
        {
        }

        private By SearchField => By.Id("q");

        //Search selenium

        public void Search()
        {
            SearchField.TypeInto(Driver, "selenium");
            SearchField.Click(Driver);
        }
    }
}
