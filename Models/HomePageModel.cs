using System;
using AcademiaTestePadra.Page;
using NUnit.Framework;
using OpenQA.Selenium;

namespace AcademiaTestePadra.Model
{
    public class HomePageModel
    {
        private IWebDriver driver;
        private HomePage home;
        public HomePageModel(IWebDriver superDriver)
        {
            driver = superDriver;
            home = new HomePage(driver);
        }

        public void clicarItem()
        {
            Assert.IsTrue(home.btnItemBlusa().Displayed);
            home.btnItemBlusa().Click();
        }

        public void search(String aSearch)
        {
            Assert.IsTrue(home.btnSearch().Displayed);
            home.btnSearch().Click();
            home.btnSearch().SendKeys(aSearch);
            home.btnSearch().Click();
        }

        public void navegarDepartamento()
        {
            Assert.IsTrue(home.btnDresses().Displayed);
            home.btnDresses().Click();
        }

        public void signInUsuario()
        {
            Assert.IsTrue(home.btnSignIn().Displayed);
            home.btnSignIn().Click();
        }

    }
}
