using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoTeste_24_02
{

    //normalizei numa classe veículo que pode ser implementada da maneira que for solicitada
    public abstract class Veiculo : IVeiculo
    {
        public abstract void Acelerar();

        public abstract void Freiar();
        
    }
}
