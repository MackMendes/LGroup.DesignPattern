// 1- DLL de Validações, consistencia e regras de Negocio
using LGroup.Business;
// 1- DLL de Classes Utilitarias (Helpers)
using LGroup.Helper;
// 1- DLL de Armazenamento de Dados
using LGroup.Model;


// 2 - Subimos a DLL responsável por facilitar as chamadas os fluxos
using LGroup.Facade;

using NUnit.Framework;
using System;
using System.Collections.Generic;

// Para não ficar tendo que criar Telinhas FAKES, vamos sempre testar as camadas e a aplicação dos padrões
// Via projeto de Testes, baixamos o NUnit o Framework de teste mais utilizado no mundo... vindo do Java

// *****************************
// Para o Visual Studio poder reconhecer o NUnit como framework de testes, tivemos que baixar o pacote UNit Test Adapter!!!
// *****************************
namespace LGroup.Facade.Test.Business
{
    // Transformamos a nossa classe, em uma classe de teste (em um robo de teste), através da Anotação TestFixture
    // NUnit
    [TestFixture]
    public sealed class PedidoTest
    {
        PedidoModel _pedido;

        [SetUp]
        public void Inicializar()
        {
            _pedido = new PedidoModel();
            _pedido.Codigo = 1;
            _pedido.ValorTotal = 300.40M;
            _pedido.QuantidadeItens = 2;
            _pedido.Cliente = new ClienteModel()
            {
                Codigo = 1,
                Nome = "Charles",
                Email = "charlesmendes_31@hotmail.com",
                DataNascimento = Convert.ToDateTime("03-11-1988")
            };

            _pedido.ItensPedido = new List<ItemPedidoModel>()
            {
                new ItemPedidoModel() { 
                    Codigo = 1, 
                    Quantidade = 1, 
                    Produto = new ProdutoModel()
                    {
                        Nome = "Axe Anjos"
                    },
                },
                new ItemPedidoModel() { 
                    Codigo = 2, 
                    Quantidade = 50, 
                    Produto = new ProdutoModel()
                    {
                        Nome = "TV 3D de 46"
                    },
                }
            };
 
        }

        // Transformos esse comando em uma operação de teste
        // REQUISITO:
        // 1) Cadastrar pedidos
        // 2) Validar Alguns dados
        // 3) Gravar um Arquivo de Log
        // 4) Enviar um E-mail
        [Test]
        public void Testar_Fluxo_Pedido_SEM_Facade()
        {
            // Mandamos validar o pedidos em um componente de negócio
            var negocio = new PedidoBusiness(_pedido);
            negocio.ValidarCamposObrigatorios();

            // Enviamos um e-mail e geramos um arquivo de LOG
            EmailHelper.Enviar(_pedido.Cliente.Email, "Seu Pedido foi Cadastrado", "Parabéns você comprou conosco...TEST ROX no curso de Padrão de Projetos.");

            // Geramos o LOG MIGUÉ
            ArquivoHelper.Gerar("Mais 1 pedido foi para conta");
        }

        [Test]
        public void Testar_Fluxo_Pedido_COM_Facade()
        {
            // Ascionamos o FACADE e passamos 1 única informação
            var facadePedido = new PedidoFacade();
            facadePedido.InicializarPedido(_pedido);

            //#warning Voltar aqui e ver a segunda forma de FACADE
        }

        [Test]
        public void Testar_Fluxo_Pedido_COM_Facade_Detalhado()
        {
            // Acionamos o FACADE em diversas momentos, fizemos vários chamadinhas. 
            // Uma chamada não ficou dependendo da outra! Fizemos três etapas distintas (antes era tudo 1 só)
            var facadeDetalhadoPedido = new PedidoDetalhadoFacade();

            facadeDetalhadoPedido.Validar(_pedido);

            // Enviamos um e-mail
            facadeDetalhadoPedido.EnviarEmail(_pedido.Cliente.Email, "Corpo do email", "Assunto do email");

            facadeDetalhadoPedido.GerarArquivo("Texto do Arquivo");
        }
    }
}
