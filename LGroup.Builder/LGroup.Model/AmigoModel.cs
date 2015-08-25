using System;
using System.Collections.Generic;

namespace LGroup.Model
{
    public sealed class AmigoModel
    {
        public Int32 Codigo { get; set; }

        // Informações principais
        public String Nome { get; set; }

        public String Email { get; set; }

        public String Estado { get; set; }

        // Informações Complementares
        public ICollection<FotoModel> Fotos { get; set; }

        public ICollection<TelefoneModel> Telefones { get; set; }

    }
}
