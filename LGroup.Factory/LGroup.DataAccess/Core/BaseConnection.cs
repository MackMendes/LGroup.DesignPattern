using System;
// Para poder visualizar o DataTable (Modelo Desconectado) e a inface IDbConnection (Modelo Conectado) importamos esssa namespace
using System.Data;

namespace LGroup.DataAccess.Core
{
    // Ainda nao chegamos no Factory! 
    // Essa classe vai ser a classe pai das classes de conexão. É ela que vai definir a família de conexão.
    // Todas as classes de conexão (SGBD) devem herdar desssa classe
    public abstract class BaseConnection
    {
        // Como não é abstrato não precisa ser implementada, desce automaticamente via herança
        public String ConectionString { get; set; }

        // A classe que fizer parte da família vai levar todos esses métodos e colocar a sua propria implementação.
        public abstract IDbConnection Conectar();

        public abstract void Desconectar();

        public abstract DataTable ExecutarComando(String query_);
    }
}
