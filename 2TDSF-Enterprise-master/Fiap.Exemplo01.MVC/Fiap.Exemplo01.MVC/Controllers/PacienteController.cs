using Fiap.Exemplo01.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fiap.Exemplo01.MVC.Controllers
{
    public class PacienteController : Controller
    {
        // GET: Paciente
        public ActionResult Cadastro()
        {
            return View();
        }

        public ActionResult Gravar(Paciente paciente)
        {
            //Passando valores para a view
            TempData["msg"] = "Gravou!";
            ViewBag.nomedogaroto = paciente.Nome;
            ViewBag.dataAniversario = paciente.Data;
            return View(paciente);
            //  return Content(paciente.Nome + " " + paciente.Data + " " +
            //     paciente.Convenio + " " + paciente.Tipo);
        }
    }
}