using System;
using System.Collections.Generic;
using System.Text;

namespace EjemploInyeccionDep
{
    public class mascota
    {
        private IExample example;

        public mascota(IExample _example)
        {
            this.example = _example;
        }

        public string sonidoAnimal()
        {
            return example.SonidoAnimal();
        }
    }
}
