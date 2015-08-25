using System;

namespace LGroup.Model
{
    public sealed class ClienteModel
    {
        public int Codigo { get; set; }

        public String Nome { get; set; }

        public String Email { get; set; }

        public DateTime DataNascimento { get; set; }
    }
}
