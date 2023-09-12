using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio5
{
    public class Coche : IVehiculo
    {
        public int CantCombustible { get; set; }
        public Coche(int gasolinaInicial)
        {

            CantCombustible = gasolinaInicial;
        }

        public void Conducir()
        {
            if(CantCombustible <= 0)
            {
                Console.WriteLine("Usted debe cargar combustible");
            }
            else
            {
                Console.WriteLine("El coche esta conduciendo");
            }
            



        }

        public bool CargarCombustible(int cargarCombustible)
        {

            CantCombustible += cargarCombustible;
            return true;
        }
    }
}
