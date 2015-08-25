using LGroup.Business;
using LGroup.Business.Core;
using LGroup.Model;
using NUnit.Framework;
// Onde ficam as estrategias pros determinados clientes

// Inicializar das estratégias

namespace LGroup.Test.Business
{
    [TestFixture]
    public sealed class DescontoStrategyTest
    {
        private ProdutoModel _produto;

        [SetUp]
        public void Inicializar()
        {
            _produto = new ProdutoModel
            {
                Valor = 200
            };
        }

        [Test]
        public void Aplicar_Desconto_BlackFriday()
        {
            var estrategia = new DescontoStrategy(new BlackFridayBusiness());
            var novoValor = estrategia.ObterDesconto(_produto.Valor);
        }

        [Test]
        public void Aplicar_Desconto_Natal()
        {
            var estrategia = new DescontoStrategy(new NatalBusiness());
            var novoValor = estrategia.ObterDesconto(_produto.Valor);
        }
    }
}
