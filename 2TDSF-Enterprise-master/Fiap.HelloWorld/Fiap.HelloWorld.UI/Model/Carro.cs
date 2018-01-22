using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.HelloWorld.UI.Model
{
    class Carro : Veiculo
    {
        //Propriedades
        public string Placa { get; set; }
        public int Portas { get; set; }

        public Combustivel Combustivel { get; set; }

        //Construtor
        public Carro(string marca):base(marca)
        {

        }

        public override void Ligar()
        {
            Console.WriteLine("Virar chave");
        }
    }
}
