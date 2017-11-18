using Piloto.Veiculos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Piloto
{
    public class Piloto
    {
        public IVeiculo Veiculo { get; set; }

        public void Pilotar()
        {
            Veiculo.Pilotar();
        }
    }
}
