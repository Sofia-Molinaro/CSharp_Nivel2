using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Perro pe1 = new Perro();
            pe1.Nombre = "Coco";
            pe1.Color = "Blanco";
            pe1.Origen = "Argentina";

            Console.WriteLine($"{pe1.Nombre} es {pe1.Color} nació en {pe1.Origen}");
            Console.ReadKey();
        }
    }
}
