using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

// Temos que 
using LGroup.MVP.Presenter.Modulos.Cliente;
using LGroup.MVP.Model;
using LGroup.MVP.View.Modulos.Cliente;

namespace LGroup.MVP.UI.Web.Modulos.Cliente
{
    public partial class Listar : System.Web.UI.Page, IListarView
    {
        public IList<ClienteModel> ListarClientes
        {
            get
            {
                return grvClientes.DataSource as IList<ClienteModel>;
            }
            set
            {
                grvClientes.DataSource = value;
                grvClientes.DataBind();
            }
        }

        private ListarPresenter _presenter;

        protected void Page_Load(object sender, EventArgs e)
        {
            _presenter = new ListarPresenter(this);
        }

        protected void btnCarregar_Click(object sender, EventArgs e)
        {
            _presenter.Carregar();
        }

    }
}