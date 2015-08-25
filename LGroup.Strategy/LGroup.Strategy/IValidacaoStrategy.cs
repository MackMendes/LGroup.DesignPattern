
// Subimos na memório a DLL de armazenamento de DADOS
using LGroup.Model;

namespace LGroup.Strategy
{
    //O Padrão Strategy nos auxilia a deixar nossos componentes flexiveis. Criamos família de classes que possuem um mesmo SUPER TIPO.
    // Com esse padrão diminuimos os IF's, as ENUMERAÇÕES, CASE's. 
    // E o nosso código fica mais desacoplado (Não ficamos reféns de mudanças no código)
    public interface IValidacaoStrategy
    {
        // As classes de negócio vão implementar essa estratégia de validação. E lá dentro das classes de negócio, vamos definir os campos que devem ser validados.
        // SUBMARINO -> Nome e Email
        // MERCADOLIVRE -> Não poder ser menor que 18
        // AMERICANAS -> Nome, Email e Telefone
        void ValidarCamposObrigatorios(ClienteModel cliente_);
    }
}
