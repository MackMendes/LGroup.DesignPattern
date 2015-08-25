using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Subimos para a memoria a namespace do PROXY (Referencia pra um DLL remota)
// O proprio VS se encarregou de montar o proxy (add service reference)

using LGroup.RequestResponse.Client;

namespace LGroup.RequestResponse.Client
{
    class Program
    {
        // Para acessar um serviço (DLL Remota), criamos um PROXY (Add Service Reference). 
        // A programação esta local, só que o processamento esta na nuvem, em máquina remota SOA (Arquitetura Orientada a Serviços).
        // Conceito Computação Distribuída. RPC (Remote Procedure Call) acionamento de comandos remotos.

        // Proxy -> Referencia para um serviço (ASMX, SVC)

        static void Main(string[] args)
        {
            // Criamos uma  variavel apontando pro serviço Classe Remota.
            // Da mesma forma que la no EntityFramework, a classe se chama Entities, aqui no serviço a classe que aponta pro Serviço (WCF)
            // sempre termina com ServiceClint.
            
            // 1ª) Forma para consumir, simples e para teste.
            //var servico = new ProxyCliente.ClienteServiceClient();
            //var resposta = servico.Listar(new ProxyCliente.RequestDTOOfClienteModelXEcaxEXn());

            //Sempre dar um new no serviço com USING, assim após o uso ele libera recursos da maquina (com GC).
            // Memoria Ram, Processaro (Nucleos e Threads), HD, Arquivos
            using (var servico = new ProxyCliente.ClienteServiceClient())
            {
                var pedido = new ProxyCliente.RequestDTOOfClienteModelXEcaxEXn();
                    
                pedido.NovoCliente =  new ProxyCliente.ClienteModel
                {
                    //Nome = "Zina2",
                    Email = "Zinamen2",
                    DataNascimento = DateTime.Now
                };
                pedido.UsuarioLogado = Environment.UserName;

                var resposta = servico.Cadastrar(pedido);

            }

            Console.ReadKey();
        }

        // Sempre que for SOAP tem que da ADD Service Reference (PROXY)
        // REST não é necessário.
    }
}
