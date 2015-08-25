using System;

namespace LGroup.Model
{
    public class AmigoModel : Core.BaseModel 
    {
        public String Nome { get; set; }

        public String Email { get; set; }

        public DateTime DataNascimento { get; set; }

        public Int32 CodigoSexo { get; set; }

        // Da mesma forma que as tabelas se conversam com as classe, tem que se conversar pra poder montar um relacionamento
        // Composição (classe apontando para classe) = FK

        // A forma mais fácil de fazer um INNER JOIN pelo Entity Framework, é colocar VIRTUAL na PROPRIEDADE ele internamente. 
        // Já faz o INNER JOIN sozinho (no automatico) EAGER LOADING pelo Entity Framework.
        public virtual SexoModel Sexo { get; set; }
    }
}
