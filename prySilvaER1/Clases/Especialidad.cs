using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prySilvaER1.Clases
{
    public class Especialidad
    {
        //Atributos
        public string Nombre { get; set; }
        public string Numero { get; set; }
        
        //Constructor
        public Especialidad()
        {
            Nombre = "";
            Numero = "";
        }
        public Especialidad(string nombre, string numero)
        {
            Nombre = nombre;
            Numero = numero;
        }
    }
}