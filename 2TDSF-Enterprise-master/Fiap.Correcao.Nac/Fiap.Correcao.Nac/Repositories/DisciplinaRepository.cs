using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using Fiap.Correcao.Nac.Models;
using Fiap.Correcao.Nac.Persistencia;
using System.Data.Entity;

namespace Fiap.Correcao.Nac.Repositories
{
    public class DisciplinaRepository : IDisciplinaRepository
    {
        private FiapContext _context;

        public DisciplinaRepository(FiapContext context)
        {
            _context = context;
        }

        public void Atualizar(Disciplina disciplina)
        {
            _context.Entry(disciplina).State = EntityState.Modified;
        }

        public Disciplina Buscar(int id)
        {
            return _context.Disciplinas.Find(id);
        }

        public List<Disciplina> BuscarPor(Expression<Func<Disciplina, bool>> filtro)
        {
            return _context.Disciplinas.Where(filtro).ToList();
        }

        public void Cadastrar(Disciplina disciplina)
        {
            _context.Disciplinas.Add(disciplina);
        }

        public List<Disciplina> Listar()
        {
            return _context.Disciplinas.ToList();
        }

        public void Remover(int id)
        {
            var disciplina = Buscar(id);
            _context.Disciplinas.Remove(disciplina);
        }
    }
}