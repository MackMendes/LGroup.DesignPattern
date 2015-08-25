using System;

namespace LGroup.Model
{
    public sealed class AmigoModel : Core.BaseModel
    {
        public String Nome { get; set; }

        public String Email { get; set; }

        public DateTime DataNascimento { get; set; }

        public Int32 CodigoSexo { get; set; }

        // Da mesma forma que as tabelas se conversam com as classe, tem que se conversar pra poder montar um relacionamento
        // Composição (classe apontando para classe) = FK

        public SexoModel Sexo { get; set; }
    }
}
