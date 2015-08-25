using System;
using System.Data;

namespace LGroup.DataAccess.Base
{
    public sealed class OracleConnection : Core.BaseConnection
    {
        internal OracleConnection()
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
