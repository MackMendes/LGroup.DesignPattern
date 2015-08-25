using System;

namespace LGroup.Strategy
{
    public interface IDescontoStrategy
    {
        Decimal AplicarDesconto(Decimal preco_);
    }
}
