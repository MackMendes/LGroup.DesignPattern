using System;

namespace LGroup.Model
{
    public sealed class ItemPedidoModel : Core.BaseModel
    {
        public Int32 Quantidade { get; set; }

        // Da mesma forma que as tabelas se relacionam montamos um relacionamento entre as classes (Classe conversando com Classe)
        public PedidoModel Pedido { get; set; }

        public ProdutoModel Produto { get; set; }

    }
}
