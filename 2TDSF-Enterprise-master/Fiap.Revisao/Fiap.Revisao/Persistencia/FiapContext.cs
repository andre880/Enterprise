using Fiap.Revisao.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Fiap.Revisao.Persistencia
{
    public class FiapContext : DbContext
    {
        public DbSet<Ingresso> Ingressos { get; set; }
        public DbSet<Setor> Setores { get; set; }
    }
}