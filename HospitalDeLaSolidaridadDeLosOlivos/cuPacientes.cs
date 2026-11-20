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
            // Datos iniciales
            new Paciente("PC-0001", "Ana Torres", "71131346", "910248156", "HC-0001", new DateTime(1990, 5, 14), "O+"),
            new Paciente("PC-0002", "Luis Rojas", "23696822", "992141574", "HC-0002", new DateTime(1985, 11, 2), "B+"),
            new Paciente("PC-0003", "María Quispe", "82717431", "933437900", "HC-0003", new DateTime(2001, 3, 27), "A-"),
            new Paciente("PC-0004", "Carlos Mendoza", "45812093", "987654321", "HC-0004", new DateTime(1978, 8, 9), "AB+"),
            new Paciente("PC-0005", "Rosa Huamán", "60237415", "945128376", "HC-0005", new DateTime(1995, 1, 30), "O-"),
            new Paciente("PC-0006", "Jorge Salazar", "38291746", "921345678", "HC-0006", new DateTime(1969, 12, 3), "A+"),
            new Paciente("PC-0007", "Lucía Paredes", "72406158", "958231467", "HC-0007", new DateTime(2003, 6, 18), "B-"),
            new Paciente("PC-0008", "Miguel Vargas", "19573820", "936782145", "HC-0008", new DateTime(1982, 4, 25), "O+"),
            new Paciente("PC-0009", "Elena Chávez", "56184973", "914567823", "HC-0009", new DateTime(1990, 9, 11), "AB-"),
            new Paciente("PC-0010", "Pedro Ramírez", "80329651", "973214685", "HC-0010", new DateTime(1957, 2, 7), "A+")
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
                string id = dgvPacientes.SelectedRows[0].Cells[0].Value.ToString();
                pacientes.RemoveAll(p => p.IdPersona == id);
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
