using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosPatrones4.Clases
{
    public class Producto2_1:AProducto2
    {
        public override void Interact(AProducto1 a)
        {
            Console.WriteLine(this.GetType().Name +
              " interactua con " + a.GetType().Name);
        }
    }
}
