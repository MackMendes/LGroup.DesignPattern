using System;
using System.Data;

namespace LGroup.DataAccess.Base
{
    public sealed class MySqlConnection : Core.BaseConnection
    {
        internal MySqlConnection()
        {

        }

        public override IDbConnection Conectar()
        {
            throw new NotImplementedException();
        }

        public override void Desconectar()
        {
            throw new NotImplementedException();
        }

        public override DataTable ExecutarComando(string query_)
        {
            throw new NotImplementedException();
        }
    }
}
