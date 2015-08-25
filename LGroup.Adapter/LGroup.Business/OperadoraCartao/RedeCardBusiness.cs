using LGroup.Model;
using System;

namespace LGroup.Business.OperadoraCartao
{
    public sealed class RedeCardBusiness : Core.IOperadoraPagamentoBusiness
    {
        public void Pagar(PagamentoModel pagamento_)
        {
            if (pagamento_.Valor <= 10M)
                throw new ApplicationException("Pelo menos R$10,00");

            // Lógica
        }
    }
}
