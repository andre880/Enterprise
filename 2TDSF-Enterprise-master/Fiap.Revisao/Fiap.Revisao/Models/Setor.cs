using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Fiap.Revisao.Models
{
    public class Setor
    {
        public int SetorId { get; set; }
        [Required]
        public string Nome { get; set; }        
        [Range(0,10000)]
        public decimal Preco { get; set; }
        public List<Ingresso> Ingressos { get; set; }
    }
}