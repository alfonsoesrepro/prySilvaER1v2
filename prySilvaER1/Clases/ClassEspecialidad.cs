using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prySilvaER1.Clases
{
    internal class ClassEspecialidad
    {
        //Atributos
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        //Constructor
        public ClassEspecialidad(string nombre, string descripcion)
        {
            Nombre = nombre;
            Descripcion = descripcion;
        }
    }
}
