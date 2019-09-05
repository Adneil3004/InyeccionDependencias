using System;
using System.Collections.Generic;
using System.Text;

namespace EjemploInyeccionDep
{
    public class Perro : IExample
    {
        public string SonidoAnimal()
        {
            return "Guau Guau";
        }
    }
}
