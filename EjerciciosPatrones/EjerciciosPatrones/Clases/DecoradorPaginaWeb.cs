using System;
using EjerciciosPatrones.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosPatrones.Clases
{
    public abstract class DecoradorPaginaWeb:IPaginaWeb
    {
        protected IPaginaWeb PaginaWeb;
        public DecoradorPaginaWeb(IPaginaWeb PaginaWeb) { this.PaginaWeb = PaginaWeb; }

        public abstract string getFuncionalidades();
        public abstract string getRequerimientos();
    }
}
