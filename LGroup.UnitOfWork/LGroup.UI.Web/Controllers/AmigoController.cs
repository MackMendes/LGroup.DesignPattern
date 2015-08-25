using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using LGroup.Model;
using LGroup.DataAccess;
using LGroup.DataAccess.Contracts;

namespace LGroup.UI.Web.Controllers
{
    public class AmigoController : Controller
    {
        // Para aplicar o padrão IoC vamos utilizar a tecnica de DI (Injeção de Dependência)
        // Uma classe que vem antes do Controller, vai ser responsável por inicilizar todas as dependencias do Controller pra baixo.


        // 1º) Fazendo por classe, o Ninject consegue resolver as instâncias sem problemas! Sem precisar de fazer o De/Para
        //private readonly AmigoDataAccessObject _dadosAmigos;

        //public AmigoController(AmigoDataAccessObject dadosAmigos_)
        //{
        //    _dadosAmigos = dadosAmigos_;
        //}

        private readonly IAmigoDataAccessObject _dadosAmigos;

        // Colocar a interface (reutilizavel) sempre colocar a interface (LAYER SUPER TYPE) o pai das classes. Assim podemos passar qualquer 
        // classe que venha daquela Interface.
        public AmigoController(IAmigoDataAccessObject dadosAmigos_)
        {
            _dadosAmigos = dadosAmigos_;
        }

        //"ListarSemIoC"
        public ActionResult Listar()
        {
            // Exemplo de inicialização de objetos sem IoC, sem Inversão de Controle, uma classe é responsável por inicilizar 
            // suas dependências suas sub classes.

            var dadosAmigo = new AmigoDataAccessObject(new Conexao());
            var amigos = dadosAmigo.Listar();

            return View(amigos);
        }

        public ActionResult ListarComIoC()
        {
            // O Padrão Inversão de Controle (IoC), nos auxiliam a diminiuir o acoplamento, a forte dependencia entre uma classe 
            // e suas sub classes (Objetos) temos que inverter o controle e criar um modelo de Inicialização de objetos (Dependencias)
            var amigos = _dadosAmigos.Listar();
            return View(amigos);
        }
    }
}