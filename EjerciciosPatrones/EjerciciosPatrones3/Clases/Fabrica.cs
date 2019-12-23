using System;
using EjerciciosPatrones3.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosPatrones3.Clases
{
    public class Fabrica:IConectar,IDesconectar
    {
        public Fabrica() 
        {
            
        }
        public String Conectarcon() 
        {
            return "Se ha conectado";
        }
        public String Desconectarcon()
        {
            return "Se ha desconectado";
        }
    }
}
