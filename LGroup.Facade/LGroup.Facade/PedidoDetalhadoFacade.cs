using LGroup.Business;
using LGroup.Helper;
using LGroup.Model;
using System;

namespace LGroup.Facade
{
    // Cada Padrão de Projeto, veio para resolver um determinado problema de código.
    // Problemas: 
    // 1) Vários Dependências na Aplicação Cliente
    // 2) Alta Complexidade de componentes e classe (Muitos News)
    // 3) Baixa Portabilidade
    // Solução: 
    // Utilizando o Padrão Facade (FACHADA), ele baixa as dependências da aplicação Cliente e deixa mais fácil o entendimento da aplicação, 
    // encapsulamos toda a lógica envolvida no fluxo de cadastro de pedidos dentro de um FACADE
    // UTILIZAÇÃO = 5
    
    public sealed class PedidoDetalhadoFacade
    {
        public void Validar(PedidoModel pedido_)
        {
            // Mandamos validar o pedidos em um componente de negócio
            var negocio = new PedidoBusiness(pedido_);
            negocio.ValidarCamposObrigatorios();
        }

        public void EnviarEmail(String para_, String corpo_, String assunto_)
        {
            // Enviamos um e-mail 
            EmailHelper.Enviar(para_, assunto_, corpo_);
        }

        public void GerarArquivo(String texto_)
        {
            // Geramos um arquivo de LOG
            // Geramos o LOG MIGUÉ
            ArquivoHelper.Gerar(texto_);
        }
    }
}
