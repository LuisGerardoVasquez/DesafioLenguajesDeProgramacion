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
            new Paciente("PC-0001", "Ana Torres", "71131346", "910248156", "HC-0001", new DateTime(1990, 5, 14), "O+"),
            new Paciente("PC-0002", "Luis Rojas", "23696822", "992141574", "HC-0002", new DateTime(1985, 11, 2), "B+"),
            new Paciente("PC-0003", "María Quispe", "82717431", "933437900", "HC-0003", new DateTime(2001, 3, 27), "A-")
        };

        public cuPacientes()
        {
            InitializeComponent();
            //Configuración inicial de la tabla
            ActualizarTabla();
            dgvPacientes.AllowUserToResizeRows = false;
            dgvPacientes.AllowUserToAddRows = false;
            dgvPacientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPacientes.RowHeadersVisible = false;
            dgvPacientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPacientes.MultiSelect = false;
            dgvPacientes.ReadOnly = true;
            //Comfiguración inicial del ComboBox del tipo de sangre
            cmbPaciente_Sangre.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPaciente_Sangre.Items.AddRange(Paciente.TiposSangreValidos);
            cmbPaciente_Sangre.SelectedIndex = -1;
            // Configuración inicial del DataTimePicker de la fecha de nacimiento
            dtpPaciente_Nacimiento.Format = DateTimePickerFormat.Short;
            dtpPaciente_Nacimiento.MaxDate = DateTime.Today;
        }

        private void ActualizarTabla()
        {
            dgvPacientes.Columns.Clear();
            dgvPacientes.Rows.Clear();
            dgvPacientes.Columns.Add("id", "ID");
            dgvPacientes.Columns.Add("historia", "Historia");
            dgvPacientes.Columns.Add("nombre", "Nombre");
            dgvPacientes.Columns.Add("dni", "DNI");
            dgvPacientes.Columns.Add("telefono", "Teléfono");
            dgvPacientes.Columns.Add("nacimiento", "Nacimiento");
            dgvPacientes.Columns.Add("sangre", "Sangre");

            foreach (Paciente p in pacientes.OrderBy(x => x.Nombre))
            {
                dgvPacientes.Rows.Add(
                    p.IdPersona, p.NumeroHistoriaClinica, p.Nombre,
                    p.ObtenerIdentificadorSeguro(), p.Telefono,
                    p.FechaNacimiento.ToString("dd/MM/yyyy"), p.TipoSangre);
            }
        }
        private void btnPacientes_Guardar_Click(object sender, EventArgs e)
        {
            try
            {
                int n = pacientes.Count + 1;

                Paciente p = new Paciente(
                    $"PC-{n:0000}",
                    txtPaciente_Nombre.Text,
                    txtPaciente_DNI.Text,
                    txtPaciente_Telefono.Text,
                    $"HC-{n:0000}",
                    dtpPaciente_Nacimiento.Value,
                    cmbPaciente_Sangre.Text);

                pacientes.Add(p);
                ActualizarTabla();

                txtPaciente_Nombre.Clear();
                txtPaciente_DNI.Clear();
                txtPaciente_Telefono.Clear();
                cmbPaciente_Sangre.SelectedIndex = -1;
                dtpPaciente_Nacimiento.Value = DateTime.Today;
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
