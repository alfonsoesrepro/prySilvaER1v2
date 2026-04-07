using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prySilvaER1.Clases
{
    internal class ClassMedico
    {
        //Atributos
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Especialidad { get; set; }
        public int Matricula { get; set; }
        //Constructor
        public ClassMedico(string nombre, string apellido, string especialidad, int matricula)
        {
            Nombre = nombre;
            Apellido = apellido;
            Especialidad = especialidad;
            Matricula = matricula;
        }

        public void AgregarMedico()
        {
            // Lógica para agregar el médico a la base de datos o lista
            // Ejemplo: Database.Medicos.Add(this);
        }
    }
}
