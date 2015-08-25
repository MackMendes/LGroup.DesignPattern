using System;

namespace LGroup.DataAccess.Contracts.Core
{
    // Para ficar bem abstraido (desmembrado) separamos em 2 tipos de comandos (LEITURA e GRAVAÇÃO).
    // Estamos flexibilizando a interface, ficou genérica
    public interface IGravacao<TModelo>
    {
        void Cadastrar(TModelo modelo_);

        void Atualizar(TModelo modelo_);

        void Deletar(Int32 codigo_);
    }
}
