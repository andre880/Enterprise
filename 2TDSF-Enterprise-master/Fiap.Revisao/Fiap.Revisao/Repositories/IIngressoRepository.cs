using Fiap.Revisao.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;

namespace Fiap.Revisao.Repositories
{
    public interface IIngressoRepository
    {
        void Cadastrar(Ingresso ingresso);
        void Atualizar(Ingresso ingresso);
        void Remover(int codigo);
        List<Ingresso> Listar();
        List<Ingresso> BuscarPor(
            Expression<Func<Ingresso, bool>> filtro);
        Ingresso Buscar(int codigo);
    }
}