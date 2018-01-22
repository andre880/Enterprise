using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Fiap.Revisao.Models;
using Fiap.Revisao.Persistencia;

namespace Fiap.Revisao.Repositories
{
    public class SetorRepository : ISetorRespository
    {
        private FiapContext _context;

        public SetorRepository(FiapContext context)
        {
            _context = context;
        }

        public void Cadastrar(Setor setor)
        {
            _context.Setores.Add(setor);
        }

        public List<Setor> Listar()
        {
            return _context.Setores.ToList();
        }
    }
}