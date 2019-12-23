using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosPatrones4.Clases
{
    public abstract class AFabrica
    {
        public abstract AProducto1 CreateProductA();
        public abstract AProducto2 CreateProductB();
    }
}
