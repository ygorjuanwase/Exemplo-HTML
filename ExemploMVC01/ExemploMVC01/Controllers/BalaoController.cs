using ExemploMVC01.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExemploMVC01.Controllers
{
    public class BalaoController : Controller
    {
        // GET: Balao
        public ActionResult Cadastro()
        {
            return View();
        }
        public ActionResult store(balao balao)
        {
            return View();

        }
    }
}