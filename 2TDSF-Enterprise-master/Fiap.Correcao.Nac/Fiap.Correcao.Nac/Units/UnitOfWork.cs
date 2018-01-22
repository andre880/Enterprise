using Fiap.Correcao.Nac.Persistencia;
using Fiap.Correcao.Nac.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Fiap.Correcao.Nac.Units
{
    public class UnitOfWork : IDisposable
    {
        private FiapContext _context = new FiapContext();

        private IAvaliacaoRepository _avaliacaoRepository;
        private IDisciplinaRepository _disciplinaRepository;

        public IDisciplinaRepository DisciplinaRepository
        {
            get
            {
                if (_disciplinaRepository == null)
                {
                    _disciplinaRepository = new DisciplinaRepository(_context);
                }
                return _disciplinaRepository;
            }
        }

        public IAvaliacaoRepository AvaliacaoRepository
        {
            get
            {
                if (_avaliacaoRepository == null)
                {
                    _avaliacaoRepository = new AvaliacaoRepository(_context);
                }
                return _avaliacaoRepository;
            }
        }

        public void Salvar()
        {
            _context.SaveChanges();
        }

        public void Dispose()
        {
            if (_context != null)
            {
                _context.Dispose();
            }
            GC.SuppressFinalize(this);
        }
    }
}