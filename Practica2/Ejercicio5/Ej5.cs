using Ejercicio5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica2.Ej5
{
    public class Ej5
    {
        public void Ejecutar()
        {
            Coche Peugeot206 = new Coche(0);
            Peugeot206.CargarCombustible(0);
            Peugeot206.Conducir();

        }
    }
}
