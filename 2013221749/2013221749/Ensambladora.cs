using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2013221749
{
    class Ensambladora
    {
        private Carro _carro;

        public Ensambladora(Carro carro)
        {
            _carro = carro;
        }

        public Carro Carro { get { return _carro; } }
    }
}
