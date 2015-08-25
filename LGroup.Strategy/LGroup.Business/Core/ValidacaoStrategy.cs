using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Subimos o armazenamento de dados
using LGroup.Model;
// Subimos a definição da DLL que possui a 
using LGroup.Strategy;

namespace LGroup.Business.Core
{
    // Para implementar, CORRETAMENTE o padrão strategy, precisamos de uma INTERFACE (Estrategia).
    // E precisamos também de uma classe (receber e acionar). Uma determinada estratégia.
    // Na documentação UML (GOF) o nome é classe de contexto
    public sealed class ValidacaoStrategy
    {
        // Armazenamos numa variável local a estratégia que veio injetada (La do projeto de testes)
        // Armazenamos local para continuar visualizando a classe
        private readonly IValidacaoStrategy _estrategia;

        // Quando formos rodar uma determinada estratégia, temos que inicializar essa classe, passando para dentro dela a estratégia de validação (ML, SUB, AME).
        // Para ficar generico, flexivel, com um baixo acoplamento, temos que passar sempre a INTERFACE (Super Classe), pai daquela família.
        public ValidacaoStrategy(IValidacaoStrategy estrategia_)
        {
            this._estrategia = estrategia_;
        }

        // Criamos uma comando para receber os dados da Tela e iniciar a estratégia de validação
        public void IniciarEstrategia(ClienteModel cliente_)
        {
            // Chamamos o comando abaixo que é Flexivel
            this._estrategia.ValidarCamposObrigatorios(cliente_);
        }
    }
}
