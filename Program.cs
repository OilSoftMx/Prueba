using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolaMundoConsola
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hola mundo...");

            Libro miLibro = new Libro
            {
                Titulo="Ojos de Fuego",
                Autor="Stephen King"
            };

            Console.WriteLine();
            Console.WriteLine($"El libro es {miLibro.Titulo} de {miLibro.Autor}.");
            Console.WriteLine();
            Console.WriteLine("Pulse <Enter> para terminar...");
            Console.ReadLine();
        }
    }
}
