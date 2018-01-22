using Fiap.Revisao.Persistencia;
using Fiap.Revisao.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Fiap.Revisao.Units
{
    public class UnitOfWork : IDisposable
    {
        private FiapContext _context = new FiapContext();

        private IIngressoRepository _ingressoRepository;

        private ISetorRespository _setorRepository;

        public ISetorRespository SetorRepository
        {
            get
            {
                if (_setorRepository == null)
                {
                    _setorRepository = new SetorRepository(_context);
                }
                return _setorRepository;
            }
        }

        public IIngressoRepository IngressoRepository
        {
            get
            {
                if (_ingressoRepository == null)
                {
                    _ingressoRepository = new IngressoRepository(_context);
                }
                return _ingressoRepository;
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