using System;
using EjerciciosPatrones.Clases;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosPatrones2
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionalidades paginaWeb = new Funcionalidades();
            Requerimientos Usario = new Requerimientos(paginaWeb);


            Console.WriteLine(paginaWeb.getFuncionalidades());
            Console.WriteLine(Usario.getRequerimientos());
        }
    }
}
