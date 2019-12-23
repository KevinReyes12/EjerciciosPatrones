using System;
using EjerciciosPatrones.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosPatrones.Clases
{
    public class Funcionalidades:DecoradorPaginaWeb
    {
        public Funcionalidades() : base(PaginaWeb)
        {
            
            
        }
        public override string getFuncionalidades()
        {

            return this.PaginaWeb.getFuncionalidades() + "Navegar";
        }

        public override string getRequerimientos()
        {
            throw new NotImplementedException();
        }
    }
}
