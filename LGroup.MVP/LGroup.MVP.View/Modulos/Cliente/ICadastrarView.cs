using System;

namespace LGroup.MVP.View.Modulos.Cliente
{
    public interface ICadastrarView
    {
        // txtNome
        String Nome { get; set; }

        // txtEmail
        String Email { get; set; }

        // txtTelefone
        String Telefone { get; set; }
    }
}
