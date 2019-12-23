using System;
using EjerciciosPatrones3.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosPatrones3.Clases
{
    public class DatosAgnosticos 
    {
        public DatosAgnosticos()
        {

        }

        public String Detalle { get; set; }
        
        public String Descripcion(String detalle) 
        {
            return detalle;
        }
    }
}
