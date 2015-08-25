using LGroup.MVVM.Model;
using LGroup.MVVM.ViewModel.Eventos;
using System;
// Para poder sincronizar o click dos botões la da tela, aqui pro ViewModel, temos que utilizar a interface ICOMMAND
using System.Windows.Input;

namespace LGroup.MVVM.ViewModel.Modulos.Cliente
{
    // Esse padrão MVVM foi criado exclusivamente para tecnologias baseadas em XAML (WPF, XBAP, SILVERLIGHT, WINDOWS STORE)
    // Começou aqui na Microsoft e foi expandindo (JS = Knockout)
    // Os dados vão ir e vir da tela através de BINDINGS, vinculação de dados (Se não tem Binding é MVC, se tem Bindings é MVVM)

    // Cada tela vai sincronizar com uma VIEW MODEL
    public sealed class CadastrarViewModel
    {
        public CadastrarViewModel()
        {
            // Configuramos para redirecionar os comandos sempre que pressionar algum botão lá na VIEW, vai disparar o ICOMMAND aqui no VIEWMODEL.
            // Disparou o ICOMMAND redirecionamos para o método
            ClickLimpar = new DispararComando(Limpar);
            ClickCadastrar = new DispararComando(Cadastrar);
            
            // Inicializamos o MODEL
            this.Cliente = new ClienteModel();
        }

        // Tudo que ficará disponível para a View (UI) consumir, são propriedades.

        // 1º)
        // Para trazer dados de campos, temos que fazer BINDINGS
        // Para trazer eventos (Click de Botão) utilizar COMMANDS.
        public ClienteModel Cliente { get; set; }
        
        // 2º)
        // Só da para fazer BINDINGS em propriedades em métodos não funciona (para eventos utilizar ICOMMAND)
        public ICommand ClickLimpar { get; set; }

        public ICommand ClickCadastrar { get; set; }

        // 3º)
        // Quando as propriedades foram acionadas ao clicar no botões, vamos mandar redicionar para os métodos abaixo.
        private void Limpar()
        {
            // No WPF, as telas são ATIVAS! Elas vão atras dos dados (BINDINGS). No MVC, Windows Forms, Web Forms, são passivos porque sempre recebe os dados.
            // Sempre que você alterar um campo no VIEW MODEL, tem que mandar uma notificação lá pra TELA para ele venha buscar denovo.
            this.Cliente.Nome = string.Empty;
            this.Cliente.Email = string.Empty;
            this.Cliente.DataNascimento = default(DateTime?);
        }

        private void Cadastrar()
        {
            // Cadastrar aki, pegando a propriedade Cliente e faz o trampo!
        }
    }
}
