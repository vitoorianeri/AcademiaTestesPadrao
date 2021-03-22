using System;
using AcademiaTestePadra.Page;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace AcademiaTestePadra.Model
{
    public class SignInModel
    {
        private IWebDriver driver;
        private SignInPage signinPage;

        public SignInModel(IWebDriver superDriver)
        {
            driver = superDriver;
            signinPage = new SignInPage(this.driver);
        }

        public void criaUsuario(String sEmail, String sfName, String slName, String sPasswd,
            String sAddress, String sCity, String sZipcode,
            String sMobile, String sAlias)
        {
            Assert.IsTrue(signinPage.txtemailAddress().Displayed);
            signinPage.txtemailAddress().SendKeys(sEmail);
            signinPage.btnCreateAccount().Click();
            signinPage.txtfName().SendKeys(sfName);
            signinPage.txtlName().SendKeys(slName);
            signinPage.txtPasswd().SendKeys(sPasswd);
            signinPage.txtAddress().SendKeys(sAddress);
            signinPage.txtCity().SendKeys(sCity);

            SelectElement sElementState = new SelectElement(signinPage.state());
            sElementState.SelectByValue("1");

            signinPage.txtZipCode().SendKeys(sZipcode);
            signinPage.txtMobilePhone().SendKeys(sMobile);
            signinPage.txtAlias().SendKeys(sAlias);
            signinPage.btnRegister().Click();


        }
    }
}
