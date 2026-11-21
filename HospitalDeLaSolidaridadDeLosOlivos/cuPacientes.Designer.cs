namespace HospitalDeLaSolidaridadDeLosOlivos
{
    partial class cuPacientes
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTituloPacientes = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblDNI = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.txtPaciente_Nombre = new System.Windows.Forms.TextBox();
            this.txtPaciente_DNI = new System.Windows.Forms.TextBox();
            this.txtPaciente_Telefono = new System.Windows.Forms.TextBox();
            this.btnPacientes_Guardar = new System.Windows.Forms.Button();
            this.btnPacientes_Eliminar = new System.Windows.Forms.Button();
            this.dgvPacientes = new System.Windows.Forms.DataGridView();
            this.dtpPaciente_Nacimiento = new System.Windows.Forms.DateTimePicker();
            this.cmbPaciente_Sangre = new System.Windows.Forms.ComboBox();
            this.lblSangre = new System.Windows.Forms.Label();
            this.lblFechaDeNacimiento = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacientes)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTituloPacientes
            // 
            this.lblTituloPacientes.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold);
            this.lblTituloPacientes.Location = new System.Drawing.Point(66, 31);
            this.lblTituloPacientes.Name = "lblTituloPacientes";
            this.lblTituloPacientes.Size = new System.Drawing.Size(169, 27);
            this.lblTituloPacientes.TabIndex = 0;
            this.lblTituloPacientes.Text = "Pacientes";
            this.lblTituloPacientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblNombre
            // 
            this.lblNombre.Font = new System.Drawing.Font("Arial", 10F);
            this.lblNombre.Location = new System.Drawing.Point(66, 76);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(110, 30);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            this.lblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDNI
            // 
            this.lblDNI.Font = new System.Drawing.Font("Arial", 10F);
            this.lblDNI.Location = new System.Drawing.Point(66, 114);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(110, 30);
            this.lblDNI.TabIndex = 0;
            this.lblDNI.Text = "DNI";
            this.lblDNI.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTelefono
            // 
            this.lblTelefono.Font = new System.Drawing.Font("Arial", 10F);
            this.lblTelefono.Location = new System.Drawing.Point(66, 152);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(110, 30);
            this.lblTelefono.TabIndex = 0;
            this.lblTelefono.Text = "Telefono";
            this.lblTelefono.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtPaciente_Nombre
            // 
            this.txtPaciente_Nombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPaciente_Nombre.Font = new System.Drawing.Font("Arial", 10F);
            this.txtPaciente_Nombre.Location = new System.Drawing.Point(180, 76);
            this.txtPaciente_Nombre.Name = "txtPaciente_Nombre";
            this.txtPaciente_Nombre.Size = new System.Drawing.Size(172, 27);
            this.txtPaciente_Nombre.TabIndex = 1;
            // 
            // txtPaciente_DNI
            // 
            this.txtPaciente_DNI.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPaciente_DNI.Font = new System.Drawing.Font("Arial", 10F);
            this.txtPaciente_DNI.Location = new System.Drawing.Point(180, 114);
            this.txtPaciente_DNI.Name = "txtPaciente_DNI";
            this.txtPaciente_DNI.Size = new System.Drawing.Size(172, 27);
            this.txtPaciente_DNI.TabIndex = 1;
            // 
            // txtPaciente_Telefono
            // 
            this.txtPaciente_Telefono.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPaciente_Telefono.Font = new System.Drawing.Font("Arial", 10F);
            this.txtPaciente_Telefono.Location = new System.Drawing.Point(180, 152);
            this.txtPaciente_Telefono.Name = "txtPaciente_Telefono";
            this.txtPaciente_Telefono.Size = new System.Drawing.Size(172, 27);
            this.txtPaciente_Telefono.TabIndex = 1;
            // 
            // btnPacientes_Guardar
            // 
            this.btnPacientes_Guardar.Font = new System.Drawing.Font("Arial", 10F);
            this.btnPacientes_Guardar.Location = new System.Drawing.Point(66, 233);
            this.btnPacientes_Guardar.Name = "btnPacientes_Guardar";
            this.btnPacientes_Guardar.Size = new System.Drawing.Size(110, 40);
            this.btnPacientes_Guardar.TabIndex = 2;
            this.btnPacientes_Guardar.Text = "Guardar";
            this.btnPacientes_Guardar.UseVisualStyleBackColor = true;
            this.btnPacientes_Guardar.Click += new System.EventHandler(this.btnPacientes_Guardar_Click);
            // 
            // btnPacientes_Eliminar
            // 
            this.btnPacientes_Eliminar.Font = new System.Drawing.Font("Arial", 10F);
            this.btnPacientes_Eliminar.Location = new System.Drawing.Point(186, 233);
            this.btnPacientes_Eliminar.Name = "btnPacientes_Eliminar";
            this.btnPacientes_Eliminar.Size = new System.Drawing.Size(110, 40);
            this.btnPacientes_Eliminar.TabIndex = 2;
            this.btnPacientes_Eliminar.Text = "Eliminar";
            this.btnPacientes_Eliminar.UseVisualStyleBackColor = true;
            this.btnPacientes_Eliminar.Click += new System.EventHandler(this.btnPacientes_Eliminar_Click);
            // 
            // dgvPacientes
            // 
            this.dgvPacientes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPacientes.Location = new System.Drawing.Point(66, 283);
            this.dgvPacientes.Name = "dgvPacientes";
            this.dgvPacientes.RowHeadersWidth = 51;
            this.dgvPacientes.RowTemplate.Height = 24;
            this.dgvPacientes.Size = new System.Drawing.Size(600, 241);
            this.dgvPacientes.TabIndex = 3;
            // 
            // dtpPaciente_Nacimiento
            // 
            this.dtpPaciente_Nacimiento.CalendarFont = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpPaciente_Nacimiento.Location = new System.Drawing.Point(396, 99);
            this.dtpPaciente_Nacimiento.Name = "dtpPaciente_Nacimiento";
            this.dtpPaciente_Nacimiento.Size = new System.Drawing.Size(270, 22);
            this.dtpPaciente_Nacimiento.TabIndex = 4;
            // 
            // cmbPaciente_Sangre
            // 
            this.cmbPaciente_Sangre.Font = new System.Drawing.Font("Arial", 10F);
            this.cmbPaciente_Sangre.FormattingEnabled = true;
            this.cmbPaciente_Sangre.Location = new System.Drawing.Point(180, 190);
            this.cmbPaciente_Sangre.Name = "cmbPaciente_Sangre";
            this.cmbPaciente_Sangre.Size = new System.Drawing.Size(172, 27);
            this.cmbPaciente_Sangre.TabIndex = 5;
            // 
            // lblSangre
            // 
            this.lblSangre.Font = new System.Drawing.Font("Arial", 10F);
            this.lblSangre.Location = new System.Drawing.Point(67, 190);
            this.lblSangre.Name = "lblSangre";
            this.lblSangre.Size = new System.Drawing.Size(110, 30);
            this.lblSangre.TabIndex = 0;
            this.lblSangre.Text = "Sangre";
            this.lblSangre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblFechaDeNacimiento
            // 
            this.lblFechaDeNacimiento.Font = new System.Drawing.Font("Arial", 10F);
            this.lblFechaDeNacimiento.Location = new System.Drawing.Point(392, 66);
            this.lblFechaDeNacimiento.Name = "lblFechaDeNacimiento";
            this.lblFechaDeNacimiento.Size = new System.Drawing.Size(274, 30);
            this.lblFechaDeNacimiento.TabIndex = 0;
            this.lblFechaDeNacimiento.Text = "Fecha de Nacimiento";
            this.lblFechaDeNacimiento.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cuPacientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cmbPaciente_Sangre);
            this.Controls.Add(this.dtpPaciente_Nacimiento);
            this.Controls.Add(this.dgvPacientes);
            this.Controls.Add(this.btnPacientes_Eliminar);
            this.Controls.Add(this.btnPacientes_Guardar);
            this.Controls.Add(this.txtPaciente_Telefono);
            this.Controls.Add(this.txtPaciente_DNI);
            this.Controls.Add(this.txtPaciente_Nombre);
            this.Controls.Add(this.lblSangre);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.lblDNI);
            this.Controls.Add(this.lblFechaDeNacimiento);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblTituloPacientes);
            this.Name = "cuPacientes";
            this.Size = new System.Drawing.Size(732, 553);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTituloPacientes;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblDNI;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.TextBox txtPaciente_Nombre;
        private System.Windows.Forms.TextBox txtPaciente_DNI;
        private System.Windows.Forms.TextBox txtPaciente_Telefono;
        private System.Windows.Forms.Button btnPacientes_Guardar;
        private System.Windows.Forms.Button btnPacientes_Eliminar;
        private System.Windows.Forms.DataGridView dgvPacientes;
        private System.Windows.Forms.DateTimePicker dtpPaciente_Nacimiento;
        private System.Windows.Forms.ComboBox cmbPaciente_Sangre;
        private System.Windows.Forms.Label lblSangre;
        private System.Windows.Forms.Label lblFechaDeNacimiento;
    }
}
