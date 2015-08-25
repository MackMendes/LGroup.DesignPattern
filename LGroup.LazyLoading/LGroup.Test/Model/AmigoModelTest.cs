using LGroup.Model;
using NUnit.Framework;

namespace LGroup.Test.Model
{
    [TestFixture]
    public sealed class AmigoModelTest
    {
        [Test]
        public void Testar_Amigos_Eager_Loading()
        {
            // YAGNI (Você realmente precisa disso AGORA?)
            var modelo = new AmigoModel();
            var amigos = modelo.ListarEagerLoading();

            Assert.AreNotEqual(null, amigos[0].Sexo);
            Assert.AreNotEqual(null, amigos[0].Civil);
        }


        [Test]
        public void Testar_Amigos_Lazy_Loading()
        {
            // YAGNI (Você realmente precisa disso AGORA?)
            var modelo = new AmigoModel();
            var amigos = modelo.ListarLazyLoading();

            // Nesse momento mandamos trazer os dados das tabelas, relacionadas (CARREGAMENTO TARDIO) buscamos só quando precisamos.

            Assert.AreNotEqual(null, amigos[0].Sexo);
            Assert.AreNotEqual(null, amigos[0].Civil);
        }
    }
}
