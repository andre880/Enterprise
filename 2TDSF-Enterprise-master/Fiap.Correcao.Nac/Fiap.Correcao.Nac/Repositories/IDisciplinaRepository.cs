using Fiap.Correcao.Nac.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.Correcao.Nac.Repositories
{
    public interface IDisciplinaRepository
    {
        void Cadastrar(Disciplina disciplina);
        void Atualizar(Disciplina disciplina);
        void Remover(int id);
        Disciplina Buscar(int id);
        List<Disciplina> Listar();
        List<Disciplina> BuscarPor(
            Expression<Func<Disciplina, bool>> filtro);
    }
}
