﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Capitulo1.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Capitulo1.Controllers
{
    public class InstituicaoController : Controller
    {
        private static IList<Instituicao> instituicoes =
            new List<Instituicao>()
            {
                new Instituicao() {
                    InstituicaoID = 1,
                    Nome = "UniParaná",
                    Endereco = "Paraná"
            },
                new Instituicao() {
                    InstituicaoID = 2,
                    Nome = "UniSanta",
                    Endereco = "Santa Catarina"
                },
                new Instituicao() {
                    InstituicaoID = 3,
                    Nome = "UniSãoPaulo",
                    Endereco = "São Paulo"
                },
                new Instituicao() {
                    InstituicaoID = 4,
                    Nome = "UniSulgrandense",
                    Endereco = "Rio Grande do Sul"
                },
                new Instituicao() {
                    InstituicaoID = 5,
                    Nome = "UniCarioca",
                    Endereco = "Rio de Janeiro"
                }
            };
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View(instituicoes);
        }

        // GET: Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create (Instituicao instituicao)
        {
            instituicoes.Add(instituicao);
            instituicao.InstituicaoID = instituicoes.Select(i => i.InstituicaoID).Max() + 1;
            return RedirectToAction("Index"); 

        }

    }
}
