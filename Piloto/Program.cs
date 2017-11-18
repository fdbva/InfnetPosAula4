using Piloto.Veiculos;
using System;
using System.Collections.Generic;

namespace Piloto
{
    class Program
    {
        static void Main(string[] args)
        {
            var rand = new Random();
            var lojaVeiculos = new List<IVeiculo> { new Carro(), new Caminhao(), new Moto() };
            
            var piloto = new Piloto();
            while (true)
            {
                Console.WriteLine("\nPressione Enter para comprar novo veículo");
                Console.ReadLine();
                piloto.Veiculo = lojaVeiculos[rand.Next(3)];
                piloto.Pilotar();
            }
        }
    }
}
