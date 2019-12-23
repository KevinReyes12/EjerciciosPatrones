using System;
using EjerciciosPatrones4.Clases;
using EjerciciosPatrones4.ClaseSingleton;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosPatrones4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Planteamiento ejercicio 4: Definir una fábrica que permita construir una serie de productos 
            //para la interacción del cliente con los productos y su respectivo dueño.

            //Abstract Factory
            AFabrica f1 = new CFabrica1();
            Cliente cliente1 = new Cliente(f1);
            cliente1.Run();

            AFabrica f2 = new CFabrica2();
            Cliente cliente2 = new Cliente(f2);
            cliente2.Run();

            AProducto1 ap = new AProducto1();
            //Singleton
            Duenio d = Duenio.getSingletonInstance("Luis Moreira");

        }
    }
}
