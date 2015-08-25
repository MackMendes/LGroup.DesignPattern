using System;

namespace LGroup.Model
{
    // Refatoramos o projeto de Modelos, todo que estava em comum entre todas as Classes levamos para um Super Tipo (Classe)
    public sealed class ProdutoModel : Core.BaseModel
    {
        public String Nome { get; set; }

        public String Descricao { get; set; }

        public Decimal Valor { get; set; }

        public Boolean Status { get; set; }
    }
}
