using LGroup.DataAccess.Contracts;
using LGroup.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

namespace LGroup.DataAccess
{
    // Implementação do padrão DAO(Acesso a dados), o beneficio de criar familias (Contratos) é que a qualquer momento podemos 
    // passar outra classe (classe irmã) no local dessa classe.
    public sealed class AmigoDataAccessObject : IAmigoDataAccessObject
    {
        private readonly Conexao _conexao;

        public AmigoDataAccessObject(Conexao conexao_)
        {
            _conexao = conexao_;
        }

        public void Cadastrar(AmigoModel modelo_)
        {
            // INSERT INTO
            _conexao.Amigos.Add(modelo_);
            // Comentado abaixo porque começamos a utilizar o UnitOfWork
            //_conexao.SaveChanges();
        }

        public void Atualizar(AmigoModel modelo_)
        {
            // UPDATE TABLE
            _conexao.Entry(modelo_).State = EntityState.Modified;
            _conexao.SaveChanges();
        }

        public void Deletar(Int32 codigo_)
        {
            // DELETE
            // Find: Ele antes de ir no banco de dados, ele primeiro procura ele no Cache ele. Por isso ele é performatico.
            var amigo = _conexao.Amigos.Find(codigo_);
            _conexao.Amigos.Remove(amigo);
            _conexao.SaveChanges();
        }

        public IEnumerable<AmigoModel> Listar()
        {
            return _conexao.Amigos.ToList();
        }

        public AmigoModel Consultar(int codigo_)
        {
            // Find: Ele antes de ir no banco de dados, ele primeiro procura ele no Cache ele. Por isso ele é performatico.
           return _conexao.Amigos.Find(codigo_);
        }

        public IEnumerable<AmigoModel> Pesquisar(Expression<Func<Model.AmigoModel, Boolean>> expressao_)
        {
            return _conexao.Amigos.Where(expressao_).ToList();
        }
    }
}
