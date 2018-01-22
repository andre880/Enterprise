using Fiap.Banco.Model;
using Fiap.Exercicio01.UI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.Exercicio01.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            var cc = new ContaCorrente()
            {
                Agencia = 123,
                Numero = 321,
                DataAbertura = DateTime.Now,
                Saldo = 10000,
                Tipo = TipoConta.Comum
            };
            var cp = new ContaPoupanca(0.06m)
            {
                Agencia = 123,
                Numero = 333,
                Saldo = 500,
                DataAbertura = DateTime.Now,
                Taxa = 1
            };

            //Chamar os métodos
            cc.Depositar(5000);
            cc.Retirar(80);
            Console.WriteLine(cc.Saldo);
            Console.WriteLine(cp.CalculaRetornoInvestimento());
            Console.ReadLine();
        }
    }
}
