using Fiap.Exemplo03.MVC.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Fiap.Exemplo03.MVC.Persistencia
{
    public class ZooContext : DbContext
    {
        public DbSet<Animal> Animais { get; set; }
        public DbSet<Funcionario> Funcionarios { get; set; }
    }
}