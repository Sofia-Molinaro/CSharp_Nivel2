using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo4
{
    internal class Articulo
    {
        //Atributos:
        //-Código Artículo(3 dígitos no correlativos)
        //-Precio
        //-Código de Marca(1 a 10)
        
        
        //Creo la propiedad( y omito private int codArticulo;)
        public int CodigoArticulo { get; set; }


        //private float precio;
        public float Precio { get; set; } //de esta forma no puedo controlar ni el get ni el set)
        
        
        private int CodMarca;
        public int CodigoMarca
        {
            get { return CodigoMarca; }
            set 
            {  
                if(value > 0 && value < 11)
                {
                    CodigoMarca = value;
                }
                else
                {
                    CodigoMarca = -1;
                }
            }
        }

    }
}
