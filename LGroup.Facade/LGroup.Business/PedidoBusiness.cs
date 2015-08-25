using LGroup.Model;  // Subimos para a memória a DLL de armazenamentos de dados
using System;

namespace LGroup.Business
{
    // Classes seladas (fechadas) são acessadas mais rapidas pela CLR
    public sealed class PedidoBusiness
    {
        private PedidoModel _pedido;

        public PedidoBusiness(PedidoModel pedido_) // pedido com anderline (_) no fim da variavel, serveria para variaveis de parâmetro
        {
            _pedido = pedido_;
        }

        public void ValidarCamposObrigatorios()
        {
            if (_pedido.ItensPedido.Count == 0)
                throw new ApplicationException("Coloque Produtos");

            if (_pedido.Cliente.Nome == string.Empty)
                throw new ApplicationException("Informe o Nome do Cliente");
        }
    }
}
