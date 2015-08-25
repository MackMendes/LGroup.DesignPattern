using LGroup.Global.Enum;
using System;
using System.Collections.Generic;

namespace LGroup.Model.DTO
{
    public sealed class ResponseDTO<TModel>
    {
        public DateTime DataExecucao { get; set; }

        public TimeSpan TempoExecucao { get; set; }

        public String MensagemProcessamento { get; set; }

        public TipoMensagem TipoMensagem { get; set; }

        public IEnumerable<TModel> ListModel { get; set; }
    }
}
