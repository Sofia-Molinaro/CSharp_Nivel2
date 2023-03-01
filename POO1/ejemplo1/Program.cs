using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Persona: Edad, Sueldo, Nombre
            //Atributos o miembros de la clase(variables que guardan información de la persona)
            //int edad;
            //float sueldo;
            //string nombre;
            //int[] edades = new int[10];
            //float[] sueldos = new float[10];
            //string[] nombres = new string[10];
            
            Persona p1 = new Persona();
            //variable         //objeto
            p1.setEdad(20);
            Console.WriteLine($"La edad de la persona es: {p1.getEdad()}");
            Console.ReadKey();
        }
    }
}
