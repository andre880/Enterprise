using Fiap.Exemplo04.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.Exemplo04.MVC.Repositories
{
    public interface IDependenteRepository
    {
        List<Dependente> Listar();
        List<Dependente> BuscarPor(Expression<Func<Dependente, bool>> filtro);
        Dependente Buscar(int id);
        void Cadastrar(Dependente dependente);
        void Alterar(Dependente dependente);
        void Remover(int id);
    }
}
