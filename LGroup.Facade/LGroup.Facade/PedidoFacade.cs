using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LGroup.Business;
using LGroup.Helper;
using LGroup.Model;

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
    
    public sealed class PedidoFacade
    {
        public void InicializarPedido(PedidoModel pedido_)
        {
            // Mandamos validar o pedidos em um componente de negócio
            var negocio = new PedidoBusiness(pedido_);
            negocio.ValidarCamposObrigatorios();

            // Enviamos um e-mail e geramos um arquivo de LOG
            EmailHelper.Enviar(pedido_.Cliente.Email, "Seu Pedido foi Cadastrado", "Parabéns você comprou conosco...TEST ROX no curso de Padrão de Projetos.");

            // Geramos o LOG MIGUÉ
            ArquivoHelper.Gerar("Mais 1 pedido foi para conta");
        }
    }
}
