using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Subimos a DLL de testes de unidade
using NUnit.Framework;
using LGroup.Model;
// Onde ficam as estrategias pros determinados clientes
using LGroup.Business;

// Inicializar das estratégias
using LGroup.Business.Core;

namespace LGroup.Test.Business
{
    [TestFixture]
    public sealed class ValidacaoStrategyTest
    {
        private ClienteModel _clienteNovo;

        [SetUp]
        public void Inicializar()
        {
            // Setamos um novo cliente com os seus devidos dados
            _clienteNovo = new ClienteModel
            {
                Nome = "Mack Mendes",
                Email = "mack@gmail.com",
                Telefone = "(11) 99999-9999"
            };
        }

        [Test]
        [ExpectedException(ExpectedMessage = "Preencha o Telefone.")]
        public void Inicializar_Estrategia_Validacao_MercadoLivre()
        {
            var clienteNovo = new ClienteModel
            {
                Nome = "Mack Mendes",
                Email = "mack@gmail.com",
            };

            // Acionamos a classe de contexo (configuração) da estratégia é dentro dela que vamos injetar o Player
            // ** O Visual Studio não resolve dependencias de Segundo Nivil para cima, só de primeiro Nível DLL chamado DLL da segunda pra cima FERROU! rsrs...
            var estrategia = new ValidacaoStrategy(new MercadoLivreBusiness());
            estrategia.IniciarEstrategia(clienteNovo);
        }

        [Test]
        public void Inicializar_Estrategia_Validacao_Submarino()
        {
            // Acionamos a classe de contexo (configuração) da estratégia é dentro dela que vamos injetar o Player
            // ** O Visual Studio não resolve dependencias de Segundo Nivil para cima, só de primeiro Nível DLL chamado DLL da segunda pra cima FERROU! rsrs...
            var estrategia = new ValidacaoStrategy(new SubmarinoBusiness());
            estrategia.IniciarEstrategia(_clienteNovo);
        }

        [Test]
        public void Inicializar_Estrategia_Validacao_Americanas()
        {
            // Acionamos a classe de contexo (configuração) da estratégia é dentro dela que vamos injetar o Player
            // ** O Visual Studio não resolve dependencias de Segundo Nivil para cima, só de primeiro Nível DLL chamado DLL da segunda pra cima FERROU! rsrs...
            var estrategia = new ValidacaoStrategy(new AmericanasBusiness());
            estrategia.IniciarEstrategia(_clienteNovo);
        }

        // Utilizando o Padrão Strategy, indiretamente estamos utilizando outro padrão IoC (Inversão de Controle - Que inicializa as classes é um nível superior (uma classe superior))
        // Utilizando o principio OPEN/CLOSE, pois se alguma loja (Americanas, Submarino, Mercado), for sair, e só excluir a classe... não vai precisar ter que mudar uma classe! 
        // Na mesma coisa ocorre se for adicionar uma nova loja. 
    }
}
