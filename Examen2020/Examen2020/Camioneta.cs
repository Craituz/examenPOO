using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen2020
{
    class Camioneta: Vehiculo,ICalculo_a_cobrar
    {
        public string TipoCabina { get; set; }

        public void ICalculo_a_cobrar()
        {
            int cobro = 20000;
            int cobros = 15000;
            if (this.TipoCabina=="Cabina Doble")
                Console.WriteLine("El valor a cobrar es:"+cobro);
            else
                 if (this.TipoCabina == "Cabina Simple")
                Console.WriteLine("El valor a cobrar es:"+cobros);
        }
    }
}
