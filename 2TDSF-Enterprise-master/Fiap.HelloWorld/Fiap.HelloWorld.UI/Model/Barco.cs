using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.HelloWorld.UI.Model
{
    class Barco : Veiculo, IAquatico
    {
        public int Vela { get; set; }

        public Barco(string marca):base(marca)
        {

        }

        public override void Ligar()
        {
            Console.WriteLine("Sobe a vela");
        }

        public void Flutuar()
        {
            Console.WriteLine("Flutuando");
        }
    }
}
