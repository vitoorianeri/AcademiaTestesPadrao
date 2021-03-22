using System;
using OpenQA.Selenium;

namespace AcademiaTestePadra.Page
{
    public class HomePage
    {
        private IWebDriver driver;
        public HomePage(IWebDriver superDriver)
        {
            driver = superDriver;
        }

        public IWebElement btnItemBlusa()
        {
            return driver.FindElement(By.LinkText("Faded Short Sleeve T-shirts"));
        }

        public IWebElement btntxtSearch()
        {
            return driver.FindElement(By.Id("search_query_top"));
        }

        public IWebElement btnSearch()
        {
            return driver.FindElement(By.XPath("//*[@id=\"searchbox\"]/button"));
        }

        public IWebElement btnDresses()
        {
            return driver.FindElement(By.XPath("//*[@id=\"block_top_menu\"]/ul/li[2]/a"));
        }

        public IWebElement btnSignIn()
        {
            return driver.FindElement(By.LinkText("Sign in"));
        }
    }
}
