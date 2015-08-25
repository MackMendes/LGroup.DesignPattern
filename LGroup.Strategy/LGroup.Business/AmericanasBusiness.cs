using LGroup.Model;
using LGroup.Strategy;
using System;

namespace LGroup.Business
{
    public sealed class AmericanasBusiness : IValidacaoStrategy
    {
        public void ValidarCamposObrigatorios(ClienteModel cliente_)
        {
            if (String.IsNullOrWhiteSpace(cliente_.Nome))
                throw new ApplicationException("Preencha o Nome.");
            
            // Subtramos a data corrente da data de nascimento, pegamos a quantidade de dias.
            var idade = (DateTime.Now.Subtract(cliente_.DataNascimento).Days / 365);

            if(idade < 18)
                throw new ApplicationException("Você é de menor!");
        }
    }
}
