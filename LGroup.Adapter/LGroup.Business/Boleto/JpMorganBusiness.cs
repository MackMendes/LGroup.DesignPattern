using JpMorgan;
using LGroup.Model;
using System;

namespace LGroup.Business.Boleto
{
    public sealed class JpMorganBusiness : Core.IBoletoBusiness
    {
        // Composição TUDO FAZ parte do Adaptador
        private Billet _boleto;

        public JpMorganBusiness()
        {
            _boleto = new Billet();
        }

        public void Emitir(BoletoModel boleto_)
        {
            if (boleto_.DataEmissao >= DateTime.Now)
                throw new ApplicationException("Data Inválida");

            _boleto.Transmit(boleto_.Valor, boleto_.DataEmissao, boleto_.Codigo);
        }
    }
}
