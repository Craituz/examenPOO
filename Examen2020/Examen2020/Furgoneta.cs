using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen2020
{
    class Furgoneta : Vehiculo,ICalculo_a_cobrar
    {
        Vehiculo v;
        public Furgoneta(int num_asientos, int precio_Base, int precio_Asiento)
        {
            this.num_asientos = num_asientos;
            this.precio_Base = precio_Base;
            this.precio_Asiento = precio_Asiento;
        }

        public int num_asientos { get; set; }
        public int precio_Base { get; set; }
        public int precio_Asiento { get; set; }

        public void ICalculo_a_cobrar()
        {
            int precio = precio_Asiento * num_asientos;
            int resultado = precio + precio_Base;
            Console.WriteLine("El valor a cobrar es:"+resultado);
        }
    }
}
