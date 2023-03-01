using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Botella b1 = new Botella();
            b1.Capacidad = 200;

            int algo = b1.Capacidad; //lee el valor y lo guarda en la variable "algo"
            
            Console.WriteLine($"La capacidad de la botella es: {b1.Capacidad}");
            Console.ReadKey();
        }
    }
}
