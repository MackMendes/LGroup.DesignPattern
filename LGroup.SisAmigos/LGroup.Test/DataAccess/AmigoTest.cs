using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

using LGroup.DataAccess;
using LGroup.Model;

// LAYERS -> Camada Lógicas (DLL's)
// TIERS -> Camadas Físicas (Maquinas)
namespace LGroup.Test.DataAccess
{
    [TestFixture]
    public sealed class AmigoTest
    {
        [TestFixtureSetUp]
        public void Inicialize()
        {

        }

        [Test]
        public void Testar_Expressao_Lambda_Doidona()
        {
            var dados = new AmigoDataAccessObject();
            var amigos = dados.Pesquisar(x => x.Codigo >= 1  && x.Nome.Contains("01"));

            Assert.AreNotEqual(0, amigos.Count());
        }

    }
}
