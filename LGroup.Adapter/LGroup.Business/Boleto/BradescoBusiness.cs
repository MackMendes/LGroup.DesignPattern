using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LGroup.Model;

namespace LGroup.Business.Boleto
{
    // Criamos uma família de boletos
    public sealed class BradescoBusiness : Core.IBoletoBusiness
    {
        public void Emitir(BoletoModel boleto_)
        {
            // Ifs Migues, só para justificar o padrão (secundário)
            if (boleto_.Valor == 0M)
                throw new ApplicationException("Boleto Zerado");

            if(boleto_.DataEmissao > DateTime.Now)
                throw new ApplicationException("Boleto Vencido");
        }
    }
}
