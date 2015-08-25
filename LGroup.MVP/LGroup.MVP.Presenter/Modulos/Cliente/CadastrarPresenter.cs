using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LGroup.MVP.Model;
using LGroup.MVP.View.Modulos.Cliente;

namespace LGroup.MVP.Presenter.Modulos.Cliente
{
    // A grosso modo, o Presenter equivaleria a um CONTROLLER, não a parte de navegação ROTAS mas, sim a parte de negocio.
    // UI -> PRESENTER - VIEW (Interface)
    //       PRESENTER - UI
    // UI -> <VIEW (Interface)> <- PRESENTER
    public sealed class CadastrarPresenter
    {
        private readonly ICadastrarView _view;

        // Quando a a TELA(ASPX) der um NEW no PRESENTER, ela vai mandar uma referencia da VIEW (Interface), o "meio campo" na comunição.
        public CadastrarPresenter(ICadastrarView view_)
        {
            this._view = view_;
        }

        // Como temos dois botões, para cada botão vamos cria um método
        public void Cadastrar()
        {

        }

        public void Limpar()
        {
            // É gambiarra acessar os campos da tela diretamente do presenter porque, teriamos que pegar a biblioteca do System.Web. 
            // Tudo tem que ser feito através da VIEW.
            _view.Nome = string.Empty;
            _view.Email = string.Empty;
            _view.Telefone = string.Empty;
        }
    }
}
