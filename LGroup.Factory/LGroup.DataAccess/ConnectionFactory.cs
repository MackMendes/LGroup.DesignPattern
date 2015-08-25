using LGroup.DataAccess.Base;
using LGroup.DataAccess.Core;
using LGroup.Global;
using System;

namespace LGroup.DataAccess
{
    // Aqui esta o Padrão de Projeto! Essa classe que vai inicilizar e setar as configurações de uma determinda família.
    // No nosso casso, a família de Conexão
    public sealed class ConnectionFactory
    {
        // Retornamos uma classe (Pai da Familia) para poder deixar flexivel, assim conseguimos. 
        // Retornar qualquer classe que herda do PAI
        public static BaseConnection Inicializar(ServidorGlobalEnum sgbd_, String stringConection_)
        {
            BaseConnection conexao;

            // De acordo com o número, desce uma classe de conexão. Implementação Default do Factory
            if (sgbd_ == ServidorGlobalEnum.SqlServer)
                conexao = new SqlConnection();
            else if (sgbd_ == ServidorGlobalEnum.Oracle)
                conexao = new OracleConnection();
            else
                conexao = new MySqlConnection();

            // Beneficios da Factory
            // 1) Local centralizado de inicializações
            // 2) Execução de configurações padrões
            conexao.ConectionString = stringConection_;

            return conexao;
        }
    }
}
