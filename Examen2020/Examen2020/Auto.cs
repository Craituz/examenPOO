using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen2020
{
    class Auto: Vehiculo,ICalculo_a_cobrar
    {
        public int precioVehiculo { get; set; }

        public void ICalculo_a_cobrar()
        {   
           if (this.Modelo == "Sedan")
                Console.WriteLine("valor a cobrar:" + precioVehiculo);
           else
                if (this.Modelo == "Hatchback")
                    Console.WriteLine("valor a cobrar:" + precioVehiculo * 0.10);
            
        }
    }
}
