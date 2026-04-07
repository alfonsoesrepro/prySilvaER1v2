using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prySilvaER1.Clases
{
    internal class ClassConsulta
    {
        //Atributos
        public ClassMedico Medico { get; set; }
        public ClassEspecialidad Especialidad { get; set; }
        public DateTime Fecha { get; set; }
        public string Diagnostico { get; set; }
        //Constructor
        public ClassConsulta(ClassMedico medico, ClassEspecialidad especialidad, DateTime fecha, string diagnostico)
        {
            Medico = medico;
            Especialidad = especialidad;
            Fecha = fecha;
            Diagnostico = diagnostico;
        }
    }
}
