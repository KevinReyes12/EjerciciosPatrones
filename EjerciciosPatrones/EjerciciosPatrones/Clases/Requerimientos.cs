using System;
using EjerciciosPatrones.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosPatrones.Clases
{
    public class Requerimientos: IPaginaWeb
    {
        public Requerimientos(Funcionalidades paginaWeb)
        {
            
        }
        public string getRequerimientos()
        {
            return "Login" + "Chat" + "Pagoenlinea" + "MultiplesIdiomas";
        }

        public string getFuncionalidades()
        {
            throw new NotImplementedException();
        }
    }
}
