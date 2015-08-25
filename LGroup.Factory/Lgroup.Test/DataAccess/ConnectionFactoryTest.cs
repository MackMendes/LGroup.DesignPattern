// Subimos para memória a DLL de acesso a dados
using LGroup.DataAccess;
using LGroup.Global;
using NUnit.Framework;

namespace LGroup.Test.DataAccess
{
    [TestFixture]
    public sealed class ConnectionFactoryTest
    {
        #warning Voltar e fazer o exemplo de Factory com Reflexão

        // Code Refactoring é a tecnica de melhorar o código, visando boas práticas, padrões de projetos, performace, Nomenclaturas e principios de código.
        // Static = Como a classe de fábrica não guarda estado (guarda algum objeto), a única finalidade dela é inicilizar outras classes (Colocamos como static)
        // NUMB MAGIC (Número Magicos): Numeros não simbolizam nada nem lembrando ninguém, deixando o código confuso... por isso, vamos criar um ENUM
        // CLASSES DA FAMÍLIA DE CONEXÃO COM CONSTRUTOR INTERNAL: Tomar cuidado caso você utilize o padrão factory e não coloque internal no construtor das 
        // classes, os programadores podem burlar a Factory, podem dar NEW nessas classes diretamente da aplicação cliente.
        // CODE SMELLS (Sintomas de Código Meu Feito) : Código FEDIDO
        [Test]
        public void Testar_Factory_Com_Branco_Sql()
        {
            // Acionamos a classe de construção de conexões e recebemos uma conexão com o SQL Server 
            var conexaoSql = ConnectionFactory.Inicializar(ServidorGlobalEnum.SqlServer, "Data Source=localhost;Initial Catalog=PADROES;Integrated Security=True");

            conexaoSql.Conectar();
            var registros = conexaoSql.ExecutarComando("SELECT * FROM TB_CLIENTE;");
            conexaoSql.Desconectar();
        }

        [Test]
        public void Testar_Factory_Com_Branco_Oracle()
        {
            // Acionamos a classe de construção de conexões e recebemos uma conexão com o SQL Server 
            var conexaoSql = ConnectionFactory.Inicializar(ServidorGlobalEnum.Oracle, "");

            conexaoSql.Conectar();
            var registros = conexaoSql.ExecutarComando("SELECT * FROM TB_CLIENTE;");
            conexaoSql.Desconectar();
        }

        [Test]
        public void Testar_Factory_Com_Branco_MySql()
        {
            // Acionamos a classe de construção de conexões e recebemos uma conexão com o SQL Server 
            var conexaoSql = ConnectionFactory.Inicializar(ServidorGlobalEnum.MySql, "");

            conexaoSql.Conectar();
            var registros = conexaoSql.ExecutarComando("SELECT * FROM TB_CLIENTE;");
            conexaoSql.Desconectar();
        }
    }
}
