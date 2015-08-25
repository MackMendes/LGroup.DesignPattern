using LGroup.DataAccess.Contracts.Core;
using LGroup.Model;

namespace LGroup.DataAccess.Contracts
{
    // Na tabela de sexos vamos ter comandos somente LEITURA, comandos que serão executadas em cima da classe SexoModel
    public interface ISexoDataAccessObject : ILeitura<SexoModel>, IPesquisa<SexoModel>
    {
    }
}
