using Fiap.Correcao.Nac.Models;
using Fiap.Correcao.Nac.Units;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fiap.Correcao.Nac.Controllers
{
    public class DisciplinaController : Controller
    {
        private UnitOfWork _unit = new UnitOfWork();

        [HttpGet]
        public ActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Cadastrar(Disciplina disciplina)
        {
            if (ModelState.IsValid)
            {
                _unit.DisciplinaRepository.Cadastrar(disciplina);
                _unit.Salvar();
                TempData["msg"] = "Cadastrado!";
                return RedirectToAction("Cadastrar");
            }
            return View();
        }
    }
}