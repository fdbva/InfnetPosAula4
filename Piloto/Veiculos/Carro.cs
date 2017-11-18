using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Piloto.Veiculos
{
    public class Carro : IVeiculo
    {
        public void Pilotar()
        {
            Console.WriteLine("Pilotando Carro");
        }
    }
}
