using Fiap.Exemplo04.MVC.Models;
using Fiap.Exemplo04.MVC.Persistencia;
using Fiap.Exemplo04.MVC.Units;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fiap.Exemplo04.MVC.Controllers
{
    public class DependenteController : Controller
    {

        private UnitOfWork _unit = new UnitOfWork();

        [HttpGet]
        public ActionResult Cadastrar()
        {
            var lista = _unit.FuncionarioRepository.Listar();
            ViewBag.funcionarios = new SelectList(lista, "FuncionarioId", "Nome");
            return View();
        }

        [HttpPost]
        public ActionResult Cadastrar(Dependente dependente)
        {
            _unit.DependenteRepository.Cadastrar(dependente);
            _unit.Salvar();
            TempData["msg"] = "Cadastrado!";
            return RedirectToAction("Cadastrar");
        }

        [HttpGet]
        public ActionResult Listar()
        {
            return View(_unit.DependenteRepository.Listar());
        }

        [HttpGet]
        public ActionResult Buscar(string nome)
        {
            return View("Listar",
                _unit.DependenteRepository.BuscarPor(f => f.Funcionario.Nome.Contains(nome)));
        }

        protected override void Dispose(bool disposing)
        {
            _unit.Dispose();
            base.Dispose(disposing);
        }
    }
}