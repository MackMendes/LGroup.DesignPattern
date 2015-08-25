using LGroup.Model;
using System;
using System.Linq;

namespace LGroup.Business
{
    public sealed class SexoBusiness : Core.BaseBusiness
    {
        private readonly SexoModel _modelo;

        // Quem for dar um NEW passa dados que vão vir da tela e serão validados e cadastrados
        public SexoBusiness(SexoModel modelo_)
        {
            this._modelo = modelo_;
        }

        protected override bool ValidarCamposObrigatorios()
        {
            // Cada campo que veio da tela e não foi devidamente preenchido, vamos armazenar uma mensagem (texto) dentro de uma coleção
            if (String.IsNullOrWhiteSpace(_modelo.Decricao))
                base._erros.Add("O Campo Descrição é Obrigatório.");

            // COUNT -> Menos Performatic conta do 1 ao último
            // ANY -> Mais Performatico (SELECT Exists)
            // Assim que ele encontrou 1 registros ele ja para de verificar os itens
            
            return !_erros.Any();
        }

        protected override void Cadastrar()
        {
            throw new NotImplementedException();
        }
    }
}
