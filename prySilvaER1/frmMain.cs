using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prySilvaER1
{
    public partial class frmMain : Form
    {
        // Models
        class Especialidad
        {
            public int Numero { get; set; }
            public string Nombre { get; set; }

            public override string ToString()
            {
                return Nombre;
            }
        }

        class Medico
        {
            public int Matricula { get; set; }
            public string Nombre { get; set; }
            public int EspecialidadNumero { get; set; }
        }

        // Data storage (in-memory)
        private List<Especialidad> especialidades = new List<Especialidad>();
        private List<Medico> medicos = new List<Medico>();

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            // Optionally preload some data
            // Bind combo boxes
            RefreshEspecialidadesCombos();

            // Prepare DataGridView columns
            dgvMedicos.AutoGenerateColumns = false;
            dgvMedicos.Columns.Clear();
            dgvMedicos.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Matricula", HeaderText = "Matrícula", DataPropertyName = "Matricula", Width = 80 });
            dgvMedicos.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Nombre", HeaderText = "Nombre", DataPropertyName = "Nombre", Width = 150 });
        }

        private void RefreshEspecialidadesCombos()
        {
            // For medicos entry
            cmbMedEspecialidad.DataSource = null;
            cmbMedEspecialidad.DataSource = especialidades.ToList();
            cmbMedEspecialidad.DisplayMember = "Nombre";
            cmbMedEspecialidad.ValueMember = "Numero";

            // For consulta
            cmbEspecialidadesConsulta.DataSource = null;
            cmbEspecialidadesConsulta.DataSource = especialidades.ToList();
            cmbEspecialidadesConsulta.DisplayMember = "Nombre";
            cmbEspecialidadesConsulta.ValueMember = "Numero";
        }

        private void btnAgregarEspecialidad_Click(object sender, EventArgs e)
        {
            // Validations
            if (string.IsNullOrWhiteSpace(txtEspecialidadId.Text))
            {
                MessageBox.Show("Ingrese número de especialidad.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(txtEspecialidadId.Text.Trim(), out int numero))
            {
                MessageBox.Show("Número de especialidad inválido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string nombre = txtEspecialidadNombre.Text?.Trim();
            if (string.IsNullOrWhiteSpace(nombre))
            {
                MessageBox.Show("Ingrese nombre de la especialidad.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (especialidades.Any(x => x.Numero == numero))
            {
                MessageBox.Show("Número de especialidad repetido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            especialidades.Add(new Especialidad() { Numero = numero, Nombre = nombre });
            RefreshEspecialidadesCombos();

            txtEspecialidadId.Clear();
            txtEspecialidadNombre.Clear();
            txtEspecialidadId.Focus();
        }

        private void btnAgregarMedico_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMatricula.Text))
            {
                MessageBox.Show("Ingrese matrícula del médico.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(txtMatricula.Text.Trim(), out int matricula))
            {
                MessageBox.Show("Matrícula inválida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string nombre = txtMedicoNombre.Text?.Trim();
            if (string.IsNullOrWhiteSpace(nombre))
            {
                MessageBox.Show("Ingrese nombre del médico.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (cmbMedEspecialidad.SelectedItem == null)
            {
                MessageBox.Show("Seleccione una especialidad para el médico.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int especialidadNumero = ((Especialidad)cmbMedEspecialidad.SelectedItem).Numero;

            if (medicos.Any(m => m.Matricula == matricula))
            {
                MessageBox.Show("Matrícula de médico repetida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            medicos.Add(new Medico() { Matricula = matricula, Nombre = nombre, EspecialidadNumero = especialidadNumero });

            txtMatricula.Clear();
            txtMedicoNombre.Clear();
            cmbMedEspecialidad.SelectedIndex = -1;
            txtMatricula.Focus();

            // If currently selected consult specialty matches, refresh grid
            if (cmbEspecialidadesConsulta.SelectedItem != null && ((Especialidad)cmbEspecialidadesConsulta.SelectedItem).Numero == especialidadNumero)
            {
                PopulateMedicosGrid(especialidadNumero);
            }
        }

        private void cmbEspecialidadesConsulta_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbEspecialidadesConsulta.SelectedItem == null)
            {
                dgvMedicos.DataSource = null;
                return;
            }

            int numero = ((Especialidad)cmbEspecialidadesConsulta.SelectedItem).Numero;
            PopulateMedicosGrid(numero);
        }

        private void PopulateMedicosGrid(int especialidadNumero)
        {
            var lista = medicos.Where(m => m.EspecialidadNumero == especialidadNumero)
                               .Select(m => new { m.Matricula, m.Nombre })
                               .ToList();
            dgvMedicos.DataSource = lista;
        }
    }
}