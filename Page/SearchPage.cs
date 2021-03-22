using System;
using OpenQA.Selenium;

namespace AcademiaTestePadra.Page
{
    public class SearchPage
    {
        private IWebDriver driver;
        public SearchPage(IWebDriver superDriver)
        {
            driver = superDriver;
        }

        public IWebElement btnItem()
        {
            return driver.FindElement(By.LinkText("Blouse"));
        }

    }
}
