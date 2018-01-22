using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.HelloWorld.UI.Model
{
    class Megazord : Veiculo
    {
        public string Forma { get; set; }

        public Megazord(string marca):base(marca)
        {

        }

        public override void Acelerar(float velocidade)
        {

        }

        public override void Ligar()
        {
            Console.WriteLine("Morfando");
        }
    }
}
