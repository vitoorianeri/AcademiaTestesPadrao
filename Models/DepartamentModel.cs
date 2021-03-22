using System;
using AcademiaTestePadra.Page;
using NUnit.Framework;
using OpenQA.Selenium;

namespace AcademiaTestePadra.Model
{
    public class DepartamentModel
    {
        private IWebDriver driver;
        private DepartamentPage departamentoPage;
        public DepartamentModel(IWebDriver superDriver)
        {
            driver = superDriver;
            departamentoPage = new DepartamentPage(this.driver);
        }

        public void clicarItem()
        {
            Assert.IsTrue(departamentoPage.btnItem().Displayed);

            departamentoPage.btnItem().Click();
        }

        public void clicarAddCarrinho()
        {
            Assert.IsTrue(departamentoPage.btnAddCarrinho().Displayed);
            departamentoPage.btnAddCarrinho().Click();
        }

        public void continueComprando()
        {
            //Assert.IsTrue(departamentoPage.btnContinuarComprando().Displayed);
            departamentoPage.btnContinuarComprando().Click();
        }
    }
}
