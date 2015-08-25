using System;
using System.Collections.Generic;

namespace LGroup.Model
{
    // Aplicamos o herança, chamamos o SUPER TYPE
    public sealed class AmigoModel : Core.BaseModel
    {
        public String Nome { get; set; }

        public String Email { get; set; }

        public String Telefone { get; set; }

        public Int32 CodigoSexo { get; set; }

        public Int32 CodigoEstadoCivil { get; set; }

        // FOREIGN KEYS (Composições)
        private SexoModel _sexo;
        public SexoModel Sexo
        {
            get
            {
                // LAZY LOADING
                if (_sexo == null)
                    _sexo = new SexoModel // Neste momento, você iria fazer a busca no banco e fazer o necessário
                    {
                        Codigo = 1,
                        Descricao = "Feminino"
                    };

                return _sexo;
            }
            set
            {
                _sexo = value;
            }
        }

        private EstadoCivilModel _civil;
        public EstadoCivilModel Civil
        {
            get
            {
                // LAZY LOADING
                if (_civil == null)
                    _civil = new EstadoCivilModel
                    {
                        Codigo = 2,
                        Descricao = "Casado(a)"
                    };

                return _civil;

            }
            set
            {
                _civil = value;
            }
        }

        // Criamos dois métodos para simular o padrão LAZY LOADING.
        // Quando falamos de carregamento (SELECT, Bucar dados), podemos fazer dois tipos de carregamentos
        // EAGER LOADING (CARREGAMENTO ANTECIPADO)
        // Trazemos tudo de uma única vez, mesmo sem precisar. Pedido (Clientes, Itens Pedido, Produto)

        // LAZY LOADING (CARREGAMENTO TARDIO)
        // Trazemos de pokinho e pokinho, conforme a necessidade. 
        // 1) Pedidos, 
        // 2) Clientes, 
        // 3) Produtos

        public IList<AmigoModel> ListarEagerLoading()
        {
            var amigos = new List<AmigoModel>();
            for (int i = 1; i <= 10; i++)
            {
                var novoAmigo = new AmigoModel();
                novoAmigo.Codigo = i;
                novoAmigo.Nome = "Nome " + i;
                novoAmigo.Email = "email" + i + "@teste.com";
                novoAmigo.CodigoSexo = 1;
                novoAmigo.CodigoEstadoCivil = 2;

                // EAGER LOADING (Trouzemos tudo junto)
                novoAmigo.Sexo = new SexoModel { Codigo = 1, Descricao = "Feminino", DataCadastro = DateTime.Now };

                novoAmigo.Civil = new EstadoCivilModel { Codigo = 1, Descricao = "Casado(a)", DataCadastro = DateTime.Now };
                amigos.Add(novoAmigo);
            }

            return amigos;
        }

        // Padrão LAZY LOADING, só levamos os dados quando realmente formos precisar (Tela, Relatorio)
        public IList<AmigoModel> ListarLazyLoading()
        {
            var amigos = new List<AmigoModel>();
            for (int i = 1; i <= 10; i++)
            {
                var novoAmigo = new AmigoModel();
                novoAmigo.Codigo = i;
                novoAmigo.Nome = "Nome " + i;
                novoAmigo.Email = "email" + i + "@teste.com";
                novoAmigo.CodigoSexo = 1;
                novoAmigo.CodigoEstadoCivil = 2;

                amigos.Add(novoAmigo);
            }

            return amigos;

        }

    }
}
