using System;

// Subimos input
using System.Windows.Input;

namespace LGroup.MVVM.ViewModel.Eventos
{
    // Essa classe vai ser responsável por redirecionar as propriedade para os metódos (DE > PARA)
    public sealed class DispararComando: ICommand
    {
        private readonly Action _metodo;

        // Essa classe executa métodos (comandos), quem for da um NEW manda o endereço de memoria de METODO.
        public DispararComando(Action metodo_)
        {
            this._metodo = metodo_;
        }

        // Para habilitar ou desabilitar os botões. 
        // Se retorna true, fica habilitado.
        // Se retorna false, fica desabilitados
        public bool CanExecute(object parameter)
        {
            return true;
        }

        public event EventHandler CanExecuteChanged;

        // É aqui dentro do EXECUTE que ele vai rodar o método de LIMPAR ou o método de CADASTRAR, temos que fazer de forma
        // generica, flexivel para não ficar HARD CORD (CHUMBADO)
        public void Execute(object parameter)
        {
            // Disparamos o método que chegou injetado no construtor. Ele chegou como um DELEGATE (Action)
            // Ao disparar um delegate ou colocar da forma abaixo:
            //_metodo.Invoke();
            // Ou colocar desta forma:
            _metodo();
        }
    }
}
