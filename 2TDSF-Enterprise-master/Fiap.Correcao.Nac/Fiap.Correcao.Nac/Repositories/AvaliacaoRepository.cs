using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Fiap.Correcao.Nac.Models;
using Fiap.Correcao.Nac.Persistencia;

namespace Fiap.Correcao.Nac.Repositories
{
    public class AvaliacaoRepository : IAvaliacaoRepository
    {
        private FiapContext _context;

        public AvaliacaoRepository(FiapContext context)
        {
            _context = context;
        }

        public void Cadastrar(Avaliacao avaliacao)
        {
            _context.Avaliacoes.Add(avaliacao);
        }

        public List<Avaliacao> Listar()
        {
            return _context.Avaliacoes.Include("Disciplina").ToList();
        }
    }
}