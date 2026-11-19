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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //Configuración inicial de la pantalla principal
            CargarModulo(new cuPacientes());
            BotonMenuSeleccionado(btnPacientes);

        }
        private void CargarModulo(UserControl modulo)
        {
            panelContenido.Controls.Clear();
            modulo.Dock = DockStyle.Fill;
            panelContenido.Controls.Add(modulo);
        }

        private void BotonMenuSeleccionado(Button boton)
        {
            boton.BackColor = Color.FromArgb(60, 120, 180);
            boton.Font = new Font(boton.Font, FontStyle.Bold);
            foreach (Button b in panelMenu.Controls)
            {
                if (b != boton)
                {
                    BotonMenuNoSeleccionado(b);
                }
            }
        }
        private void BotonMenuNoSeleccionado(Button boton)
        {
            boton.BackColor = Color.FromArgb(30, 60, 90);
            boton.Font = new Font(boton.Font, FontStyle.Regular);
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnPacientes_Click(object sender, EventArgs e)
        {
            BotonMenuSeleccionado(btnPacientes);
            CargarModulo(new cuPacientes());
        }

        private void btnCitas_Click(object sender, EventArgs e)
        {
            BotonMenuSeleccionado(btnCitas);
            CargarModulo(new cuCitas());
        }

        private void btnPersonalDeSalud_Click(object sender, EventArgs e)
        {
            BotonMenuSeleccionado(btnPersonalDeSalud);
            CargarModulo(new cuPersonal());
        }

        private void btnMedicamentos_Click(object sender, EventArgs e)
        {
            BotonMenuSeleccionado(btnMedicamentos);
            CargarModulo(new cuMedicamentos());
        }

        private void btnAtencion_Click(object sender, EventArgs e)
        {
            BotonMenuSeleccionado(btnAtencion);
            CargarModulo(new cuAtencion());
        }
    }
}
