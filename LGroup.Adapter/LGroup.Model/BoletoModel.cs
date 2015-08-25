using System;

namespace LGroup.Model
{
    // Através do Adaptador conseguimos adaptar classes de familias diferentes (super tipos), classes Incompatíveis
    // 
    public sealed class BoletoModel
    {
        public Int32 Codigo { get; set; }

        public Decimal Valor { get; set; }

        public String Cedente { get; set; }

        public DateTime DataEmissao { get; set; }
    }
}
