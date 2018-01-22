using Fiap.Exemplo04.MVC.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Fiap.Exemplo04.MVC.Persistencia
{
    public class EmpresaContext : DbContext
    {
        public DbSet<ContaSalario> ContasSalario { get; set; }
        public DbSet<Funcionario> Funcionarios { get; set; }
        public DbSet<Projeto> Projetos { get; set; }
        public DbSet<Dependente> Dependentes { get; set; }
    }
}