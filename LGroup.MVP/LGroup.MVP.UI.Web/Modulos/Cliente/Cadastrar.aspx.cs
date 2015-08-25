using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

// Subimos para memoria as interfaces que vão pegar e levar os dados para tela.
using LGroup.MVP.View.Modulos.Cliente;

// Subimos para a memoria as classes que possuem a inteligencia de carregamento e exibição de dados para tela.
using LGroup.MVP.Presenter.Modulos.Cliente;

namespace LGroup.MVP.UI.Web.Modulos.Cliente
{
    public partial class Cadastrar : System.Web.UI.Page, ICadastrarView
    {
        // A tela tem que herdar da View, fazendo uma compatação com ASP.Net MVC, dividimos a VIEW em dois (Apresentação e View = Manipulação de campos)
        #region Fields (interface)

        public string Nome
        {
            get
            {
                return txtNome.Text.Trim();
            }
            set
            {
                txtNome.Text = value.Trim();
            }
        }

        public string Email
        {
            get
            {
                return txtEmail.Text.Trim();
            }
            set
            {
                txtEmail.Text = value.Trim();
            }
        }

        public string Telefone
        {
            get
            {
                return txtTelefone.Text.Trim();
            }
            set
            {
                txtTelefone.Text = value.Trim();
            }
        }

        #endregion

        // Crimao uma variável para acionar o PRESENTER(Métodos), a programação da tela.
        #region Variável Global

        private CadastrarPresenter _preseter;

        #endregion

        protected void Page_Load(object sender, EventArgs e)
        {
            // Inicializamos o PRESENTER passando uma referencia para tela que esta aberta (cadastrar) = ICadastrarView
            _preseter = new CadastrarPresenter(this);
        }

        protected void btnLimpar_Click(object sender, EventArgs e)
        {
            // Os métodos não podem ter parametros de entrada! Tudo que vai e volta tem que ser por intermedio de propriedades que estão dentro da VIEW.
            _preseter.Limpar();
        }

        protected void btnCadastrar_Click(object sender, EventArgs e)
        {
            _preseter.Cadastrar();
        }


    }
}