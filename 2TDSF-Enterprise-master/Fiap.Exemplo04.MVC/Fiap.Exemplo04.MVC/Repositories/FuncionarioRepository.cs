using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using Fiap.Exemplo04.MVC.Models;
using Fiap.Exemplo04.MVC.Persistencia;
using System.Data.Entity;

namespace Fiap.Exemplo04.MVC.Repositories
{
    public class FuncionarioRepository : IFuncionarioRepository
    {
        private EmpresaContext _context;

        public FuncionarioRepository(EmpresaContext context)
        {
            _context = context;
        }

        public void Alterar(Funcionario funcionario)
        {
            _context.Entry(funcionario).State = EntityState.Modified;
        }

        public Funcionario Buscar(int id)
        {
            return _context.Funcionarios.Find(id);
        }

        public List<Funcionario> BuscarPor(Expression<Func<Funcionario, bool>> filtro)
        {
           return _context.Funcionarios.Include("ContaSalario")
                            .Where(filtro).ToList();
        }

        public void Cadastrar(Funcionario funcionario)
        {
            _context.Funcionarios.Add(funcionario);
        }

        public void Excluir(int id)
        {
            var func = Buscar(id);
            _context.Funcionarios.Remove(func);
        }

        public List<Funcionario> Listar()
        {
            return _context.Funcionarios
                .Include("ContaSalario").ToList();
        }
    }
}