using Fiap.Correcao.Nac.Models;
using Fiap.Correcao.Nac.Units;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fiap.Correcao.Nac.Controllers
{
    public class AvaliacaoController : Controller
    {
        private UnitOfWork _unit = new UnitOfWork();

        public ActionResult Listar()
        {
            var lista = _unit.AvaliacaoRepository.Listar();
            return View(lista);
        }

        [HttpGet]
        public ActionResult Cadastrar()
        {
            var lista = _unit.DisciplinaRepository.Listar();
            ViewBag.opcoes =
                new SelectList(lista,"DisciplinaId","Nome");
            return View();
        }

        [HttpPost]
        public ActionResult Cadastrar(Avaliacao avaliacao)
        {
            if (ModelState.IsValid)
            {
                _unit.AvaliacaoRepository.Cadastrar(avaliacao);
                _unit.Salvar();
                TempData["msg"] = "Cadastrado!";
                return RedirectToAction("Cadastrar");
            }
            return View();
        } 
    }
}