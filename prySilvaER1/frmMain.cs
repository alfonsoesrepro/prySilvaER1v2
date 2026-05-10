using prySilvaER1.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace prySilvaER1
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private const string PATH_ARCHIVO_ESPECIALIDADES = "Especialidades.txt";
        private const string PATH_ARCHIVO_MEDICOS = "Medicos.txt";


        // GroupBox Especialidades
        private void btnAgregarE_Click(object sender, EventArgs e)
        {
            if (ValidarEspecialidad())
            {
                Especialidad nuevaEsp = CrearEspecialidad();

                Archivo EspecialidadesForm = new Archivo();
                EspecialidadesForm.NombreArchivo = PATH_ARCHIVO_ESPECIALIDADES;
                EspecialidadesForm.AgregarEspecialidad(nuevaEsp);
                
                cmbEspecialidad.Items.Add(nuevaEsp.Nombre);
                cmbEspecialidad.SelectedIndex = 0;
                cmbConsulta.Items.Add(nuevaEsp.Nombre);
                cmbConsulta.SelectedIndex = 0;
                txtNumero.Text = "";
                txtNombreE.Text = "";
            }
            else
            {
                MessageBox.Show("Datos vacíos o ya existentes.", "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private bool ValidarEspecialidad()
        {
            bool resultado = false;

            if (txtNumero.Text != "")
            {
                if (txtNombreE.Text != "")
                {
                    Archivo EspecialidadForm = new Archivo();
                    EspecialidadForm.NombreArchivo = PATH_ARCHIVO_ESPECIALIDADES;
                    // controla que no se repita el número de especialidad
                    if (EspecialidadForm.BuscarNumero(txtNumero.Text) == false)
                    {
                        resultado = true;
                    }
                }
            }
            return resultado;
        }

        private Especialidad CrearEspecialidad()
        {
            Especialidad nuevaEsp = new Especialidad();

            nuevaEsp.Numero = txtNumero.Text;
            nuevaEsp.Nombre = txtNombreE.Text;

            return nuevaEsp;
        }

        private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            // aceptar solo expresiones numéricas con decimales
            if (!Char.IsNumber(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != (int)Keys.Back)
            {
                e.Handled = true;
            }

            if (e.KeyChar == ',' && txtNumero.Text.Contains(","))
            {
                e.Handled = true;
            }
        }
        
        
        // GroupBox Médicos
        private void btnAgregarM_Click(object sender, EventArgs e)
        {
            if (ValidarMedico())
            {
                Medico nuevoMed = CrearMedico();

                Archivo MedicosForm = new Archivo();
                MedicosForm.NombreArchivo = PATH_ARCHIVO_MEDICOS;
                MedicosForm.AgregarMedico(nuevoMed);

                txtMatricula.Text = "";
                txtNombreM.Text = "";
                cmbEspecialidad.SelectedIndex = -1;
            }
            else
            {
                MessageBox.Show("Datos vacíos o ya existentes.", "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private bool ValidarMedico()
        {
            bool resultado = false;

            if (txtMatricula.Text != "")
            {
                if (txtNombreM.Text != "")
                {
                    if (cmbEspecialidad.SelectedIndex != -1)
                    {
                        Archivo MedicosForm = new Archivo();
                        MedicosForm.NombreArchivo = PATH_ARCHIVO_MEDICOS;
                        // controla que no se repita el número de matrícula
                        if (MedicosForm.BuscarNumero(txtMatricula.Text) == false)
                        {
                            resultado = true;
                        }
                    }
                }
            }
            return resultado;
        }

        private Medico CrearMedico()
        {
            Medico nuevoMed = new Medico();

            nuevoMed.Matricula = txtMatricula.Text;
            nuevoMed.Nombre = txtNombreM.Text;
            nuevoMed.Especialidad = cmbEspecialidad.SelectedItem.ToString();

            return nuevoMed;
        }

        private void txtMatricula_KeyPress(object sender, KeyPressEventArgs e)
        {
            // aceptar solo expresiones numéricas con decimales
            if (!Char.IsNumber(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != (int)Keys.Back)
            {
                e.Handled = true;
            }

            if (e.KeyChar == ',' && txtNumero.Text.Contains(","))
            {
                e.Handled = true;
            }
        }


        // GroupBox Consulta
        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (!File.Exists(Application.StartupPath + "\\" + PATH_ARCHIVO_MEDICOS))
            {
                MessageBox.Show("No hay datos para mostrar", "Consulta",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            Archivo MedicosForm = new Archivo();
            MedicosForm.NombreArchivo = PATH_ARCHIVO_MEDICOS;
            List<Medico> listaMedicos = MedicosForm.ObtenerMedicosOrdenados();
            dgvConsulta.Rows.Clear();

            foreach (Medico med in listaMedicos)
            {
                if (med.Especialidad == cmbConsulta.SelectedItem.ToString())
                {
                    dgvConsulta.Rows.Add(med.Matricula, med.Nombre);
                }
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            string Linea;
            string NombreEnArchivo;

            if (PATH_ARCHIVO_ESPECIALIDADES != "" && File.Exists(PATH_ARCHIVO_ESPECIALIDADES))
            {
                StreamReader sr = new StreamReader(PATH_ARCHIVO_ESPECIALIDADES); // Abrir

                while (sr.EndOfStream == false)
                {
                    Linea = sr.ReadLine(); // Leer

                    NombreEnArchivo = Linea.Split(',')[1];

                    cmbEspecialidad.Items.Add(NombreEnArchivo);
                    cmbConsulta.Items.Add(NombreEnArchivo);
                }
                sr.Close(); // Cerrar
                sr.Dispose();
            }
        }
    }
}