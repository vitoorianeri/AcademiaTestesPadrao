using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace AcademiaTestePadra.Abstracoes
{
    public class SuperClass : IDisposable
    {
        protected IWebDriver driver { get; }
        public SuperClass()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(60);
            GoHome();
        }

        public void Dispose()
        {
            driver?.Dispose();
            driver?.Quit();
            GC.SuppressFinalize(this);
        }

        public void GoHome()
        {
            driver.Navigate().GoToUrl("http://automationpractice.com/index.php");
        }
    }
}
