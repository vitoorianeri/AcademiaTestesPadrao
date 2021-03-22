using System;
using AcademiaTestePadra.Page;
using NUnit.Framework;
using OpenQA.Selenium;

namespace AcademiaTestePadra.Model
{
    public class PaymentModel
    {
        private IWebDriver driver;
        private PaymentPage paymentPage;
        public PaymentModel(IWebDriver superDriver)
        {
            driver = superDriver;
            paymentPage = new PaymentPage(this.driver);
        }

        public void clicarItem()
        {
            Assert.IsTrue(paymentPage.btnItem().Displayed);
            paymentPage.btnItem().Click();
        }

        public void procedendoPagamento()
        {
            Assert.IsTrue(paymentPage.btnProceed2().Displayed);
            paymentPage.btnProceed2().Click();
            paymentPage.btnProceedTo().Click();
            paymentPage.btnSubmit().Click();
            paymentPage.cbxAgreement().Click();
            paymentPage.btnProceed2().Click();
            paymentPage.btnMethodPayment().Click();

            Assert.IsTrue(paymentPage.btnConfirmOrder().Displayed);
            paymentPage.btnConfirmOrder().Click();

            //Assert.IsTrue(paymentPage.validacao().Displayed);

        }
    }
}
