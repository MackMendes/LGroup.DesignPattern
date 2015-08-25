
namespace LGroup.Model.DTO
{
    // REQUEST é a classe que VEM (Entra)
    // RESPONSE é classe que vai (VOLTA)
    // São classes de transferencia de dados, padrão de Projeto chamada de Data Transfer Object.
    // Armazenamento de dados no proprio projeto (SLN) Model. 
    // Armazenamento de dados que vão ser transferidas via SVC, DTO.
    public sealed class RequestDTO<TModel>
    {
        public TModel NovoCliente { get; set; }

        public string UsuarioLogado { get; set; }

    }
}
