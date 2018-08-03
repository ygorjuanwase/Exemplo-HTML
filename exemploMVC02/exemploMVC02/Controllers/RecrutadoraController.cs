﻿using exemploMVC02.Models;
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
        public ActionResult Cadadstro()
        {
            return View();
        }
        public ActionResult Editar()
        {
            return View();
        }
    }
}