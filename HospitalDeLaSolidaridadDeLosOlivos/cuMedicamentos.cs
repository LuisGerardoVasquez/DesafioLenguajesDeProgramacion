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
    public partial class cuMedicamentos : UserControl
    {
        List<Medicamento> medicamentos = ConexionBDManager.ObtenerInstancia().Medicamentos;

        public cuMedicamentos()
        {
            InitializeComponent();
            // Configuración de la tabla
            dgvMedicamentos.AllowUserToResizeRows = false;
            dgvMedicamentos.AllowUserToAddRows = false;
            dgvMedicamentos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMedicamentos.RowHeadersVisible = false;
            dgvMedicamentos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMedicamentos.MultiSelect = false;
            dgvMedicamentos.ReadOnly = true;
            ActualizarTabla();
            // Configuración del NumericUpDown de cantidad
            nudMedicamento_Cantidad.Minimum = 1;
            nudMedicamento_Cantidad.Maximum = 10000;
            nudMedicamento_Cantidad.Value = 1;
        }

        // METODOS
        private void ActualizarTabla()
        {
            dgvMedicamentos.Columns.Clear();
            dgvMedicamentos.Rows.Clear();
            dgvMedicamentos.Columns.Add("id", "ID");
            dgvMedicamentos.Columns.Add("nombre", "Medicamento");
            dgvMedicamentos.Columns.Add("stock", "Stock");
            dgvMedicamentos.Columns.Add("estado", "Estado");

            foreach (Medicamento m in medicamentos)
            {
                dgvMedicamentos.Rows.Add(
                    m.IdMedicamento, m.NombreComercial, m.StockDisponible,
                    m.VerificarDisponibilidad() ? "Disponible" : "Agotado");
            }
        }

        private void CambiarStock(int cantidad)
        {
            try
            {
                string id = dgvMedicamentos.SelectedRows[0].Cells[0].Value.ToString();
                foreach (Medicamento m in medicamentos)
                {
                    if (m.IdMedicamento == id)
                    {
                        m.ActualizarStock(cantidad);
                        break;
                    }
                }
                ActualizarTabla();
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Seleccione un medicamento de la tabla.", "Selección inválida",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Stock inválido",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrió un error inesperado.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // EVENTOS
        private void btnMedicamento_Guardar_Click(object sender, EventArgs e)
        {
            try
            {
                int n = medicamentos.Count == 0 ? 1 : medicamentos.Max(x => int.Parse(x.IdMedicamento.Substring(3))) + 1;
                Medicamento m = new Medicamento(
                    $"MD-{n:0000}",
                    txtMedicamento_Nombre.Text,
                    (int)nudMedicamento_Cantidad.Value);

                foreach (Medicamento existente in medicamentos)
                {
                    if (existente.NombreComercial.ToLower() == m.NombreComercial.ToLower())
                    {
                        throw new ArgumentException("Ya existe un medicamento con el mismo nombre.");
                    }
                }

                medicamentos.Add(m);
                ActualizarTabla();
                txtMedicamento_Nombre.Clear();
                nudMedicamento_Cantidad.Value = 1;
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Dato inválido",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrió un error inesperado al guardar.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnMedicamento_Ingreso_Click(object sender, EventArgs e)
        {
            CambiarStock((int)nudMedicamento_Cantidad.Value);
        }
        private void btnMedicamento_Salida_Click(object sender, EventArgs e)
        {
            CambiarStock(-(int)nudMedicamento_Cantidad.Value);
        }
        private void btnMedicamento_Eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                string id = dgvMedicamentos.SelectedRows[0].Cells[0].Value.ToString();
                medicamentos.RemoveAll(m => m.IdMedicamento == id);
                ActualizarTabla();
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Seleccione un medicamento de la tabla.", "Selección inválida",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
