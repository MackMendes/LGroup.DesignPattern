using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Subimos para memoria as interfaces (contratos)
using LGroup.Service.Contract;

// Subimos para a memoria as unidades (classes = serviços)
using LGroup.Service.Implementation;

// Todas as classes que nos auxiliam a fazer o HOSTING, a hospedar e leventar o serviço por algum protocolo descem
using System.ServiceModel;

// Para subir as classeq para expor os metadados, usar essa namespace.
using System.ServiceModel.Description;

namespace LGroup.Server
{
    // Esse ConsoleApp é para subir o Serviço, Self-Host.
    class Program
    {
        static void Main(string[] args)
        {
            // Podemos subir um serviço WCF de três formas: 
            // IIS
            // WAS (Complemento (TCP, MSMQ))
            // SELF HOSTING (Você cria uma aplicação para subir o serviço (Console, Windows Forms, WSF))

            // Abaixo estamos criando uma URL, passando a porta e caminho.
            var url = new Uri("http://localhost:6969/Cliente");

            // Com WCF, criamos um servidor pra subir o serviço.
            // Falou de serviço é a Classe.
            // Falou de contrato é a Interface.
            var servidor = new ServiceHost(typeof(ClienteService), url);

            // Amarramos a interface do servço em um protocolo, no caso HTTP
            servidor.AddServiceEndpoint(typeof(IClienteService), new WSHttpBinding(), string.Empty);

            // Além de falar o protocolo e a forma de comunicação, temos que habilitar a exposição (acesso) aos metadados para que outras 
            // aplicações saibam tudo que tem ai dentro.
            servidor.Description
                .Behaviors
                .Add(new ServiceMetadataBehavior
                {
                    HttpGetEnabled = true
                });

            // Nesse momento ligamos o servidor, ONLINE.
            servidor.Open();

            Console.ReadKey();
        }
    }
}
