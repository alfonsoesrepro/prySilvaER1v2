using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prySilvaER1.Clases
{
    public class Archivo
    {
        public string NombreArchivo { get; set; }

        public bool AgregarEspecialidad(Especialidad esp)
        {
            bool resultado = false;
            if (NombreArchivo != "")
            {
                StreamWriter sw = new StreamWriter(NombreArchivo, true); // Abrir

                // Escribir
                sw.WriteLine(esp.Numero + "," + esp.Nombre);

                sw.Close(); //Cerrar
                sw.Dispose();

                resultado = true;
            }
            return resultado;
        }

        public bool AgregarMedico(Medico med)
        {
            bool resultado = false;
            if (NombreArchivo != "")
            {
                StreamWriter sw = new StreamWriter(NombreArchivo, true); // Abrir

                // Escribir
                sw.WriteLine(med.Matricula + "," + med.Nombre + "," + med.Especialidad);

                sw.Close(); //Cerrar
                sw.Dispose();

                resultado = true;
            }
            return resultado;
        }

        public bool BuscarNumero(string num)
        {
            bool resultado = false;
            string Linea;
            string NumeroEnArchivo;

            if (NombreArchivo != "" && File.Exists(NombreArchivo))
            {
                StreamReader sr = new StreamReader(NombreArchivo); // Abrir

                while (sr.EndOfStream == false)
                {
                    Linea = sr.ReadLine(); // Leer

                    NumeroEnArchivo = Linea.Split(',')[0];

                    if (num == NumeroEnArchivo)
                    {
                        resultado = true;
                        break;
                    }
                }
                sr.Close(); // Cerrar
                sr.Dispose();
            }
            return resultado;

            // devuelve falso si el número no existe en el archivo
            // devuelve verdadero si el número ya está grabado
        }

        public List<Medico> ObtenerMedicos()
        {
            List<Medico> Lista = new List<Medico>();
            string Linea;

            if (NombreArchivo != "" && File.Exists(NombreArchivo))
            {
                StreamReader sr = new StreamReader(NombreArchivo);

                while (sr.EndOfStream == false)
                {
                    Linea = sr.ReadLine();

                    Medico med = new Medico();
                    med.Matricula = Linea.Split(',')[0];
                    med.Nombre = Linea.Split(',')[1];
                    med.Especialidad = Linea.Split(',')[2];

                    Lista.Add(med);
                }
                sr.Close();
                sr.Dispose();
            }

            return Lista;
        }

        public List<Medico> ObtenerMedicosOrdenados()
        {
            List<Medico> Lista = ObtenerMedicos();

            Medico[] medicosArray = Lista.ToArray();
            // Método de Burbuja por el campo Nombre en forma ascendente (de menor a mayor)
            for (int i = 0; i < medicosArray.Length - 1; i++)
            {
                for (int j = 0; j < medicosArray.Length - 1; j++)
                {
                    if (string.Compare(medicosArray[j].Nombre,
                    medicosArray[j + 1].Nombre) > 0)
                    {
                        Medico aux = medicosArray[j];
                        medicosArray[j] = medicosArray[j + 1];
                        medicosArray[j + 1] = aux;
                    }
                }
            }

            List<Medico> ListaOrdenada = medicosArray.ToList<Medico>();

            return ListaOrdenada;
        }
    }
}