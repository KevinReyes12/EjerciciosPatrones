using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosPatrones4.Clases
{
    public class Cliente
    {
        private AProducto1 _aProducto1;
        private AProducto2 _aProducto2;


        public Cliente(AFabrica factory)
        {
            _aProducto2 = factory.CreateProductB();
            _aProducto1 = factory.CreateProductA();
        }

        public void Run()
        {
            _aProducto2.Interact(_aProducto1);
        }
    }
}
