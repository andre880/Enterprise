using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Fiap.Revisao.Models
{
    public class Ingresso
    {
        public int IngressoId { get; set; }
        [Required]
        public string Cadeira  { get; set; }
        public DateTime Data { get; set; }
        public Setor Setor { get; set; }
        public int SetorId { get; set; }
    }
}