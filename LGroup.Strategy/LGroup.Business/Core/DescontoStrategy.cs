using LGroup.Strategy;
using System;

namespace LGroup.Business.Core
{
    public sealed class DescontoStrategy
    {
        private readonly IDescontoStrategy _desconto;

        public DescontoStrategy(IDescontoStrategy desconto_)
        {
            this._desconto = desconto_;
        }

        public Decimal ObterDesconto(Decimal valorAtual_)
        {
            return this._desconto.AplicarDesconto(valorAtual_);
        }
    }
}
