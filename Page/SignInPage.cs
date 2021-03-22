using System;
using OpenQA.Selenium;

namespace AcademiaTestePadra.Page
{
    public class SignInPage
    {
        private IWebDriver driver;
        public SignInPage(IWebDriver superDriver)
        {
            driver = superDriver;
        }

        public IWebElement txtemailAddress()
        {
            return driver.FindElement(By.Id("email_create"));
        }

        public IWebElement btnCreateAccount()
        {
            return driver.FindElement(By.Id("SubmitCreate"));
        }

        public IWebElement txtfName()
        {
            return driver.FindElement(By.Id("customer_firstname"));
        }

        public IWebElement txtlName()
        {
            return driver.FindElement(By.Id("customer_lastname"));
        }

        public IWebElement txtPasswd()
        {
            return driver.FindElement(By.Id("passwd"));
        }

        public IWebElement txtAddress()
        {
            return driver.FindElement(By.Id("address1"));
        }

        public IWebElement txtCity()
        {
            return driver.FindElement(By.Id("city"));
        }

        public IWebElement state()
        {
            return driver.FindElement(By.Id("id_state"));
        }


        public IWebElement txtZipCode()
        {
            return driver.FindElement(By.Id("postcode"));
        }

        public IWebElement txtMobilePhone()
        {
            return driver.FindElement(By.Id("phone_mobile"));
        }

        public IWebElement txtAlias()
        {
            return driver.FindElement(By.Id("alias"));
        }

        public IWebElement btnRegister()
        {
            return driver.FindElement(By.Id("submitAccount"));
        }

        public IWebElement validarMinhaConta()
        {
            return driver.FindElement(By.LinkText("SHOPPING-CART SUMMARY"));
        }
    }
}
