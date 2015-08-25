using LGroup.Model;
using LGroup.Strategy;
using System;

namespace LGroup.Business
{
    public sealed class MercadoLivreBusiness : IValidacaoStrategy
    {
        public void ValidarCamposObrigatorios(ClienteModel cliente_)
        {
            // Nome e Telefonr são obrigatórios
            if (String.IsNullOrWhiteSpace(cliente_.Telefone))
                throw new ApplicationException("Preencha o Telefone.");

            if(String.IsNullOrWhiteSpace(cliente_.Nome))
                throw new ApplicationException("Preencha o Nome.");
        }
    }
}
