using Fiap.Exemplo04.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.Exemplo04.MVC.Repositories
{
    //Marcar a interface como public
    public interface IFuncionarioRepository
    {
        List<Funcionario> Listar();
        void Cadastrar(Funcionario funcionario);
        void Excluir(int id);
        void Alterar(Funcionario funcionario);
        Funcionario Buscar(int id);
        List<Funcionario> BuscarPor(Expression<Func<Funcionario, bool>> filtro);
    }
}






