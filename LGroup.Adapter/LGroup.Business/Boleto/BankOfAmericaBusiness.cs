// Subimos a DLL de terceira de geração, emissão de boletos, pro banco Bank Of America.
using BankOfAmerica;
using LGroup.Model;
using System;

namespace LGroup.Business.Boleto
{
    // Como as classes que esta vindo da DLL de terceiro (BankOfAmerica), são totalmente incompativeis com as nossas classes de boleto pois, 
    // vem de familias diferentes, temos que dar um jeito de intergar esses boleto dentro do nosso ecossistema.

    // Essa classe é a classe do Adaptadro. 
    // Ele que vai acionar a classe de um outro componente de uma outra familia (Composição)
    public sealed class BankOfAmericaBusiness : Core.IBoletoBusiness
    {
        // BOA (Bank Of America), isso é a aplicação do Adaptador (Composição)
        private Billet _boleto;

        public BankOfAmericaBusiness()
        {
            _boleto = new Billet();
        }

        public void Emitir(BoletoModel boleto_)
        {
            if(boleto_.Cedente == String.Empty)
                throw new ApplicationException("Informe o Cedente");

            // Fizemos a chamada a integração para um componente, clsse TEICEIRO (de outra familia), garantimos a compatibilidade do código
            _boleto.Send(boleto_.Valor, boleto_.DataEmissao);
        }
    }
}
