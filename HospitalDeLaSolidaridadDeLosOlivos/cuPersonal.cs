using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalDeLaSolidaridadDeLosOlivos
{
    public partial class cuPersonal : UserControl
    {
        List<PersonalSalud> personal = ConexionBDManager.ObtenerInstancia().Personal;
        public cuPersonal()
        {
            InitializeComponent();
            //Configuración inicial de la tabla
            dgvPersonal.AllowUserToResizeRows = false;
            dgvPersonal.AllowUserToAddRows = false;
            dgvPersonal.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPersonal.RowHeadersVisible = false;
            dgvPersonal.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPersonal.MultiSelect = false;
            dgvPersonal.ReadOnly = true;
            ActualizarTabla();
            //Comfiguración inicial del ComboBox del especialidad
            cmbPersonal_Especialidad.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPersonal_Especialidad.Items.AddRange(PersonalSalud.EspecialidadesValidas);
            cmbPersonal_Especialidad.SelectedIndex = -1;
        }

        // METODOS
        private void ActualizarTabla()
        {
            dgvPersonal.Columns.Clear();
            dgvPersonal.Rows.Clear();
            dgvPersonal.Columns.Add("id", "ID");
            dgvPersonal.Columns.Add("nombre", "Nombre");
            dgvPersonal.Columns.Add("dni", "DNI");
            dgvPersonal.Columns.Add("telefono", "Teléfono");
            dgvPersonal.Columns.Add("cmp", "Colegiatura");
            dgvPersonal.Columns.Add("especialidad", "Especialidad");
            dgvPersonal.Columns.Add("disponible", "Disponible");

            foreach (PersonalSalud ps in personal)
            {
                dgvPersonal.Rows.Add(
                    ps.IdPersona, ps.Nombre, ps.ObtenerIdentificadorSeguro(),
                    ps.Telefono, ps.ColegiaturaCMP, ps.Especialidad,
                    ps.EstadoDisponibilidad ? "Sí" : "No");
            }
        }

        // EVENTOS
        private void btnPersonal_Guardar_Click(object sender, EventArgs e)
        {
            try
            {
                int n = personal.Count == 0 ? 1 : personal.Max(x => int.Parse(x.IdPersona.Substring(3))) + 1;
                PersonalSalud p = new PersonalSalud(
                    $"PS-{n:0000}",
                    txtPersonal_Nombre.Text,
                    txtPersonal_DNI.Text,
                    txtPersonal_Telefono.Text,
                    txtPersonal_CMP.Text,
                    cmbPersonal_Especialidad.Text);

                foreach (PersonalSalud ps in personal)
                {
                    if (ps.Dni == p.Dni)
                    {
                        throw new ArgumentException("Ya existe personal con ese DNI.");
                    }
                }

                personal.Add(p);
                ActualizarTabla();

                txtPersonal_Nombre.Clear();
                txtPersonal_DNI.Clear();
                txtPersonal_Telefono.Clear();
                txtPersonal_CMP.Clear();
                cmbPersonal_Especialidad.SelectedIndex = -1;
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Dato inválido",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            catch (Exception)
            {
                MessageBox.Show(
                    "Ocurrió un error inesperado al guardar.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnPersonal_Eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                string id = dgvPersonal.SelectedRows[0].Cells[0].Value.ToString();
                personal.RemoveAll(p => p.IdPersona == id);
                ActualizarTabla();
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Seleccione un profesional de la tabla.", "Selección inválida",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}