using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Fiap.Exemplo04.MVC.Models
{
    public class Funcionario
    {
        public int FuncionarioId { get; set; }
        public string Nome { get; set; }
        public DateTime DataRegistro { get; set; }

        //Relacionamentos
        public List<Dependente> Dependentes { get; set; }

        public ContaSalario ContaSalario { get; set; }
        public int ContaSalarioId { get; set; }

        public List<Projeto> Projetos { get; set; }
    }
}