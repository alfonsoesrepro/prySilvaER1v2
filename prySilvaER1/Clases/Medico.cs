using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prySilvaER1.Clases
{
    public class Medico
    {
        //Atributos
        public string Nombre { get; set; }
        public string Especialidad { get; set; }
        public string Matricula { get; set; }
        
        //Constructor
        public Medico()
        {
            Nombre = "";
            Especialidad = "";
            Matricula = "";
        }
        public Medico(string nombre, string especialidad, string matricula)
        {
            Nombre = nombre;
            Especialidad = especialidad;
            Matricula = matricula;
        }
    }
}