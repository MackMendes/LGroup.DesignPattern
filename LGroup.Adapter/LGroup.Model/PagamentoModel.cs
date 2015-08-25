using System;

namespace LGroup.Model
{
    // Estamos projetados um novo adaptador para resolver problemas de incompatibilidade em integrações de pagamentos:
    // RedeCard, Visa, PagueSeguro
    public sealed class PagamentoModel
    {
        public Decimal Valor { get; set; }

        public String Senha { get; set; }
    }
}
