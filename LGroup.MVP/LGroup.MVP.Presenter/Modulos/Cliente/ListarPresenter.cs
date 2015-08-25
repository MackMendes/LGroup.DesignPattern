//Subimos para a memoria a DLL de geração de massa de dados de registros MIGUE (FAKES)
using FizzWare.NBuilder;
using LGroup.MVP.Model;
using LGroup.MVP.View.Modulos.Cliente;

namespace LGroup.MVP.Presenter.Modulos.Cliente
{
    public sealed class ListarPresenter
    {
        private readonly IListarView _view;

        public ListarPresenter(IListarView view_)
        {
            this._view = view_;
        }

        public void Carregar()
        {
            // Simulamos uma carga no Grid. Descemos dados VIEW dentro da propriedade.
            // Se utilizamos o banco: Presenter -> DAO ou ACTIVE RECORD

            // Através do NBUILDER conseguimos simular uma massa de dados.
            // Para não ficar dando FOR, montamos uma lista de registros com o NBuilder.
            // 1ª Forma:
            this._view.ListarClientes = Builder<ClienteModel>.CreateListOfSize(100).Build();

            // 2ª Forma:
            // Desta forma, alterações a forma da construção dos Dados Fakes.
            this._view.ListarClientes = Builder<ClienteModel>.CreateListOfSize(100)
                .All()
                    .TheFirst(10)  // 10 primeiros registros
                        .With(x => x.Nome = "Xumaker")  // Com o nome igual Xumaker
                            .And(x => x.Email = "xumaker@ig.com.br") // E Email igual xumaker@ig.com.br
                    .TheNext(80)
                        .With(x => x.Nome = "Madruga")
                            .And(x => x.Email = "madruguinha@gmail.com")
                    .TheLast(10)
                        .With(x => x.Nome = "Chaves")
                            .And(x => x.Email = "chavinho@gmail.com")
                .Build();
        }
    }
}
