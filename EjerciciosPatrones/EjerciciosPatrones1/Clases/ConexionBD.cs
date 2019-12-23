using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosPatrones1.Clases
{
    public class ConexionBD
    {
      
        private string basedatos;
        private static ConexionBD conexionbd;
        private ConexionBD()
        {
          
        }
        public static ConexionBD getSingletonInstance(string basedatos)
        {
            if (conexionbd == null)
            {
                conexionbd = new ConexionBD();
            }
            else
            {
                Console.WriteLine("No se puede conectar " + basedatos + " porque ya existe una Base de datos conectada");
            }
            return null;
        }
        public ConexionBD clone()
        {
            try
            {
                throw new Exception();
            }
            catch ( Exception)
            {
                Console.WriteLine("No se puede clonar un objeto de la clase ConexionBD");
            }
            return null;
        }

    }
}
