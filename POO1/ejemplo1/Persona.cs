using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo1
{
    class Persona
    {
        //Persona: edad, sueldo, nombre(Atributos)
        private int edad;
        private float sueldo;
        private string nombre;

        public void setEdad(int e)
        {
            edad = e;
        }

        public int getEdad() 
        {
            return edad;
        }
    }
}
