using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using LGroup.Model;
using LGroup.Business;

namespace LGroup.Test.Business
{
    [TestFixture]
    public sealed class BusinessTest
    {
        [TestFixtureSetUp]
        public void Inicialize()
        {

        }

        [Test]
        public void Testar_Classe_Negocio_Amigo_Sucesso()
        {
            // A classe que armazenamos os dados (da página)
            var dadosTela = new AmigoModel
            {
                Nome = "Amigo 01",
                Email = "amigo01@gmail.com",
                DataNascimento = DateTime.Now,
                CodigoSexo = 2
            };

            // A classe de negócio (TM)
            // O único comando da classe que pode ser publico, é o TEMPLATE METHOD (Etapas) todos os outros tem que ser protegidos só serão visiveis dentro
            // da classe filha, da classe que herdou!
            var negocio = new AmigoBusiness(dadosTela);
            negocio.Executar();
        }

        [Test]
        public void Testar_Classe_Negocio_Amigo_Erro()
        {
            var erros = new List<String>();

            // A classe que armazenamos os dados (da página)
            var dadosTela = new AmigoModel
            {
                Nome = "Amigo 01"
            };

            // A classe de negócio (TM)
            // O único comando da classe que pode ser publico, é o TEMPLATE METHOD (Etapas) todos os outros tem que ser protegidos só serão visiveis dentro
            // da classe filha, da classe que herdou!
            var negocio = new AmigoBusiness(dadosTela);
            
            // Sempre que você disparar um evento, obrigatoriamente tem que interceptar (Monitorar), escutar ele! Se não capturar da pau de NULL REFERENCE.

            // Criamos um metodo anonimo (INLINE) para receber as mensagens de erro daquele eveto.
            // => Expressão lambda é o corpo do método

            // "+=" é igual a capturar o evento escutado.
            // "=>" é igual a Executar
            // "{}" é o corpo do método (inline)
            
            // É um ponteiro do memória
            negocio.EnviarErros += (listaErros) => {
                erros = listaErros;
            }; 
            
            negocio.Executar();

            Assert.AreNotEqual(0, erros.Count);
        }

    }
}
