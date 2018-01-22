using Fiap.Correcao.Nac.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.Correcao.Nac.Repositories
{
    public interface IAvaliacaoRepository
    {
        void Cadastrar(Avaliacao avaliacao);
        List<Avaliacao> Listar();
    }
}
