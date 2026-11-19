using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalDeLaSolidaridadDeLosOlivos
{
    public partial class cuPacientes : UserControl
    {
        List<Paciente> pacientes = new List<Paciente>
        {
            new Paciente("Ana Torres", "71131346", "910248156"),
            new Paciente("Luis Rojas", "23696822", "992141574"),
            new Paciente("María Quispe", "82717431", "933437900")
        };

        public cuPacientes()
        {
            InitializeComponent();
            //Configuracion inicial de la tabla
            ActualizarTabla();
            dgvPacientes.AllowUserToResizeRows = false;
            dgvPacientes.AllowUserToAddRows = false;
            dgvPacientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPacientes.RowHeadersVisible = false;
            dgvPacientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPacientes.MultiSelect = false;
            dgvPacientes.ReadOnly = true;
            //Datos iniciales

        }

        private void ActualizarTabla()
        {
            dgvPacientes.Columns.Clear();
            dgvPacientes.Rows.Clear();
            dgvPacientes.Columns.Add("nombre", "Nombre");
            dgvPacientes.Columns.Add("dni", "DNI");
            dgvPacientes.Columns.Add("telefono", "Telefono");

            foreach (Paciente p in pacientes)
            {
                dgvPacientes.Rows.Add(p.Nombre, p.Dni, p.Telefono);
            }
        }
        private void btnPacientes_Guardar_Click(object sender, EventArgs e)
        {
            try
            {
                Paciente p = new Paciente(txtPaciente_Nombre.Text, txtPaciente_DNI.Text, txtPaciente_Telefono.Text);

                pacientes.Add(p);
                ActualizarTabla();

                txtPaciente_Nombre.Clear();
                txtPaciente_DNI.Clear();
                txtPaciente_Telefono.Clear();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Dato inválido",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnPacientes_Eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                string Dni = dgvPacientes.SelectedRows[0].Cells[1].Value.ToString();
                pacientes.RemoveAll(p => p.Dni == Dni);
                ActualizarTabla();
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show(
                    "Seleccione un paciente de la tabla.",
                    "Selección inválida",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }
    }
}
