using LGroup.Model;
using System;
// Subimos para a mémoria uma nova forma de pagamento (Pague Seguro)
// O cara que vai ser adaptado (veio de fora)
using UOL;

namespace LGroup.Business.OperadoraCartao
{
    // Podemos implementar o Padrão Adapter, de duas formas.
    // 1) Composição (estado) variavel apontando para classe externa
    // 2) Herança, fica mais bunitinho de olhar, mais facil de chamar
   public sealed  class PagueSeguroBusiness : PagSeguro, Core.IOperadoraPagamentoBusiness
    {
        public void Pagar(PagamentoModel pagamento_)
        {
            if (pagamento_.Valor > 10000M)
                throw new ApplicationException("Valor acima do permitido.");
            
            // Essa classe de negocio é uma Adaptador, ela faz o DE/PARA dos dados. 
            // Ela adequa, faz a integração de classes incompativeis. O Debitar veio da classe pai, desceu via herança
            base.Debitar(pagamento_.Valor, pagamento_.Senha);
        }
    }
}
