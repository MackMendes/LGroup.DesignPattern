using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using LGroup.DataAccess.Contracts;
using LGroup.Model;

namespace LGroup.DataAccess
{
    public sealed class AmigoDataAccessFake : IAmigoDataAccessObject
    {
        // O bom de utilizar a inversão de controle é que a qualquer momento podemos injetar qualquer outra classe
        // que venha da mesma familia, que tenha o mesmo pai. 
        // A classe original está com problemas ou não esta no TFS, subimos uma classe Duble (Fake), para ser utilizada até que 
        // a classe original fique normal, disponível.

        public void Cadastrar(Model.AmigoModel modelo_)
        {
            throw new NotImplementedException();
        }

        public void Atualizar(Model.AmigoModel modelo_)
        {
            throw new NotImplementedException();
        }

        public void Deletar(int codigo_)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Model.AmigoModel> Listar()
        {
            return new List<AmigoModel>
            {
                new AmigoModel { Nome = "Nome 01", Email = "email01@gmai.com"},
                new AmigoModel { Nome = "Nome 02", Email = "email02@gmai.com"}
            };
        }

        public Model.AmigoModel Consultar(int codigo_)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Model.AmigoModel> Pesquisar(System.Linq.Expressions.Expression<Func<Model.AmigoModel, bool>> expressao_)
        {
            throw new NotImplementedException();
        }
    }
}
