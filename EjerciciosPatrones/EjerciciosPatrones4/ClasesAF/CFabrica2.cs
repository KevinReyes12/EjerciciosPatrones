using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosPatrones4.Clases
{
    public class CFabrica2:AFabrica
    {
        public override AProducto1 CreateProductA()
        {
            return new Producto1_2();
        }
        public override AProducto2 CreateProductB()
        {
            return new Producto2_2();
        }
    }
}
