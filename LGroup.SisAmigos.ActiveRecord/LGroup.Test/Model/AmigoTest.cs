using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NUnit.Framework;
using LGroup.Model;

namespace LGroup.Test.Model
{
    [TestFixture]
    public sealed class AmigoTest
    {
        [Test]
        public void Testar_Cadastro_Amigo()
        {
            var novoAmigo = new AmigoModel();
            
            novoAmigo.Nome = "Amigo 22:12";
            novoAmigo.Email = "amigo22@ig.com.br";
            novoAmigo.CodigoSexo = 2;
            novoAmigo.DataNascimento = new DateTime(1988, 11, 03);

            // O que caracteriza o padrão é não ter parametros de entrada e método.
            // A variável já é o proprio registro (Insert = Dado(INFORMAÇÃO)), na mesma classe temos armazenamento de informações e acesso a dados
            novoAmigo.Add();
        }

        [Test]
        public void Testar_Exclusao_Amigo()
        {
            var amigoExcluido = new AmigoModel();
            amigoExcluido.Codigo = 1;
            amigoExcluido.Remove();
        }
    }
}
