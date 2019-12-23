using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosPatrones4.ClaseSingleton
{
     public class Duenio
    {
        private String d;
        private static Duenio unicoD;
        private Duenio() 
        {
            
        }

        public static Duenio getSingletonInstance(String d) 
        {
            if (unicoD == null)
            {
                unicoD = new Duenio();
            }
            else
            {
                Console.WriteLine("No se puede Ingresar a " + d + " porque ya existe un Dueño de la Fabrica");
            }
            return null;
        }
        public Duenio clone()
        {
            try
            {
                throw new Exception();
            }
            catch (Exception )
            {
                Console.WriteLine("No se puede clonar un objeto de la clase SoyUnico");
            }
            return null;
        }
    }
}
