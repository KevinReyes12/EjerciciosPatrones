using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosPatrones4.Clases
{
    public class CFabrica1:AFabrica
    {
        public override AProducto1 CreateProductA()
        {
            return new Producto1_1();
        }
        public override AProducto2 CreateProductB()
        {
            return new Producto2_1();
        }
    }
}
