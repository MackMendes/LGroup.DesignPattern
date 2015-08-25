// Subimos na mémoria
using LGroup.Model;

namespace LGroup.Business.Core
{
    public interface IBoletoBusiness
    {
        void Emitir(BoletoModel boleto_);
    }
}
