using Fiap.Revisao.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Fiap.Revisao.Repositories
{
    public interface ISetorRespository
    {
        void Cadastrar(Setor setor);
        List<Setor> Listar();
    }
}