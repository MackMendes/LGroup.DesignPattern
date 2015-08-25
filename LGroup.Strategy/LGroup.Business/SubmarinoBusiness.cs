using System;
// Subimos o armazenamento de DADOS.
using LGroup.Model;

// Subimos a dll onde definimos a estratégia de validação
using LGroup.Strategy;

namespace LGroup.Business
{
    //  : IValidacaoStrategy -> Foi nesse momento que aplicamos a estratégia.
    // Quando for cliente do submarino temos que validar determinados campos.
    public sealed class SubmarinoBusiness : IValidacaoStrategy
    {
        public void ValidarCamposObrigatorios(ClienteModel cliente_)
        {
            // Nome e Email são obrigatórios
            if (String.IsNullOrWhiteSpace(cliente_.Nome))
                throw new ApplicationException("Preencha o Nome");

            if( String.IsNullOrWhiteSpace(cliente_.Email))
                throw new ApplicationException("Preencha o E-mail");
        }
    }
}
