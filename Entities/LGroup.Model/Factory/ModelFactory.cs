using System;
using System.Reflection;

namespace LGroup.Model.Factory
{

    // Criamos uma fábrica de inicialização de classes de modelos, todas elas vão ser instânciadas aqui da fábrica.
    public sealed class ModelFactory
    {
        // Como não vamos guardar nenhuma estado, por isso deixamos ela static
        // Quem for chamar o método de inicialização tem que passar para dentro dele uma classe de modelo, ele vai dar um NEW, setar os campos
        // administrativos e retornar um OBJETO daquela Classe
        // O WHERE é um constraint (restrição) um Bloqueio no código pros programadores não passarem nenhuma merda, nenhuma classe ou estrutura
        // inválida (que não tenha os campos) data e usuário. Bloqueamos pra aceitar somente classes que herdem de BaseModel.
        public static TModelo Inicializar<TModelo>() where TModelo : Core.BaseModel // Limitamos para que o Tipo Genêrico seja do tipo Core.BaseModel
        {
            // Via Reflection (reflexão) conseguimos em modo de execução descobrir todos os tipos de uma DLL:
            // INTERFACE, CLASSES, ESTRUTURAS, ENUMERAÇÕES
            // E os membros daquele tipo (Propriedade, métodos).
            // Como o construtor é internal, passamos o NonPublic e como é um método normal (instância) passamos o Instance.
            var modelo = (TModelo)Activator.CreateInstance(typeof(TModelo), BindingFlags.NonPublic | BindingFlags.Instance, null, null, null);

            // Após inicializar dinamicamente em modo de execução a classe que chegou via parametro de entrada (T), setamos as 
            // propriedades administrativas.

            modelo.GetType().GetProperty("DataCadastro").SetValue(modelo, DateTime.Now);

            // Environment: É uma classe do Framework que possui algumas propriedades do local onde a aplicação esta rodando.
            // Nesse caso: Environment.UserName, o nome do usuário que esta logado no Windows

            // Através dos metadados setamos as propriedades
            modelo.GetType().GetProperty("UsuarioLogado").SetValue(modelo, Environment.UserName);

            // Retornamos o objeto inicializado e devidamente preenchidos com os campos administrativos (rastreamento)
            return modelo;
        }
    }
}
