using Fiap.Exemplo04.MVC.Persistencia;
using Fiap.Exemplo04.MVC.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Fiap.Exemplo04.MVC.Units
{
    public class UnitOfWork : IDisposable
    {
        private EmpresaContext _context = new EmpresaContext();

        private IFuncionarioRepository _funcionarioRepository;

        private IDependenteRepository _dependenteRepository;

        public IDependenteRepository DependenteRepository
        {
            get
            {
                if (_dependenteRepository == null)
                {
                    _dependenteRepository = new DependenteRepository(_context);
                }
                return _dependenteRepository;
            }
        }

        public IFuncionarioRepository FuncionarioRepository
        {
            get
            {
                if (_funcionarioRepository == null)
                {
                    _funcionarioRepository =
                        new FuncionarioRepository(_context);
                }
                return _funcionarioRepository;
            }
        }

        public void Dispose()
        {
            //Liberar a conexão com o banco de dados
            if (_context != null)
            {
                _context.Dispose();
            }
            GC.SuppressFinalize(this);
        }

        public void Salvar()
        {
            _context.SaveChanges();
        }
    }
}