using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using LGroup.Model;
using LGroup.Model.DTO;
using LGroup.Global;
using LGroup.Service.Contract;

// Todos as classes que nos auxiliam a monitorar e diagnosticar o nosso código descem dessa namespace
using System.Diagnostics;
using LGroup.Global.Enum;

namespace LGroup.Service.Implementation
{
    public sealed class ClienteService : IClienteService
    {
        // Criamos uma variavel de retornao de informações de Serviço.
        private ResponseDTO<ClienteModel> _resposta;

        // Essa classe que faz o monitoramento por tempo (cronometro)
        private Stopwatch _cronometro;

        public ClienteService()
        {
            // Inicializamos o Response
            _resposta = new ResponseDTO<ClienteModel>();
            // Inicializamos o cronometro
            _cronometro = new Stopwatch();
        }

        public ResponseDTO<ClienteModel> Cadastrar(RequestDTO<ClienteModel> pedido_)
        {
            // Assim que entrou no serviço já setamos os campos administrativos (rastreamento)
            _resposta.DataExecucao = DateTime.Now;

            // Começou a monitorar, contrar o tempo
            _cronometro.Start();

            if (pedido_.NovoCliente == null)
            {
                _resposta.MensagemProcessamento = "Cliente Vazio";
                _resposta.TipoMensagem = TipoMensagem.Aviso;

                _cronometro.Stop();
                _resposta.TempoExecucao = _cronometro.Elapsed;

                return _resposta;
            }

            if (String.IsNullOrEmpty(pedido_.NovoCliente.Nome))
            {
                _resposta.MensagemProcessamento = "Informe o Nome";
                _resposta.TipoMensagem = TipoMensagem.Aviso;

                _cronometro.Stop();
                _resposta.TempoExecucao = _cronometro.Elapsed;

                return _resposta;
            }

            // Desligou o cronometro (parou de contar)
            _cronometro.Stop();
            // Pegando o tempo de monitoramento, pelo atributo Elapsed;
            _resposta.TempoExecucao = _cronometro.Elapsed;

            _resposta.MensagemProcessamento = "Cadastro com Sucesso";
            _resposta.TipoMensagem = TipoMensagem.Sucesso;

            return _resposta;
        }

        public ResponseDTO<ClienteModel> Listar(RequestDTO<ClienteModel> pedido_)
        {
            // Simulamos uma lista de registros
            _resposta.DataExecucao = DateTime.Now;
            _cronometro.Start();

            _resposta.ListModel = new List<ClienteModel>
            {
                new ClienteModel { Codigo = 1, Nome = "Zina", Email = "Zinamen" },
                new ClienteModel { Codigo = 2, Nome = "RachaCuca", Email = "RachaCucamen" }
            };

            _cronometro.Stop();
            _resposta.TempoExecucao = _cronometro.Elapsed;
            _resposta.MensagemProcessamento = "Clientes Recuperados com sucesso";
            _resposta.TipoMensagem = TipoMensagem.Sucesso;

            return _resposta;
        }
    }
}
