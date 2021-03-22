using System;
using AcademiaTestePadra.Abstracoes;
using AcademiaTestePadra.Model;
using NUnit.Framework;

namespace AcademiaTestePadra.Test
{
    public class SiteTest : SuperClass
    {
        private HomePageModel homePage;
        private SearchModel searchModel;
        private DepartamentModel departamentoModel;
        private SignInModel signInModel;
        private PaymentModel paymentModel;

        public SiteTest() : base()
        {
            homePage = new HomePageModel(this.driver);
            searchModel = new SearchModel(this.driver);
            departamentoModel = new DepartamentModel(this.driver);
            signInModel = new SignInModel(this.driver);
            paymentModel = new PaymentModel(this.driver);
        }


        [Test]
        //Primeiro Teste
        public void AbrirItemHomePage()
        {
            homePage.clicarItem();
            GoHome();
        }

        [Test]
        //Segundo Teste
        public void RealizarBusca()
        {
            homePage.search("Blouse");
            searchModel.clicarItem();
            GoHome();
        }

        [Test]
        // Terceiro Teste
        public void RealizarNavegacao()
        {
            homePage.navegarDepartamento();
            departamentoModel.clicarItem();
            GoHome();

        }

        [Test]
        //Quarto Teste
        public void AbrirItemAdcCarrinho()
        {
            homePage.navegarDepartamento();
            departamentoModel.clicarItem();
            departamentoModel.clicarAddCarrinho();
            departamentoModel.continueComprando();
            GoHome();
        }

        [Test]
        // Quinto Teste
        public void CriarUsuario()
        {
            homePage.signInUsuario();
            signInModel.criaUsuario("tese@teste.bq", "John", "Doe", "123456789", "Rua cento e trinta e seis", "Recife", "38083", "555555555", "Alias Address");
            GoHome();
        }

        [Test]
        // Sexto Teste
        public void RealizarCompraComplete()
        {
            homePage.search("Printed Chiffon Dress");
            paymentModel.clicarItem();
            departamentoModel.clicarAddCarrinho();
            paymentModel.procedendoPagamento();
            GoHome();

        }



    }
}
