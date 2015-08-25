using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using LGroup.Model;
using LGroup.Model.Builder;

namespace LGroup.TestBuilder.Model
{
    [TestFixture]
    public sealed class AmigoBuilderTest
    {
        [Test]
        public void Testar_Builder_Metodo_A_Metodo()
        {
            var builder = new AmigoBuilder();
            
            // WEB (1ª Aba)
            builder.SetarDadosPrincipais("Zina", "Zinamen@ig.com", "SP");

            // WEB (2ª Aba)
            builder.SetarTelefone(new TelefoneModel()
            {
                DDD = "11",
                Numero = "5698-5842"
            });

            builder.SetarTelefone(new TelefoneModel()
            {
                DDD = "11",
                Numero = "99999-9999"
            });

            // WEB (3ª Aba)
            builder.SetarFoto(new FotoModel()
            {
                Nome = "Eu.png",
                Pasta = @"c:\MinhasFotos\"
            });

            // Após montar TODO o objeto de AMIGO capturamos ele. Retornamos uma referencia do objeto construido.
            // Do objeto que montamos etapa 
            var amigo = builder.Build();

            Assert.AreEqual(typeof(AmigoModel), amigo.GetType());
            Assert.AreEqual(2, amigo.Telefones.Count());
        }

        [Test]
        public void Testar_Builder_Metodos_Tudo_Junto()
        {
            // Uma segunda forma de chamar o padrão BUILDER
            // Monta tudo em um mesmo linha de código através de métodos diferentes

            var amigo = new AmigoBuilder()
                .SetarDadosPrincipais("Zina", "zinamen@hotmail.com", "SP")
                .SetarFoto(new FotoModel { Nome = "Foto.png" })
                .SetarTelefone(new TelefoneModel { DDD = "", Numero = "5955-8842" })
                .Build();


        }
    }
}
