using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Primer lote con 10 registros de productos, cada producto tiene:
            //-Código Artículo(3 dígitos no correlativos)
            //-Precio
            //-Código de Marca(1 a 10)
            //Segundo lote con las ventas de la semana. Cada venta tiene:
            //-Cógigo Artículo  
            //-Cantidad
            //-Código Cliente(1 a 100)
            //Este lote corta con Código de Cliente cero.

            Articulo[] articulos = new Articulo[10];
            articulos[6].CodigoMarca = 3;

            for(int i = 0; i <10; i++)
            {
                Console.WriteLine("Ingrese los datos del producto: ");
                Console.WriteLine("Código: ");
                articulos[i].CodigoArticulo = int.Parse(Console.ReadLine());
                Console.WriteLine("Precio");
                articulos[i].Precio = float.Parse(Console.ReadLine());
                Console.WriteLine("Marcas(0 a 10)");
                articulos[i].CodigoArticulo = int.Parse(Console.ReadLine());
            }
        }

    }
}
