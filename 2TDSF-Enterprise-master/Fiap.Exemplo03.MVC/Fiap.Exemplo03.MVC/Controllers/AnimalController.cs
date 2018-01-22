using Fiap.Exemplo03.MVC.Models;
using Fiap.Exemplo03.MVC.Persistencia;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fiap.Exemplo03.MVC.Controllers
{
    public class AnimalController : Controller
    {
        private ZooContext _context = new ZooContext();

        [HttpGet]
        public ActionResult Excluir(int id)
        {
            var animal = _context.Animais.Find(id);
            _context.Animais.Remove(animal);
            _context.SaveChanges();
            TempData["msg"] = "Excluido!";
            return RedirectToAction("Listar");
        }

        [HttpPost]
        public ActionResult Alterar(Animal animal)
        {
            _context.Entry(animal).State = EntityState.Modified;
            _context.SaveChanges();
            TempData["msg"] = "Atualizado!";
            return RedirectToAction("Listar");
        }

        [HttpGet]
        public ActionResult Alterar(int id)
        {
            //Pesquisa o animal no banco e envia p/ tela
            return View(_context.Animais.Find(id));
        }

        [HttpGet]
        public ActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Cadastrar(Animal animal)
        {
            _context.Animais.Add(animal);
            _context.SaveChanges();
            TempData["msg"] = "Cadastrado com sucesso!";
            return RedirectToAction("Cadastrar");
        }

        [HttpGet]
        public ActionResult Listar()
        {
            //Passa a lista para a view
            return View(_context.Animais.ToList());
        }

    }
}