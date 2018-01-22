using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Fiap.Exemplo04.MVC.Models
{
    public class Dependente
    {
        public int DependenteId { get; set; }
        public string Nome { get; set; }

        //Relacionamento
        public Funcionario Funcionario { get; set; }
        public int FuncionarioId { get; set; }
    }
}