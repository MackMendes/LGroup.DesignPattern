using LGroup.DataAccess.Contracts.Core;
using LGroup.Model;

namespace LGroup.DataAccess.Contracts
{
    // DAL é um nome arquitetural! Significa camada (DLL) de acesso a dados, e não é um padrão! Apenas um nome de mercado.
    // Existem varios padrões de acesso a dados: 
    // Repository, Data Access Object (DAO), Active Record, Unit Of Work
    // As classe DAO tem que herder das INTERFACES DAO.
    public interface IAmigoDataAccessObject : IGravacao<AmigoModel>, ILeitura<AmigoModel>, IPesquisa<AmigoModel>
    {
    }
}
