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
    public partial class cuAtencion : UserControl
    {
        List<Paciente> pacientes = ConexionBDManager.ObtenerInstancia().Pacientes;
        List<Medicamento> medicamentos = ConexionBDManager.ObtenerInstancia().Medicamentos;
        public cuAtencion()
        {
            InitializeComponent();
            // Configuración de la tabla
            dgvAtencion.AllowUserToResizeRows = false;
            dgvAtencion.AllowUserToAddRows = false;
            dgvAtencion.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAtencion.RowHeadersVisible = false;
            dgvAtencion.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAtencion.MultiSelect = false;
            dgvAtencion.ReadOnly = true;
            // Combo de pacientes
            cmbAtencion_Paciente.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbAtencion_Paciente.DisplayMember = "Nombre";
            cmbAtencion_Paciente.DataSource = new List<Paciente>(pacientes);
            cmbAtencion_Paciente.SelectedIndex = -1;
            // Combo de medicamentos
            cmbAtencion_Medicamento.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbAtencion_Medicamento.DisplayMember = "NombreComercial";
            cmbAtencion_Medicamento.DataSource = new List<Medicamento>(medicamentos);
            cmbAtencion_Medicamento.SelectedIndex = -1;
            // Cantidad
            nudAtencion_Cantidad.Minimum = 1;
            nudAtencion_Cantidad.Maximum = 100;
            nudAtencion_Cantidad.Value = 1;
            ActualizarTabla();
        }

        // METODOS
        private void ActualizarTabla()
        {
            dgvAtencion.Columns.Clear();
            dgvAtencion.Rows.Clear();
            dgvAtencion.Columns.Add("id", "ID");
            dgvAtencion.Columns.Add("fecha", "Fecha");
            dgvAtencion.Columns.Add("diagnostico", "Diagnóstico");
            dgvAtencion.Columns.Add("tratamiento", "Tratamiento");
            dgvAtencion.Columns.Add("receta", "Receta");

            Paciente paciente = cmbAtencion_Paciente.SelectedItem as Paciente;
            if (paciente == null)
            {
                return;
            }

            foreach (AtencionMedica a in paciente.ConsultarHistorial().OrderByDescending(x => x.FechaAtencion))
            {
                dgvAtencion.Rows.Add(
                    a.IdAtencion, a.FechaAtencion.ToString("dd/MM/yyyy HH:mm"),
                    a.Diagnostico, a.Tratamiento, a.ResumenReceta());
            }
        }
        private void Aviso(string mensaje, MessageBoxIcon icono)
        {
            MessageBox.Show(mensaje, "Atención médica", MessageBoxButtons.OK, icono);
        }

        private int SiguienteNumeroAtencion()
        {
            int mayor = 0;
            foreach (Paciente p in pacientes)
            {
                foreach (AtencionMedica a in p.ConsultarHistorial())
                {
                    int numero = int.Parse(a.IdAtencion.Substring(3));
                    if (numero > mayor)
                    {
                        mayor = numero;
                    }
                }
            }
            return mayor + 1;
        }

        private AtencionMedica ObtenerAtencionSeleccionada()
        {
            Paciente paciente = cmbAtencion_Paciente.SelectedItem as Paciente;
            if (paciente == null)
            {
                throw new ArgumentException("Seleccione un paciente.");
            }
            string id = dgvAtencion.SelectedRows[0].Cells[0].Value.ToString();
            foreach (AtencionMedica a in paciente.ConsultarHistorial())
            {
                if (a.IdAtencion == id)
                {
                    return a;
                }
            }
            throw new ArgumentException("No se encontró la atención seleccionada.");
        }

        // EVENTOS

        private void btnAtencion_Guardar_Click(object sender, EventArgs e)
        {
            try
            {
                Paciente paciente = cmbAtencion_Paciente.SelectedItem as Paciente;
                if (paciente == null)
                {
                    throw new ArgumentException("Seleccione un paciente.");
                }

                AtencionMedica atencion = new AtencionMedica(
                    $"AT-{SiguienteNumeroAtencion():0000}",
                    txtAtencion_Diagnostico.Text,
                    txtAtencion_Tratamiento.Text,
                    DateTime.Now);

                paciente.AgregarAtencion(atencion);
                ActualizarTabla();
                txtAtencion_Diagnostico.Clear();
                txtAtencion_Tratamiento.Clear();
            }
            catch (ArgumentException ex)
            {
                Aviso(ex.Message, MessageBoxIcon.Warning);
            }
            catch (Exception)
            {
                Aviso("Ocurrió un error inesperado al registrar la atención.", MessageBoxIcon.Error);
            }
        }

        private void btnAtencion_Diagnostico_Click(object sender, EventArgs e)
        {
            try
            {
                AtencionMedica atencion = ObtenerAtencionSeleccionada();
                atencion.RegistrarDiagnostico(txtAtencion_Diagnostico.Text);
                ActualizarTabla();
                txtAtencion_Diagnostico.Clear();
            }
            catch (ArgumentOutOfRangeException)
            {
                Aviso("Seleccione una atención de la tabla.", MessageBoxIcon.Information);
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

        private void btnAtencion_Recetar_Click(object sender, EventArgs e)
        {
            try
            {
                AtencionMedica atencion = ObtenerAtencionSeleccionada();
                Medicamento medicamento = cmbAtencion_Medicamento.SelectedItem as Medicamento;
                atencion.GenerarReceta(medicamento, (int)nudAtencion_Cantidad.Value);
                ActualizarTabla();
            }
            catch (ArgumentOutOfRangeException)
            {
                Aviso("Seleccione una atención de la tabla.", MessageBoxIcon.Information);
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

        private void cmbAtencion_Paciente_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActualizarTabla();
        }
    }
}
