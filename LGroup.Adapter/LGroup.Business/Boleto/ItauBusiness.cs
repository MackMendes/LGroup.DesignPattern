using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LGroup.Model;

namespace LGroup.Business.Boleto
{
    public sealed class ItauBusiness : Core.IBoletoBusiness
    {
        public void Emitir(BoletoModel boleto_)
        {
            // Ifs Migues, só para justificar o padrão (secundário)
            if (boleto_.Valor >= 3000M)
                throw new ApplicationException("Valor Excedido");
        }
    }
}
