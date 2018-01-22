using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using Fiap.Revisao.Models;
using Fiap.Revisao.Persistencia;
using System.Data.Entity;

namespace Fiap.Revisao.Repositories
{
    public class IngressoRepository : IIngressoRepository
    {
        private FiapContext _context;

        public IngressoRepository(FiapContext context)
        {
            _context = context;
        }

        public void Atualizar(Ingresso ingresso)
        {
            _context.Entry(ingresso).State = EntityState.Modified;
        }

        public Ingresso Buscar(int codigo)
        {
            return _context.Ingressos.Find(codigo);
        }

        public List<Ingresso> BuscarPor(Expression<Func<Ingresso, bool>> filtro)
        {
            return _context.Ingressos.Include("Setor")
                .Where(filtro).ToList();
        }

        public void Cadastrar(Ingresso ingresso)
        {
            _context.Ingressos.Add(ingresso);
        }

        public List<Ingresso> Listar()
        {
            return _context.Ingressos.Include("Setor").ToList();
        }

        public void Remover(int codigo)
        {
            var ingresso = Buscar(codigo);
            _context.Ingressos.Remove(ingresso);
        }
    }
}