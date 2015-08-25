using System;

namespace LGroup.Model
{
    // Criamos um componente (DLL) corporativa pra armazenamento de dados dentro das aplicações UI (Mobile, Web, Windows) ou Service
    // Modificador de acesso Padrão é Internal
    public sealed class ClienteModel : Core.BaseModel
    {
        internal ClienteModel()
        {

        }

        public String Nome { get; set; }

        public String Email { get; set; }

        public String Telefone { get; set; }

        public DateTime DataNascimento { get; set; }

    }
}
