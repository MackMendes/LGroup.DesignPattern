using System;
using System.Data;
// Apelidando o SqlClient
using SQL = System.Data.SqlClient;

namespace LGroup.DataAccess.Base
{
    // O Padrão Factory tem utilização 5 (1 à 5), muito utilizado!
    // A idéia do Factory é montar uma fábrica de geração de classes, criaremos familias de classes (Conexao, Produtos, Promoções)
    // A Factory é quem vai dar NEW nas classes, o programador não vai da mais NEW.
    public sealed class SqlConnection : Core.BaseConnection
    {
        private SQL.SqlConnection _conexao = new SQL.SqlConnection();

        // Deixamos internal só é possível INSTÂNCIAR essa classe neste Projeto
        // Se colocasse na classe, ela não poderia ser vista e nenhum lugar!
        internal SqlConnection()
        {

        }

        public override IDbConnection Conectar()
        {
            _conexao.ConnectionString = base.ConectionString;
            _conexao.Open();
            return _conexao;
        }

        public override void Desconectar()
        {
            _conexao.Close();
            _conexao.Dispose();
        }

        public override DataTable ExecutarComando(string query_)
        {
            var comando = new SQL.SqlCommand();
            comando.Connection = _conexao;
            comando.CommandType = CommandType.Text;
            comando.CommandText = query_;

            var dataTable = new DataTable();
            var adaptador = new SQL.SqlDataAdapter(comando);
            adaptador.Fill(dataTable);

            return dataTable;
        }
    }
}
