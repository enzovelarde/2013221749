using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2013221749
{
    class Carro
    {

         Llanta _llanta;
         Parabrisas _parabrisas;
         Volante _volante;
         Asiento _asiento;

        public string numSerieMotor { get; set; }
        public string numSerieChasis { get; set; }
        public Carro(Volante volante, Parabrisas parabrisas, int numLlantas, int numAsientos, Propietario propietario, TipoCarro tipocarro) { 
        

        }

        public Carro(string numMotor, string numChasis)
        {
            numSerieMotor = numMotor;
            numSerieChasis = numChasis;
            _parabrisas = new Parabrisas();
            _volante = new Volante();
            _asiento = new Asiento();
            _llanta = new Llanta();

        }

    }
}
