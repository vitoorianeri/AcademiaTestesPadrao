using System;
using OpenQA.Selenium;

namespace AcademiaTestePadra.Page
{
    public class DepartamentPage
    {

        private IWebDriver driver;
        public DepartamentPage(IWebDriver superDriver)
        {
            driver = superDriver;
        }

        public IWebElement btnItem()
        {
            return driver.FindElement(By.LinkText("Printed Dress"));
        }

        public IWebElement btnAddCarrinho()
        {
            return driver.FindElement(By.XPath("//*[@id=\"add_to_cart\"]/button"));
        }

        public IWebElement btnContinuarComprando()
        {
            return driver.FindElement(By.XPath("/html/body/div/div[1]/header/div[3]/div/div/div[4]/div[1]/div[2]/div[4]/span"));
        }
    }
}
