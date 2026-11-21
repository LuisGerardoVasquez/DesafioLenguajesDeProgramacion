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
    public partial class cuCitas : UserControl
    {
        List<CitaMedica> citas = ConexionBDManager.ObtenerInstancia().Citas;
        List<Paciente> pacientes = ConexionBDManager.ObtenerInstancia().Pacientes;
        List<PersonalSalud> personal = ConexionBDManager.ObtenerInstancia().Personal;
        public cuCitas()
        {
            InitializeComponent();
            // Configuración de la tabla
            dgvCitas.AllowUserToResizeRows = false;
            dgvCitas.AllowUserToAddRows = false;
            dgvCitas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCitas.RowHeadersVisible = false;
            dgvCitas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCitas.MultiSelect = false;
            dgvCitas.ReadOnly = true;
            // Combo de pacientes (muestra el nombre)
            cmbCita_Paciente.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCita_Paciente.DisplayMember = "Nombre";
            cmbCita_Paciente.DataSource = new List<Paciente>(pacientes);
            cmbCita_Paciente.SelectedIndex = -1;
            // Combo de profesionales
            cmbCita_Medico.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCita_Medico.DisplayMember = "Nombre";
            cmbCita_Medico.DataSource = new List<PersonalSalud>(personal);
            cmbCita_Medico.SelectedIndex = -1;
            // Combo de tipo de cita
            cmbCita_Tipo.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCita_Tipo.Items.AddRange(CitaFactory.TiposValidos);
            cmbCita_Tipo.SelectedIndex = -1;
            // Fecha y hora
            dtpCita_FechaHora.Format = DateTimePickerFormat.Custom;
            dtpCita_FechaHora.CustomFormat = "dd/MM/yyyy HH:mm";
            dtpCita_FechaHora.MinDate = DateTime.Today;
            dtpCita_FechaHora.Value = DateTime.Today.AddDays(1).AddHours(9);
            // Filtro por estado
            cmbCita_Filtro.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCita_Filtro.Items.AddRange(new object[] { "Todas", "Pendiente", "Atendida", "Cancelada" });
            cmbCita_Filtro.SelectedIndex = 0;
            ActualizarTabla();
        }

        // METODOS
        private void ActualizarTabla()
        {
            dgvCitas.Columns.Clear();
            dgvCitas.Rows.Clear();
            dgvCitas.Columns.Add("id", "ID");
            dgvCitas.Columns.Add("fecha", "Fecha y hora");
            dgvCitas.Columns.Add("paciente", "Paciente");
            dgvCitas.Columns.Add("profesional", "Profesional");
            dgvCitas.Columns.Add("modalidad", "Modalidad");
            dgvCitas.Columns.Add("motivo", "Motivo");
            dgvCitas.Columns.Add("estado", "Estado");

            string filtro = cmbCita_Filtro.Text;
            IEnumerable<CitaMedica> lista = citas;
            if (filtro != "" && filtro != "Todas")
            {
                lista = lista.Where(x => x.Estado == filtro);
            }

            foreach (CitaMedica c in lista.OrderBy(x => x.FechaHora))
            {
                dgvCitas.Rows.Add(
                    c.IdCita, c.FechaHora.ToString("dd/MM/yyyy HH:mm"),
                    c.Paciente.Nombre, c.Medico.Nombre,
                    c.ObtenerModalidad(), c.Motivo, c.Estado);
            }
        }

        private void Aviso(string mensaje, MessageBoxIcon icono)
        {
            MessageBox.Show(mensaje, "Citas médicas", MessageBoxButtons.OK, icono);
        }

        private CitaMedica ObtenerCitaSeleccionada()
        {
            // Si no hay fila seleccionada, [0] lanza ArgumentOutOfRangeException
            string id = dgvCitas.SelectedRows[0].Cells[0].Value.ToString();
            foreach (CitaMedica c in citas)
            {
                if (c.IdCita == id)
                {
                    return c;
                }
            }
            throw new ArgumentException("No se encontró la cita seleccionada.");
        }

        private bool ExisteChoque(PersonalSalud medico, DateTime fecha, string idIgnorar)
        {
            foreach (CitaMedica c in citas)
            {
                if (c.IdCita != idIgnorar
                    && c.Estado != "Cancelada"
                    && c.Medico.IdPersona == medico.IdPersona
                    && c.FechaHora == fecha)
                {
                    return true;
                }
            }
            return false;
        }


        // EVENTOS
        private void cmbCita_Filtro_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActualizarTabla();
        }
        private void btnCita_Guardar_Click(object sender, EventArgs e)
        {
            try
            {
                Paciente paciente = cmbCita_Paciente.SelectedItem as Paciente;
                PersonalSalud medico = cmbCita_Medico.SelectedItem as PersonalSalud;
                if (paciente == null)
                {
                    throw new ArgumentException("Seleccione un paciente.");
                }
                if (medico == null)
                {
                    throw new ArgumentException("Seleccione un profesional de salud.");
                }
                if (cmbCita_Tipo.SelectedIndex == -1)
                {
                    throw new ArgumentException("Seleccione el tipo de cita.");
                }

                int n = citas.Count == 0 ? 1 : citas.Max(x => int.Parse(x.IdCita.Substring(3))) + 1;
                CitaMedica cita = CitaFactory.CrearCita(
                    cmbCita_Tipo.Text, $"CT-{n:0000}", paciente, medico,
                    dtpCita_FechaHora.Value, txtCita_Motivo.Text);

                if (ExisteChoque(medico, cita.FechaHora, cita.IdCita))
                {
                    throw new ArgumentException("El profesional ya tiene una cita en ese horario.");
                }

                citas.Add(cita);
                ActualizarTabla();

                txtCita_Motivo.Clear();
                cmbCita_Paciente.SelectedIndex = -1;
                cmbCita_Medico.SelectedIndex = -1;
                cmbCita_Tipo.SelectedIndex = -1;
                dtpCita_FechaHora.Value = DateTime.Today.AddDays(1).AddHours(9);
            }
            catch (ArgumentException ex)
            {
                Aviso(ex.Message, MessageBoxIcon.Warning);
            }
            catch (Exception)
            {
                Aviso("Ocurrió un error inesperado al registrar la cita.", MessageBoxIcon.Error);
            }
        }

        private void btnCita_Reprogramar_Click(object sender, EventArgs e)
        {
            try
            {
                CitaMedica cita = ObtenerCitaSeleccionada();
                DateTime nueva = CitaMedica.NormalizarFecha(dtpCita_FechaHora.Value);
                if (ExisteChoque(cita.Medico, nueva, cita.IdCita))
                {
                    throw new ArgumentException("El profesional ya tiene una cita en ese horario.");
                }
                cita.Reprogramar(nueva);
                ActualizarTabla();
            }
            catch (ArgumentOutOfRangeException)
            {
                Aviso("Seleccione una cita de la tabla.", MessageBoxIcon.Information);
            }
            catch (ArgumentException ex)
            {
                Aviso(ex.Message, MessageBoxIcon.Warning);
            }
            catch (Exception)
            {
                Aviso("Ocurrió un error inesperado.", MessageBoxIcon.Error);
            }
        }



        private void btnCita_Cancelar_Click(object sender, EventArgs e)
        {
            try
            {
                CitaMedica cita = ObtenerCitaSeleccionada();
                cita.CancelarCita();
                ActualizarTabla();
            }
            catch (ArgumentOutOfRangeException)
            {
                Aviso("Seleccione una cita de la tabla.", MessageBoxIcon.Information);
            }
            catch (ArgumentException ex)
            {
                Aviso(ex.Message, MessageBoxIcon.Warning);
            }
            catch (Exception)
            {
                Aviso("Ocurrió un error inesperado.", MessageBoxIcon.Error);
            }
        }

        private void btnCita_Confirmar_Click(object sender, EventArgs e)
        {
            try
            {
                CitaMedica cita = ObtenerCitaSeleccionada();
                if (!cita.ConfirmarCita())
                {
                    Aviso("Solo se puede marcar como atendida una cita pendiente.", MessageBoxIcon.Warning);
                }
                ActualizarTabla();
            }
            catch (ArgumentOutOfRangeException)
            {
                Aviso("Seleccione una cita de la tabla.", MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                Aviso("Ocurrió un error inesperado.", MessageBoxIcon.Error);
            }
        }
    }
}
