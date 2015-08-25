using LGroup.Model;
using LGroup.Model.Factory;
using NUnit.Framework;

namespace LGroup.Test.Model
{
    [TestFixture]
    public sealed class ModelFactoryTest
    {
        [Test]
        public void Testar_Criacao_Classe_Produto()
        {
            var modeloProduto = ModelFactory.Inicializar<ProdutoModel>();
            Assert.AreEqual(typeof(ProdutoModel), modeloProduto.GetType());
        }

        [Test]
        public void Testar_Criacao_Classe_Cliente()
        {
            var modeloCliente = ModelFactory.Inicializar<ClienteModel>();
            Assert.AreEqual(typeof(ClienteModel), modeloCliente.GetType());
        }
    }
}
