using exemploMVC02.Models;
using exemploMVC02.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace exemploMVC02.Controllers
{
    public class RecrutadoraController : Controller
    {
        // GET: Recrutadora
        public ActionResult Index()
        {
            List<Recrutadora> recrutadoras = new RecrutadoraRepositorio().obterTodos();
            ViewBag.Recrutadoras = recrutadoras;
            return View();
        }
        public ActionResult Cadastro()
        {
            return View();
        }
        public ActionResult Editar(int id)
        {

            Recrutadora recrutadora = new RecrutadoraRepositorio().ObterPeloId(id);
            ViewBag.Recrutadora = recrutadora;
            return View();
        }

        public ActionResult Excluir(int id)
        {
           bool apagado = new RecrutadoraRepositorio().Excuir(id);
           return null;
        }

        public ActionResult Store(Recrutadora recrutadora)
        {
            int identificador = new RecrutadoraRepositorio().Cadastrar(recrutadora);
            return RedirectToAction("Editar", new { id = identificador});
        }

        public ActionResult Update(Recrutadora recrutadora)
        {
            bool alterado = new RecrutadoraRepositorio().Alterar(recrutadora);
            return null;
        }
    }
}