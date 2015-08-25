using LGroup.Model;
using LGroup.Model.DTO;
//  Para poder criar um serviço, subimos para memoria a DLL com comandos WCF.
using System.ServiceModel;

namespace LGroup.Service.Contract
{
    // Falamos que a nossa interface vai ser visivel por algum protocolo (HTTP, MSMQ, TCP, IPC (UDP)), ela é do WCF.
    [ServiceContract]
    public interface IClienteService
    {
        // Tem um padrão utilizado para criação de serviço, é o padrão PEDIDO-RESPOSTA (Request, Response).
        // Tudo que formos enviar pro serviço tem que ir dentro de uma classe de PEDIDO.
        // Tudo que for descer do serviço tem que vir dentro de uma classe de RESPOSTA.
        [OperationContract]
        ResponseDTO<ClienteModel> Cadastrar(RequestDTO<ClienteModel> pedido_);

        // Pros métodos do serviço ficarem visiveis nas APP clientes, temos que colocar as anotações (atributo) abaixo.
        [OperationContract]
        ResponseDTO<ClienteModel> Listar(RequestDTO<ClienteModel> pedido_);


        // Forma natural de fazer sem utilizar padrão Nenhum. 
        //void Cadastrar(ClienteModel cliente_);
        //IEnumerable<ClienteModel> Listar();
    }
}
