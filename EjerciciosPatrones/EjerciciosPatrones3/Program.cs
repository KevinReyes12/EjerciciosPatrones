using System;
using EjerciciosPatrones3.Clases;
using EjerciciosPatrones3.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosPatrones3
{
    class Program
    {
        static void Main(string[] args)
        {
            
            IConectar conexion = new Fabrica();
            DatosAgnosticos da = new DatosAgnosticos();

        }
    }
}
