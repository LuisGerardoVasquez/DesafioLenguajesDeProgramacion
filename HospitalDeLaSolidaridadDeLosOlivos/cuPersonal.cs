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
    public partial class cuPersonal : UserControl
    {
        List<PersonalSalud> personal = new List<PersonalSalud>
        {
            new PersonalSalud("PS-0001", "Dr. Ricardo Medina", "41256873", "987123456", "45821", "Medicina general"),
            new PersonalSalud("PS-0002", "Dra. Patricia León", "33718492", "956234781", "38210", "Pediatría"),
            new PersonalSalud("PS-0003", "Lic. Sandra Quiroz", "70521364", "934567218", "62874", "Enfermería"),
            new PersonalSalud("PS-0004", "Obst. Karen Flores", "48193627", "921876543", "57439", "Obstetricia"),
            new PersonalSalud("PS-0005", "Ps. Daniel Alva", "62459187", "945671238", "71352", "Psicología"),
            new PersonalSalud("PS-0006", "Lic. Mariana Soto", "53217894", "968123745", "49083", "Nutrición"),
            new PersonalSalud("PS-0007", "Lic. Hugo Benavides", "36874215", "912345678", "53167", "Podología"),
            new PersonalSalud("PS-0008", "Dr. Alberto Cruz", "29846153", "968345127", "29716", "Medicina general"),
            new PersonalSalud("PS-0009", "Dra. Julia Ortega", "74382951", "977654321", "66240", "Pediatría"),
            new PersonalSalud("PS-0010", "Lic. Rosa Delgado", "41729638", "935482176", "58904", "Enfermería")
        };
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