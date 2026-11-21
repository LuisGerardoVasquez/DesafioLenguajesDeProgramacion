namespace HospitalDeLaSolidaridadDeLosOlivos
{
    partial class cuCitas
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
            this.lblMedicamentos_Titulo = new System.Windows.Forms.Label();
            this.cmbCita_Paciente = new System.Windows.Forms.ComboBox();
            this.lblCita_Paciente = new System.Windows.Forms.Label();
            this.cmbCita_Medico = new System.Windows.Forms.ComboBox();
            this.lblCita_Medico = new System.Windows.Forms.Label();
            this.cmbCita_Tipo = new System.Windows.Forms.ComboBox();
            this.lblCita_Tipo = new System.Windows.Forms.Label();
            this.dtpCita_FechaHora = new System.Windows.Forms.DateTimePicker();
            this.lblCita_FechaHora = new System.Windows.Forms.Label();
            this.txtCita_Motivo = new System.Windows.Forms.TextBox();
            this.lblCita_Motivo = new System.Windows.Forms.Label();
            this.btnCita_Guardar = new System.Windows.Forms.Button();
            this.btnCita_Reprogramar = new System.Windows.Forms.Button();
            this.btnCita_Confirmar = new System.Windows.Forms.Button();
            this.btnCita_Cancelar = new System.Windows.Forms.Button();
            this.cmbCita_Filtro = new System.Windows.Forms.ComboBox();
            this.dgvCitas = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCitas)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMedicamentos_Titulo
            // 
            this.lblMedicamentos_Titulo.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold);
            this.lblMedicamentos_Titulo.Location = new System.Drawing.Point(66, 31);
            this.lblMedicamentos_Titulo.Name = "lblMedicamentos_Titulo";
            this.lblMedicamentos_Titulo.Size = new System.Drawing.Size(266, 27);
            this.lblMedicamentos_Titulo.TabIndex = 2;
            this.lblMedicamentos_Titulo.Text = "Citas Medicas";
            this.lblMedicamentos_Titulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbCita_Paciente
            // 
            this.cmbCita_Paciente.Font = new System.Drawing.Font("Arial", 10F);
            this.cmbCita_Paciente.FormattingEnabled = true;
            this.cmbCita_Paciente.Location = new System.Drawing.Point(175, 76);
            this.cmbCita_Paciente.Name = "cmbCita_Paciente";
            this.cmbCita_Paciente.Size = new System.Drawing.Size(172, 27);
            this.cmbCita_Paciente.TabIndex = 10;
            // 
            // lblCita_Paciente
            // 
            this.lblCita_Paciente.Font = new System.Drawing.Font("Arial", 10F);
            this.lblCita_Paciente.Location = new System.Drawing.Point(66, 76);
            this.lblCita_Paciente.Name = "lblCita_Paciente";
            this.lblCita_Paciente.Size = new System.Drawing.Size(110, 30);
            this.lblCita_Paciente.TabIndex = 11;
            this.lblCita_Paciente.Text = "Paciente";
            this.lblCita_Paciente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbCita_Medico
            // 
            this.cmbCita_Medico.Font = new System.Drawing.Font("Arial", 10F);
            this.cmbCita_Medico.FormattingEnabled = true;
            this.cmbCita_Medico.Location = new System.Drawing.Point(175, 114);
            this.cmbCita_Medico.Name = "cmbCita_Medico";
            this.cmbCita_Medico.Size = new System.Drawing.Size(172, 27);
            this.cmbCita_Medico.TabIndex = 10;
            // 
            // lblCita_Medico
            // 
            this.lblCita_Medico.Font = new System.Drawing.Font("Arial", 10F);
            this.lblCita_Medico.Location = new System.Drawing.Point(66, 114);
            this.lblCita_Medico.Name = "lblCita_Medico";
            this.lblCita_Medico.Size = new System.Drawing.Size(110, 30);
            this.lblCita_Medico.TabIndex = 11;
            this.lblCita_Medico.Text = "Medico";
            this.lblCita_Medico.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbCita_Tipo
            // 
            this.cmbCita_Tipo.Font = new System.Drawing.Font("Arial", 10F);
            this.cmbCita_Tipo.FormattingEnabled = true;
            this.cmbCita_Tipo.Location = new System.Drawing.Point(175, 152);
            this.cmbCita_Tipo.Name = "cmbCita_Tipo";
            this.cmbCita_Tipo.Size = new System.Drawing.Size(172, 27);
            this.cmbCita_Tipo.TabIndex = 10;
            // 
            // lblCita_Tipo
            // 
            this.lblCita_Tipo.Font = new System.Drawing.Font("Arial", 10F);
            this.lblCita_Tipo.Location = new System.Drawing.Point(66, 152);
            this.lblCita_Tipo.Name = "lblCita_Tipo";
            this.lblCita_Tipo.Size = new System.Drawing.Size(110, 30);
            this.lblCita_Tipo.TabIndex = 11;
            this.lblCita_Tipo.Text = "Tipo";
            this.lblCita_Tipo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dtpCita_FechaHora
            // 
            this.dtpCita_FechaHora.CalendarFont = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpCita_FechaHora.Location = new System.Drawing.Point(396, 99);
            this.dtpCita_FechaHora.Name = "dtpCita_FechaHora";
            this.dtpCita_FechaHora.Size = new System.Drawing.Size(270, 22);
            this.dtpCita_FechaHora.TabIndex = 13;
            // 
            // lblCita_FechaHora
            // 
            this.lblCita_FechaHora.Font = new System.Drawing.Font("Arial", 10F);
            this.lblCita_FechaHora.Location = new System.Drawing.Point(392, 66);
            this.lblCita_FechaHora.Name = "lblCita_FechaHora";
            this.lblCita_FechaHora.Size = new System.Drawing.Size(274, 30);
            this.lblCita_FechaHora.TabIndex = 12;
            this.lblCita_FechaHora.Text = "Fecha";
            this.lblCita_FechaHora.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtCita_Motivo
            // 
            this.txtCita_Motivo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCita_Motivo.Font = new System.Drawing.Font("Arial", 10F);
            this.txtCita_Motivo.Location = new System.Drawing.Point(175, 190);
            this.txtCita_Motivo.Name = "txtCita_Motivo";
            this.txtCita_Motivo.Size = new System.Drawing.Size(172, 27);
            this.txtCita_Motivo.TabIndex = 14;
            // 
            // lblCita_Motivo
            // 
            this.lblCita_Motivo.Font = new System.Drawing.Font("Arial", 10F);
            this.lblCita_Motivo.Location = new System.Drawing.Point(67, 190);
            this.lblCita_Motivo.Name = "lblCita_Motivo";
            this.lblCita_Motivo.Size = new System.Drawing.Size(110, 30);
            this.lblCita_Motivo.TabIndex = 11;
            this.lblCita_Motivo.Text = "Motivo";
            this.lblCita_Motivo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnCita_Guardar
            // 
            this.btnCita_Guardar.Font = new System.Drawing.Font("Arial", 10F);
            this.btnCita_Guardar.Location = new System.Drawing.Point(66, 233);
            this.btnCita_Guardar.Name = "btnCita_Guardar";
            this.btnCita_Guardar.Size = new System.Drawing.Size(110, 40);
            this.btnCita_Guardar.TabIndex = 15;
            this.btnCita_Guardar.Text = "Registrar";
            this.btnCita_Guardar.UseVisualStyleBackColor = true;
            this.btnCita_Guardar.Click += new System.EventHandler(this.btnCita_Guardar_Click);
            // 
            // btnCita_Reprogramar
            // 
            this.btnCita_Reprogramar.Font = new System.Drawing.Font("Arial", 10F);
            this.btnCita_Reprogramar.Location = new System.Drawing.Point(186, 233);
            this.btnCita_Reprogramar.Name = "btnCita_Reprogramar";
            this.btnCita_Reprogramar.Size = new System.Drawing.Size(146, 40);
            this.btnCita_Reprogramar.TabIndex = 15;
            this.btnCita_Reprogramar.Text = "Reprogramar";
            this.btnCita_Reprogramar.UseVisualStyleBackColor = true;
            this.btnCita_Reprogramar.Click += new System.EventHandler(this.btnCita_Reprogramar_Click);
            // 
            // btnCita_Confirmar
            // 
            this.btnCita_Confirmar.Font = new System.Drawing.Font("Arial", 10F);
            this.btnCita_Confirmar.Location = new System.Drawing.Point(343, 233);
            this.btnCita_Confirmar.Name = "btnCita_Confirmar";
            this.btnCita_Confirmar.Size = new System.Drawing.Size(159, 40);
            this.btnCita_Confirmar.TabIndex = 15;
            this.btnCita_Confirmar.Text = "Marcar atendida";
            this.btnCita_Confirmar.UseVisualStyleBackColor = true;
            this.btnCita_Confirmar.Click += new System.EventHandler(this.btnCita_Confirmar_Click);
            // 
            // btnCita_Cancelar
            // 
            this.btnCita_Cancelar.Font = new System.Drawing.Font("Arial", 10F);
            this.btnCita_Cancelar.Location = new System.Drawing.Point(512, 233);
            this.btnCita_Cancelar.Name = "btnCita_Cancelar";
            this.btnCita_Cancelar.Size = new System.Drawing.Size(110, 40);
            this.btnCita_Cancelar.TabIndex = 15;
            this.btnCita_Cancelar.Text = "Cancelar";
            this.btnCita_Cancelar.UseVisualStyleBackColor = true;
            this.btnCita_Cancelar.Click += new System.EventHandler(this.btnCita_Cancelar_Click);
            // 
            // cmbCita_Filtro
            // 
            this.cmbCita_Filtro.Font = new System.Drawing.Font("Arial", 10F);
            this.cmbCita_Filtro.FormattingEnabled = true;
            this.cmbCita_Filtro.Location = new System.Drawing.Point(66, 285);
            this.cmbCita_Filtro.Name = "cmbCita_Filtro";
            this.cmbCita_Filtro.Size = new System.Drawing.Size(172, 27);
            this.cmbCita_Filtro.TabIndex = 10;
            this.cmbCita_Filtro.SelectedIndexChanged += new System.EventHandler(this.cmbCita_Filtro_SelectedIndexChanged);
            // 
            // dgvCitas
            // 
            this.dgvCitas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCitas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCitas.Location = new System.Drawing.Point(66, 318);
            this.dgvCitas.Name = "dgvCitas";
            this.dgvCitas.RowHeadersWidth = 51;
            this.dgvCitas.RowTemplate.Height = 24;
            this.dgvCitas.Size = new System.Drawing.Size(600, 206);
            this.dgvCitas.TabIndex = 16;
            // 
            // cuCitas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnCita_Reprogramar);
            this.Controls.Add(this.btnCita_Confirmar);
            this.Controls.Add(this.btnCita_Cancelar);
            this.Controls.Add(this.btnCita_Guardar);
            this.Controls.Add(this.txtCita_Motivo);
            this.Controls.Add(this.dtpCita_FechaHora);
            this.Controls.Add(this.lblCita_FechaHora);
            this.Controls.Add(this.cmbCita_Filtro);
            this.Controls.Add(this.cmbCita_Tipo);
            this.Controls.Add(this.cmbCita_Medico);
            this.Controls.Add(this.cmbCita_Paciente);
            this.Controls.Add(this.lblCita_Motivo);
            this.Controls.Add(this.lblCita_Tipo);
            this.Controls.Add(this.lblCita_Medico);
            this.Controls.Add(this.lblCita_Paciente);
            this.Controls.Add(this.lblMedicamentos_Titulo);
            this.Controls.Add(this.dgvCitas);
            this.Name = "cuCitas";
            this.Size = new System.Drawing.Size(732, 553);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCitas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMedicamentos_Titulo;
        private System.Windows.Forms.ComboBox cmbCita_Paciente;
        private System.Windows.Forms.Label lblCita_Paciente;
        private System.Windows.Forms.ComboBox cmbCita_Medico;
        private System.Windows.Forms.Label lblCita_Medico;
        private System.Windows.Forms.ComboBox cmbCita_Tipo;
        private System.Windows.Forms.Label lblCita_Tipo;
        private System.Windows.Forms.DateTimePicker dtpCita_FechaHora;
        private System.Windows.Forms.Label lblCita_FechaHora;
        private System.Windows.Forms.TextBox txtCita_Motivo;
        private System.Windows.Forms.Label lblCita_Motivo;
        private System.Windows.Forms.Button btnCita_Guardar;
        private System.Windows.Forms.Button btnCita_Reprogramar;
        private System.Windows.Forms.Button btnCita_Confirmar;
        private System.Windows.Forms.Button btnCita_Cancelar;
        private System.Windows.Forms.ComboBox cmbCita_Filtro;
        private System.Windows.Forms.DataGridView dgvCitas;
    }
}
