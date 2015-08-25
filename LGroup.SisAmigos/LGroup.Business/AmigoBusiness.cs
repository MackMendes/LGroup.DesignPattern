// Subimos a DLL de acesso a banco de dados (DAO)
using LGroup.DataAccess;
using LGroup.Model;
using System;
using System.Linq;

namespace LGroup.Business
{
    public sealed class AmigoBusiness : Core.BaseBusiness
    {
        private readonly AmigoModel _modelo;
        private readonly AmigoDataAccessObject _dados = new AmigoDataAccessObject();

        public AmigoBusiness(AmigoModel modelo_)
        {
            this._modelo = modelo_;
        }

        protected override bool ValidarCamposObrigatorios()
        {
            if (String.IsNullOrWhiteSpace(_modelo.Nome))
                base._erros.Add("O Campo Nome é Obrigatório.");

            if (String.IsNullOrWhiteSpace(_modelo.Email))
                base._erros.Add("O Campo E-mail é Obrigatório.");

            if (DateTime.MinValue.Equals(_modelo.DataNascimento))
                base._erros.Add("O Campo Data de Nascimento é Obrigatório.");

            if (_modelo.CodigoSexo == 0)
                base._erros.Add("O Campo Sexo é Obrigatório.");

            return !_erros.Any();
        }

        protected override void Cadastrar()
        {
            _dados.Cadastrar(_modelo);
        }
    }
}
