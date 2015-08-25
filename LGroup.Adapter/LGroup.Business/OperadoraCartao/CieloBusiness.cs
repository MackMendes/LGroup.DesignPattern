using LGroup.Model;
using System;

namespace LGroup.Business.OperadoraCartao
{
    public sealed class CieloBusiness : Core.IOperadoraPagamentoBusiness
    {
        public void Pagar(PagamentoModel pagamento_)
        {
            if (pagamento_.Senha == String.Empty)
                throw new ApplicationException("Senha em Branco");

            // Implementar acesso ao banco para Salvar os dados do pagamento
        }
    }
}
