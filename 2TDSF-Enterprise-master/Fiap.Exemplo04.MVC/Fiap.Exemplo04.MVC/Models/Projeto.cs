using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Fiap.Exemplo04.MVC.Models
{
    public class Projeto
    {
        public int ProjetoId { get; set; }
        public string Descricao { get; set; }
        public DateTime DataInicio { get; set; }

        //Relacionamentos
        public List<Funcionario> Funcionarios { get; set; }
    }
}