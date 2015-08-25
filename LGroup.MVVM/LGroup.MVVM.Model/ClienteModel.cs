using System;

// Subimos para memoria a namespace que possui comando que vão nos auxiliar a enviar sinais la View.
using System.ComponentModel;

namespace LGroup.MVVM.Model
{
    // Interface que manda NOTIFICAÇÕES
    public sealed class ClienteModel : INotifyPropertyChanged
    {
        // Propriedade que veio da Interface para mandar notificações.
        public event PropertyChangedEventHandler PropertyChanged;

        private string _nome;

        public string Nome
        {
            get { return _nome; }
            set
            {
                // Assim que o campo nome foi alterado lá na VIEW MODEL, entrou aqui dentro do SET.
                // Enviamos um sinal (Notificação) la pra VIEW avisando para vir buscar novamente o conteúdo do campo NOME.
                _nome = value;

                PropertyChanged(this, new PropertyChangedEventArgs("Nome"));
            }
        }

        private string _email;

        public string Email
        {
            get { return _email; }
            set
            {
                _email = value;

                PropertyChanged(this, new PropertyChangedEventArgs("Email"));
            }
        }

        private DateTime? _dataNascimento;

        public DateTime? DataNascimento
        {
            get { return _dataNascimento; }
            set
            {
                _dataNascimento = value;

                PropertyChanged(this, new PropertyChangedEventArgs("DataNascimento"));
            }
        }

    }
}
