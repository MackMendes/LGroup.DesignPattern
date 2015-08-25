using System;
using System.Collections.Generic;

// Para receber uma expressão como parâmetro de entrada, 
// Importamos essa namespace para habilitar a classe Expression
using System.Linq.Expressions;

namespace LGroup.DataAccess.Contracts.Core
{
    public interface IPesquisa<TModelo>
    {
        // Para não ficar criando vários PESQUISAR:
        // Nome, Código, Cep, Periodo inicial e FINAL
        // Criamos 1 único pesquisar ele vai receber 1, expressão lambda como parametro de entrada

        // Expression -> Para receber a Lambda (x => x);
        // Func -> Delegate é onde informamos a classe que vai subir no Intellisense (os campos dela);
        // Boolean -> É o retorno, se encontrou é True;
        // Se não encontrou é FALSE
        // Ex.: Pesquisar(x => x.Nome == "Zina")
        IEnumerable<TModelo> Pesquisar(Expression<Func<TModelo, Boolean>> expressao_);
    }
}
