using LGroup.Business.OperadoraCartao;
using LGroup.Model;
using NUnit.Framework;

namespace LGroup.Test.Business
{
    [TestFixture]
    public sealed class OperadoraCartaoTest
    {
        private PagamentoModel _pagamento;

        [TestFixtureSetUp]
        public void Inicialize()
        {
            _pagamento = new PagamentoModel();
        }


        [Test]
        public void Pagamento_Cielo()
        {
            _pagamento.Valor = 700M;
            _pagamento.Senha = "123456";
            
            var negocio = new CieloBusiness();
            negocio.Pagar(_pagamento);
        }

        [Test]
        public void Pagamento_PagueSeguro()
        {
            _pagamento.Valor = 250M;
            _pagamento.Senha = "Amém";

            // Essa cara apesar de estar no componente de negócio, ele é um adaptador. Ele pega os dados e coloca em um formato que seja
            // acessivel (compativel) com o CPM externo de pagamentos PagueSeguro.

            var negocio = new PagueSeguroBusiness();
            negocio.Pagar(_pagamento);
        }
    }
}
