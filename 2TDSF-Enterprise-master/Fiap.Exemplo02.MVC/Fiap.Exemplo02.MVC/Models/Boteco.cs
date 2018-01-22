using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Fiap.Exemplo02.MVC.Models
{
    public class Boteco
    {
        public int Id { get; set; }
        public string Nome{ get; set; }
        public string Endereco { get; set; }
        public bool MusicaAoVivo { get; set; }
        public decimal Consumacao { get; set; }
        public DateTime DataInauguracao { get; set; }
    }
}