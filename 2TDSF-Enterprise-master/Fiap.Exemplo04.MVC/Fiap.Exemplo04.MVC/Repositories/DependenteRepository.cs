using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using Fiap.Exemplo04.MVC.Models;
using Fiap.Exemplo04.MVC.Persistencia;

namespace Fiap.Exemplo04.MVC.Repositories
{
    public class DependenteRepository : IDependenteRepository
    {
        private EmpresaContext _context;

        public DependenteRepository(EmpresaContext context)
        {
            _context = context;
        }


        public void Alterar(Dependente dependente)
        {
            _context.Entry(dependente).State = System.Data.Entity.EntityState.Modified;
        }

        public Dependente Buscar(int id)
        {
            return _context.Dependentes.Find(id);
        }

        public List<Dependente> BuscarPor(Expression<Func<Dependente, bool>> filtro)
        {
            return _context.Dependentes.Include("Funcionario").Where(filtro).ToList();
        }

        public void Cadastrar(Dependente dependente)
        {
            _context.Dependentes.Add(dependente);
        }

        public List<Dependente> Listar()
        {
            return _context.Dependentes.Include("Funcionario").ToList();
        }

        public void Remover(int id)
        {
            var dep = Buscar(id);
            _context.Dependentes.Remove(dep);
        }
    }
}