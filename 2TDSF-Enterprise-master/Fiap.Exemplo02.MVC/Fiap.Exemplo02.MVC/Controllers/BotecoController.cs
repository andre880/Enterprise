using Fiap.Exemplo02.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fiap.Exemplo02.MVC.Controllers
{
    public class BotecoController : Controller
    {
        //Simular o banco de dados
        private static List<Boteco> _banco = new List<Boteco>();

        //Abre a tela com o formulário
        [HttpGet]
        public ActionResult Cadastro()
        {
            return View();
        }

        [HttpPost]
        //Cadastrar de verdade
        public ActionResult Cadastro(Boteco boteco)
        {
            //Cadastrar no banco
            _banco.Add(boteco);
            //Mensagem de sucesso
            TempData["msg"] = "Cadastrado com sucesso!";
            return View();
        }

        [HttpGet]
        public ActionResult Listar()
        {
            //Passar os botecos cadastrados p/ view
            return View(_banco);
        }
    }
}