using Fiap.Revisao.Models;
using Fiap.Revisao.Units;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fiap.Revisao.Controllers
{
    public class IngressoController : Controller
    {
        private UnitOfWork _unit = new UnitOfWork();

        [HttpGet]
        public ActionResult Cadastrar()
        {
            var setores = _unit.SetorRepository.Listar();
            ViewBag.setores = new SelectList(setores, "SetorId", "Nome");
            return View();
        }

        [HttpPost]
        public ActionResult Cadastrar(Ingresso ingresso)
        {
            if (ModelState.IsValid)
            {
                _unit.IngressoRepository.Cadastrar(ingresso);
                _unit.Salvar();
                TempData["msg"] = "Cadastrado!";
                return RedirectToAction("Cadastrar");
            }
            var setores = _unit.SetorRepository.Listar();
            ViewBag.setores = new SelectList(setores, "SetorId", "Nome");
            return View();
        }

        public ActionResult Listar()
        {
            return View(_unit.IngressoRepository.Listar());
        }

        protected override void Dispose(bool disposing)
        {
            _unit.Dispose();
            base.Dispose(disposing);
        }
    }
}