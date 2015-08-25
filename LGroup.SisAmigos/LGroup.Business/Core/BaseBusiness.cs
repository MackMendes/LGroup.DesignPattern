using System;
using System.Collections.Generic;

namespace LGroup.Business.Core
{
    // O Padrão TEMPLATE METHOD é um padrão GOF (3/5)
    // A idéia do Padrão é definir uma sequência (FLUXO) de comandos que serão executadas (1,2,3,4) (a,b,c,d) um passo a passo para uma determinada
    // finalidade (Cadastro, Exportação de Arquivos) com ele conseguimos OBRIGAR os programadores a SEMPRE chamarem os comandos naquela ordem, 
    // não tem como fugir! Ao mesmo tempo vai ficar FLEXIVEL pra que ele coloque os códigos que ele quiser dentro do métodos.
    // OBS.: Não pode ser interface, tem que ser classe abstrata
    public abstract class BaseBusiness
    {
        #region Event Error

        // Criamos uma variável para armazenar as mensages de erro (validação dos campos)
        protected List<String> _erros = new List<String>();

        // Eventos são muito mais do que CLICK, LOAD, MOUSE OVER!
        // Eventos são notificações, são avisos que mandamos para classes clientes, classe que derem o NEW.

        // ACTION é um delegate que obrigado o programador a criar um método VOID (Sintonizar essa mensagem), com uma List<String> como parâmetro de entrada
        // Ex.: private void Capturar(List<String> erros_);
        public event Action<List<String>> EnviarErros;

        #endregion

        // Quem for herdar vai colocar a sua propria LOGICA de validação e de cadastro, é a parte Flexivel.
        protected abstract Boolean ValidarCamposObrigatorios();

        // Poderiamos deixar essa classe como Internal também!
        protected abstract void Cadastrar();

        // Esse é o TEMPLATE METHOD! Foi que aki que padronizamos a execução do Algoritmo (métodos).
        // Não importa a classe que Business que o programador deu NEW, sempre vai chamar o EXECUTAR (Método) e ele acina os outros 2 métodos.
        public void Executar()
        {
            // Esses comandos são os da classe filha
            // SexoBusiness, AmigoBusiness
            // Essa é a definição do fluxo do algoritmo (código) se esta tudo certo, aciona o cadastrar. Se tem algum 
            // campo em branco aciona o evento pra despachar os erros
            if (this.ValidarCamposObrigatorios())
                this.Cadastrar();
            else
                this.EnviarErros(_erros);
        }
    }
}
