using LGroup.Model;
using LGroup.UnitOfWork;
using System.Web.Mvc;

namespace LGroup.Uow.Controllers
{
    public class AmigoController : Controller
    {
        private readonly AmigoUnitOfWork _unidadeAmigo;

        public AmigoController(AmigoUnitOfWork unidadeAmigo_)
        {
            this._unidadeAmigo = unidadeAmigo_;
        }

        public ActionResult Listar()
        {
            //Todas as camadas de manipulação de dados foram agrupadas dentro da UOW (Unit Of Work)
            var amigos = _unidadeAmigo.AmigoDAO.Listar();
            var sexos = _unidadeAmigo.SexoDAO.Listar();

            return View(amigos);
        }

        public ActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Cadastrar(AmigoModel amigoModel)
        {
            _unidadeAmigo.AmigoDAO.Cadastrar(amigoModel);
            _unidadeAmigo.Confirmar();

            var amigos = _unidadeAmigo.AmigoDAO.Listar();

            return RedirectToAction("Listar");
        }
    }
}