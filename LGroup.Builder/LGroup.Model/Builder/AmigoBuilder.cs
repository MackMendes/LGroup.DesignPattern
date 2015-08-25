using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LGroup.Model.Builder
{
    // Sempre que quisermos montar uma clsse de pokinho em pokinho, setar os campos de pouco em pouco, utilizar o padrão BUILDER.
    // Ele nos auxilia a montar objetos complexos, etapas por etapa. Muito util em telas com Wizards (Assistentes), Abas ou até 
    // mesmo MODAIS. (Ex.: Carrinho de compras)
    public sealed class AmigoBuilder
    {
        // Criamos uma variavel apontando para a classe que vamos montrar, é um classe de BUILDER para uma classe de modelo.
        private AmigoModel _novoAmigo;

        public AmigoBuilder()
        {
            // Inicializamos as composições as sub-classes
            _novoAmigo = new AmigoModel();

            _novoAmigo.Fotos = new List<FotoModel>();
            _novoAmigo.Telefones = new List<TelefoneModel>();
        }

        // Implementação do Padrão BUILDER! 
        // Dividimos a construção da classe de modelo em etapas, assim os programadores vão passando os dados de pokinho em pokinho.
        public AmigoBuilder SetarDadosPrincipais(String nome_, String email_, String estado_)
        {
            _novoAmigo.Nome = nome_;
            _novoAmigo.Email = email_;
            _novoAmigo.Estado = estado_;

            return this;
        }

        // Segunda Etapa (Setamos os Telefones)

        public AmigoBuilder SetarTelefone(TelefoneModel telefone_)
        {
            _novoAmigo.Telefones.Add(telefone_);
            return this;
        }

        // Terceira Etapa (Setamos as Fotos)
        public AmigoBuilder SetarFoto(FotoModel foto_)
        {
            _novoAmigo.Fotos.Add(foto_);
            return this;
        }

        // Depois de montar todas as possiveis informações (propriedades) da classe de modelo de amigo, mandamos (retorna) ela MONTADA
        public AmigoModel Build()
        {
            return _novoAmigo;
        }
    }
}
