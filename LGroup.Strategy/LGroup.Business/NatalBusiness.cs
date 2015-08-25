using LGroup.Strategy;

namespace LGroup.Business
{
    public sealed class NatalBusiness : IDescontoStrategy
    {
        public decimal AplicarDesconto(decimal preco_)
        {
            var novoValor = preco_ - 50;
            return novoValor;
        }
    }
}
