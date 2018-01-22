using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Fiap.Exemplo02.MVC.Models
{
    public class Cerveja
    {
        public string Nome { get; set; }
        public string Marca { get; set; }

        [Display(Name = "Preço")]
        public decimal Preco { get; set; }

        [Display(Name ="Sem Álcool")]
        public bool SemAlcool { get; set; }

        public string Tipo { get; set; }
        public DateTime Validade { get; set; }
    }
}