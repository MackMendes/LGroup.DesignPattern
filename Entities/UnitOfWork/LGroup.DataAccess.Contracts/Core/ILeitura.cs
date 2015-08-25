using System;
using System.Collections.Generic;

namespace LGroup.DataAccess.Contracts.Core
{
    public interface ILeitura<TModelo>
    {
        IEnumerable<TModelo> Listar();

        TModelo Consultar(Int32 codigo_);
    }
}
