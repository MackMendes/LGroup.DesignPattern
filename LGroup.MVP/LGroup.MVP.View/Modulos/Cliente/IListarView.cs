using LGroup.MVP.Model;
using System.Collections.Generic;

namespace LGroup.MVP.View.Modulos.Cliente
{
    // Para tecnologias LEGADAS (Windows Form, Asp.Net Web Forms, Delphi, VB6) utilizar esse padrão MVP (Model View Presenter)
    // A idéia dele é desacoplar a tela dos CAMPOS da TELA. Para cadas TELA (Apresentação) cria uma VIEW (Interface), e cada campo da tela cria 
    // uma propriedade.
    public interface IListarView
    {
        // IList<> => Leitura e Gravação
        // IEnumerable<> => Somente Leitura

        //Sempre que na tela tiver um DropDownList, ListBox ou um GridView, campos que poassuem mais de uma opção.
        IList<ClienteModel> ListarClientes { get; set; }
    }
}
