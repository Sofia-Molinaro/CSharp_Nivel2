using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo2
{
    class Botella
    {
        //Botella: Capacidad, Color, Material
        private int capacidad;
        private string color;
        private string material;

        //Propiedad
        public int Capacidad
        {
            get { return capacidad; }
            set { capacidad = value; }  //recepción y asignación del atributo 
        }
    }
}
