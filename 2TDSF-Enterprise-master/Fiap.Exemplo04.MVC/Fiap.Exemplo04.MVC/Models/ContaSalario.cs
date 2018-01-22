using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Fiap.Exemplo04.MVC.Models
{
    public class ContaSalario
    {
        public int ContaSalarioId { get; set; }
        public string Banco { get; set; }
        public int Agencia { get; set; }
        public string Numero { get; set; }
    }
}