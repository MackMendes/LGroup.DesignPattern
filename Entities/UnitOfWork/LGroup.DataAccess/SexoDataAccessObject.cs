using LGroup.DataAccess.Contracts;
using LGroup.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace LGroup.DataAccess
{
    // DAO -> CONTRATO -> PERMISSOES (LEITURA, GRAVAÇÃO E PESQUISA)
    public sealed class SexoDataAccessObject : ISexoDataAccessObject
    {
        // Criamos uma variável apontando para a classe de Conexão
        // Aki o DBContext não abriu ainda a conexão, só criou uma instância.
        private readonly Conexao _conexao;

        public SexoDataAccessObject(Conexao conexao_)
        {
            _conexao = conexao_;
        }

        public IEnumerable<SexoModel> Listar()
        {
            // Select * from TB_SEXO;
            // O ToList() que abre a conexão, e dispara a execução no banco.
            return _conexao.Sexos.ToList();
        }

        public SexoModel Consultar(Int32 codigo_)
        {
            return _conexao.Sexos.Find(codigo_);
        }

        public IEnumerable<SexoModel> Pesquisar(Expression<Func<SexoModel, Boolean>> expressao_)
        {
            return _conexao.Sexos.Where(expressao_).ToList();
        }
    }
}
