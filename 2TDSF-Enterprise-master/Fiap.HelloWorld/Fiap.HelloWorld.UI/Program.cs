using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fiap.HelloWorld.UI.Model;

namespace Fiap.HelloWorld.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instanciar uma classe
            Megazord mega = new Megazord("Power Rangers");

            Carro carro = new Carro("FIAT")
            {                
                Placa = "DDD-9899"
            };

            float x = Convert.ToSingle(Console.ReadLine());

            //Setar valores nas propriedades
            mega.Marca = "Power Rangers";
            mega.Forma = "Pterodáctilo";
            //Exibir um valor da propriedade
            Console.WriteLine(mega.Forma);
            Console.ReadLine();
        }
    }
}
