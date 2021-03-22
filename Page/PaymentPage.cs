using System;
using OpenQA.Selenium;

namespace AcademiaTestePadra.Page
{
    public class PaymentPage
    {
        private IWebDriver driver;
        public PaymentPage(IWebDriver superDriver)
        {
            driver = superDriver;
        }

        public IWebElement btnItem()
        {
            return driver.FindElement(By.LinkText("Printed Chiffon Dress"));
        }

        public IWebElement btnProceed1()
        {
            return driver.FindElement(By.LinkText("Proceed to checkout"));
        }

        public IWebElement btnProceedTo()
        {
            return driver.FindElement(By.LinkText("Proceed to checkout"));
        }

        public IWebElement btnSubmit()
        {
            return driver.FindElement(By.Name("processAddress"));
        }

        public IWebElement cbxAgreement()
        {
            return driver.FindElement(By.Name("cgv"));
        }

        public IWebElement btnProceed2()
        {
            return driver.FindElement(By.Name("processCarrier"));
        }

        public IWebElement btnMethodPayment()
        {
            return driver.FindElement(By.ClassName("bankwire"));
        }

        public IWebElement btnConfirmOrder()
        {
            return driver.FindElement(By.XPath("//*[@id=\"cart_navigation\"]/button"));
        }

        public IWebElement validacao()
        {
            return driver.FindElement(By.XPath("//*[@id=\"center_column\"]/h1"));
            //Order confirmation
        }
    }
}
