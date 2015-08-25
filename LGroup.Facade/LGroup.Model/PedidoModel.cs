using System;
using System.Collections.Generic;

namespace LGroup.Model
{
    public sealed class PedidoModel : Core.BaseModel
    {
        public Decimal ValorTotal  { get; set; }

        public Int32 QuantidadeItens { get; set; }

        public ClienteModel Cliente { get; set; }

        // Uma implementação mais leve do IList (IList herda de ICollection)
        public ICollection<ItemPedidoModel> ItensPedido { get; set; }
    }
}
