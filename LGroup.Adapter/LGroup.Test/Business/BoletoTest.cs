using LGroup.Business.Boleto;
using LGroup.Model;
using NUnit.Framework;
using System;

namespace LGroup.Test.Business
{
    [TestFixture]
    public sealed class BoletoTest
    {
        private BoletoModel _boleto;

        [TestFixtureSetUp]
        public void Inicialize()
        {
            _boleto = new BoletoModel();
        }

        [Test]
        public void Boleto_Itau()
        {
            _boleto.Valor = 1000;
            _boleto.DataEmissao = DateTime.Now;
            _boleto.Cedente = "Banco ItauSA Unibanco";

            var adaptador = new ItauBusiness();
            adaptador.Emitir(_boleto);
        }

        [Test]
        public void Boleto_JpMorgan()
        {
            _boleto.Valor = 900;
            _boleto.DataEmissao = (DateTime.Now.AddDays(-1));
            _boleto.Cedente = "JP Morgon";

            var adaptador = new JpMorganBusiness();
            adaptador.Emitir(_boleto);
        }

        [Test]
        public void Boleto_BankOfAmerica()
        {
            _boleto.Valor = 300;
            _boleto.DataEmissao = DateTime.Now;
            _boleto.Cedente = "Bank Of America";
            
            // Na hora de chamar a classe adaptadora (remonta os dados) nem parece que é um adaptador parece que é uma classe normal de Business,
            // só saberemos se é um Adapter, olhando o código fonte dela (f12);
            var adaptador = new BankOfAmericaBusiness();
            adaptador.Emitir(_boleto);
        }
    }
}
