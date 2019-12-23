using System;
using EjerciciosPatrones1.Clases;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosPatrones1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<ConexionBD> bd = new List<ConexionBD>();
            ConexionBD baseDatos1 = ConexionBD.getSingletonInstance("Sql Server");
            ConexionBD baseDatos2 = ConexionBD.getSingletonInstance("Oracle");
            ConexionBD baseDatos3 = ConexionBD.getSingletonInstance("PostgreSQL");
            bd.Add(baseDatos1);
            bd.Add(baseDatos2);
            bd.Add(baseDatos3);
            

            Console.ReadKey();
        }
    }
}
