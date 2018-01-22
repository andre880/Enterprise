using Fiap.Correcao.Nac.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Fiap.Correcao.Nac.Persistencia
{
    public class FiapContext : DbContext
    {
        public DbSet<Disciplina> Disciplinas { get; set; }
        public DbSet<Avaliacao> Avaliacoes { get; set; }
    }
}