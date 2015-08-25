using LGroup.Strategy;

namespace LGroup.Business
{
    public sealed class BlackFridayBusiness : IDescontoStrategy
    {
        public decimal AplicarDesconto(decimal preco_)
        {
            var novoValor = (preco_ / 2) + (preco_ - 10);
            return novoValor;
        }
    }
}
