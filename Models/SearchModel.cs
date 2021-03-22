using System;
using AcademiaTestePadra.Page;
using NUnit.Framework;
using OpenQA.Selenium;

namespace AcademiaTestePadra.Model
{
    public class SearchModel
    {
        private IWebDriver driver;
        private SearchPage searchPage;
        public SearchModel(IWebDriver superDriver)
        {
            driver = superDriver;
            searchPage = new SearchPage(driver);
        }

        public void clicarItem()
        {
            Assert.IsTrue(searchPage.btnItem().Displayed);
            searchPage.btnItem().Click();
        }

    }
}
