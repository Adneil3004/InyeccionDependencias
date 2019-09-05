using System;

namespace EjemploInyeccionDep
{
    class Program
    {
        static void Main(string[] args)
        {
            mascota animal = new mascota(new Pollo());

            Console.WriteLine(animal.sonidoAnimal());
            Console.ReadKey();

            animal = new mascota(new Gato());
            Console.WriteLine(animal.sonidoAnimal());
            Console.ReadKey();
        }
    }
}
