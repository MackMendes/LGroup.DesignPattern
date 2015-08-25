using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using LGroup.DataAccess;
using LGroup.DataAccess.Contracts;
using LGroup.Model;
using System.Diagnostics;

namespace LGroup.UnitOfWork
{
    // A unidade de trabalho (Unit Of Work (UOW)) é um padrão do MARTIN FOWLER, serve para criar fluxos de acesso
    // a tabelas e gerenciar conexões e transações. A grosso modo, parece uma FACADE para banco. 
    // Todos as DAO ou REPOSITORY vão rolar dentro de um UOW mesma conexão e transação
    public sealed class AmigoUnitOfWork
    {
        private readonly Conexao _conexao;
        private readonly IAmigoDataAccessObject _dadosAmigo;
        private readonly ISexoDataAccessObject _dadosSexo;

        public AmigoUnitOfWork(Conexao conexao_, IAmigoDataAccessObject dadoAmigo_, ISexoDataAccessObject dadoSexo_)
        {
            this._conexao = conexao_;
            this._dadosAmigo = dadoAmigo_;
            this._dadosSexo = dadoSexo_;

            conexao_.Database.Log = (comandos) => Debug.WriteLine(comandos);
        }

        // Todoas as chamadas para REPOSITORIOS ou DAO's, ficam encapsuladas.
        // Elas são servidas através da UOW (Unit Of Work)
        public IAmigoDataAccessObject AmigoDAO
        {
            get
            {
                return _dadosAmigo;
            }
        }

        public ISexoDataAccessObject SexoDAO
        {
            get
            {
                return _dadosSexo;
            }
        }

        // Nesse métodos salvariamos no banco todas as alterações feitas nas classes de acesso a dados acima.
        public void Confirmar()
        {
            _conexao.SaveChanges();
        }

    }
}
