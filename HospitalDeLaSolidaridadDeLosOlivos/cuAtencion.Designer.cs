namespace HospitalDeLaSolidaridadDeLosOlivos
{
    partial class cuAtencion
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
            this.cmbAtencion_Paciente = new System.Windows.Forms.ComboBox();
            this.lblAtencion_Paciente = new System.Windows.Forms.Label();
            this.txtAtencion_Diagnostico = new System.Windows.Forms.TextBox();
            this.lblAtencion_Diagnostico = new System.Windows.Forms.Label();
            this.txtAtencion_Tratamiento = new System.Windows.Forms.TextBox();
            this.lblAtencion_Tratamiento = new System.Windows.Forms.Label();
            this.btnAtencion_Guardar = new System.Windows.Forms.Button();
            this.btnAtencion_Diagnostico = new System.Windows.Forms.Button();
            this.cmbAtencion_Medicamento = new System.Windows.Forms.ComboBox();
            this.lblAtencion_Medicamento = new System.Windows.Forms.Label();
            this.nudAtencion_Cantidad = new System.Windows.Forms.NumericUpDown();
            this.lblAtencion_Cantidad = new System.Windows.Forms.Label();
            this.btnAtencion_Recetar = new System.Windows.Forms.Button();
            this.dgvAtencion = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.nudAtencion_Cantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAtencion)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTituloPacientes
            // 
            this.lblTituloPacientes.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold);
            this.lblTituloPacientes.Location = new System.Drawing.Point(66, 31);
            this.lblTituloPacientes.Name = "lblTituloPacientes";
            this.lblTituloPacientes.Size = new System.Drawing.Size(239, 27);
            this.lblTituloPacientes.TabIndex = 1;
            this.lblTituloPacientes.Text = "Atencion Medica";
            this.lblTituloPacientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbAtencion_Paciente
            // 
            this.cmbAtencion_Paciente.Font = new System.Drawing.Font("Arial", 10F);
            this.cmbAtencion_Paciente.FormattingEnabled = true;
            this.cmbAtencion_Paciente.Location = new System.Drawing.Point(222, 76);
            this.cmbAtencion_Paciente.Name = "cmbAtencion_Paciente";
            this.cmbAtencion_Paciente.Size = new System.Drawing.Size(172, 27);
            this.cmbAtencion_Paciente.TabIndex = 6;
            this.cmbAtencion_Paciente.SelectedIndexChanged += new System.EventHandler(this.cmbAtencion_Paciente_SelectedIndexChanged);
            // 
            // lblAtencion_Paciente
            // 
            this.lblAtencion_Paciente.Font = new System.Drawing.Font("Arial", 10F);
            this.lblAtencion_Paciente.Location = new System.Drawing.Point(66, 76);
            this.lblAtencion_Paciente.Name = "lblAtencion_Paciente";
            this.lblAtencion_Paciente.Size = new System.Drawing.Size(130, 30);
            this.lblAtencion_Paciente.TabIndex = 7;
            this.lblAtencion_Paciente.Text = "Paciente";
            this.lblAtencion_Paciente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtAtencion_Diagnostico
            // 
            this.txtAtencion_Diagnostico.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAtencion_Diagnostico.Font = new System.Drawing.Font("Arial", 10F);
            this.txtAtencion_Diagnostico.Location = new System.Drawing.Point(222, 114);
            this.txtAtencion_Diagnostico.Name = "txtAtencion_Diagnostico";
            this.txtAtencion_Diagnostico.Size = new System.Drawing.Size(172, 27);
            this.txtAtencion_Diagnostico.TabIndex = 8;
            // 
            // lblAtencion_Diagnostico
            // 
            this.lblAtencion_Diagnostico.Font = new System.Drawing.Font("Arial", 10F);
            this.lblAtencion_Diagnostico.Location = new System.Drawing.Point(66, 114);
            this.lblAtencion_Diagnostico.Name = "lblAtencion_Diagnostico";
            this.lblAtencion_Diagnostico.Size = new System.Drawing.Size(130, 30);
            this.lblAtencion_Diagnostico.TabIndex = 7;
            this.lblAtencion_Diagnostico.Text = "Diagnostico";
            this.lblAtencion_Diagnostico.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtAtencion_Tratamiento
            // 
            this.txtAtencion_Tratamiento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAtencion_Tratamiento.Font = new System.Drawing.Font("Arial", 10F);
            this.txtAtencion_Tratamiento.Location = new System.Drawing.Point(222, 152);
            this.txtAtencion_Tratamiento.Name = "txtAtencion_Tratamiento";
            this.txtAtencion_Tratamiento.Size = new System.Drawing.Size(172, 27);
            this.txtAtencion_Tratamiento.TabIndex = 8;
            // 
            // lblAtencion_Tratamiento
            // 
            this.lblAtencion_Tratamiento.Font = new System.Drawing.Font("Arial", 10F);
            this.lblAtencion_Tratamiento.Location = new System.Drawing.Point(66, 152);
            this.lblAtencion_Tratamiento.Name = "lblAtencion_Tratamiento";
            this.lblAtencion_Tratamiento.Size = new System.Drawing.Size(130, 30);
            this.lblAtencion_Tratamiento.TabIndex = 9;
            this.lblAtencion_Tratamiento.Text = "Tratamiento";
            this.lblAtencion_Tratamiento.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnAtencion_Guardar
            // 
            this.btnAtencion_Guardar.Font = new System.Drawing.Font("Arial", 10F);
            this.btnAtencion_Guardar.Location = new System.Drawing.Point(66, 233);
            this.btnAtencion_Guardar.Name = "btnAtencion_Guardar";
            this.btnAtencion_Guardar.Size = new System.Drawing.Size(110, 40);
            this.btnAtencion_Guardar.TabIndex = 10;
            this.btnAtencion_Guardar.Text = "Registrar";
            this.btnAtencion_Guardar.UseVisualStyleBackColor = true;
            this.btnAtencion_Guardar.Click += new System.EventHandler(this.btnAtencion_Guardar_Click);
            // 
            // btnAtencion_Diagnostico
            // 
            this.btnAtencion_Diagnostico.Font = new System.Drawing.Font("Arial", 10F);
            this.btnAtencion_Diagnostico.Location = new System.Drawing.Point(182, 233);
            this.btnAtencion_Diagnostico.Name = "btnAtencion_Diagnostico";
            this.btnAtencion_Diagnostico.Size = new System.Drawing.Size(212, 40);
            this.btnAtencion_Diagnostico.TabIndex = 10;
            this.btnAtencion_Diagnostico.Text = "Actualizar diagnóstico";
            this.btnAtencion_Diagnostico.UseVisualStyleBackColor = true;
            this.btnAtencion_Diagnostico.Click += new System.EventHandler(this.btnAtencion_Diagnostico_Click);
            // 
            // cmbAtencion_Medicamento
            // 
            this.cmbAtencion_Medicamento.Font = new System.Drawing.Font("Arial", 10F);
            this.cmbAtencion_Medicamento.FormattingEnabled = true;
            this.cmbAtencion_Medicamento.Location = new System.Drawing.Point(222, 190);
            this.cmbAtencion_Medicamento.Name = "cmbAtencion_Medicamento";
            this.cmbAtencion_Medicamento.Size = new System.Drawing.Size(172, 27);
            this.cmbAtencion_Medicamento.TabIndex = 11;
            // 
            // lblAtencion_Medicamento
            // 
            this.lblAtencion_Medicamento.Font = new System.Drawing.Font("Arial", 10F);
            this.lblAtencion_Medicamento.Location = new System.Drawing.Point(67, 190);
            this.lblAtencion_Medicamento.Name = "lblAtencion_Medicamento";
            this.lblAtencion_Medicamento.Size = new System.Drawing.Size(158, 30);
            this.lblAtencion_Medicamento.TabIndex = 12;
            this.lblAtencion_Medicamento.Text = "Medicamento";
            this.lblAtencion_Medicamento.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // nudAtencion_Cantidad
            // 
            this.nudAtencion_Cantidad.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudAtencion_Cantidad.Location = new System.Drawing.Point(494, 105);
            this.nudAtencion_Cantidad.Name = "nudAtencion_Cantidad";
            this.nudAtencion_Cantidad.Size = new System.Drawing.Size(172, 27);
            this.nudAtencion_Cantidad.TabIndex = 13;
            // 
            // lblAtencion_Cantidad
            // 
            this.lblAtencion_Cantidad.Font = new System.Drawing.Font("Arial", 10F);
            this.lblAtencion_Cantidad.Location = new System.Drawing.Point(515, 73);
            this.lblAtencion_Cantidad.Name = "lblAtencion_Cantidad";
            this.lblAtencion_Cantidad.Size = new System.Drawing.Size(130, 30);
            this.lblAtencion_Cantidad.TabIndex = 7;
            this.lblAtencion_Cantidad.Text = "Cantidad";
            this.lblAtencion_Cantidad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAtencion_Recetar
            // 
            this.btnAtencion_Recetar.Font = new System.Drawing.Font("Arial", 10F);
            this.btnAtencion_Recetar.Location = new System.Drawing.Point(525, 143);
            this.btnAtencion_Recetar.Name = "btnAtencion_Recetar";
            this.btnAtencion_Recetar.Size = new System.Drawing.Size(110, 40);
            this.btnAtencion_Recetar.TabIndex = 10;
            this.btnAtencion_Recetar.Text = "Agregar";
            this.btnAtencion_Recetar.UseVisualStyleBackColor = true;
            this.btnAtencion_Recetar.Click += new System.EventHandler(this.btnAtencion_Recetar_Click);
            // 
            // dgvAtencion
            // 
            this.dgvAtencion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAtencion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAtencion.Location = new System.Drawing.Point(66, 283);
            this.dgvAtencion.Name = "dgvAtencion";
            this.dgvAtencion.RowHeadersWidth = 51;
            this.dgvAtencion.RowTemplate.Height = 24;
            this.dgvAtencion.Size = new System.Drawing.Size(600, 241);
            this.dgvAtencion.TabIndex = 14;
            // 
            // cuAtencion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvAtencion);
            this.Controls.Add(this.nudAtencion_Cantidad);
            this.Controls.Add(this.cmbAtencion_Medicamento);
            this.Controls.Add(this.lblAtencion_Medicamento);
            this.Controls.Add(this.btnAtencion_Diagnostico);
            this.Controls.Add(this.btnAtencion_Recetar);
            this.Controls.Add(this.btnAtencion_Guardar);
            this.Controls.Add(this.txtAtencion_Tratamiento);
            this.Controls.Add(this.txtAtencion_Diagnostico);
            this.Controls.Add(this.cmbAtencion_Paciente);
            this.Controls.Add(this.lblAtencion_Diagnostico);
            this.Controls.Add(this.lblAtencion_Cantidad);
            this.Controls.Add(this.lblAtencion_Paciente);
            this.Controls.Add(this.lblTituloPacientes);
            this.Controls.Add(this.lblAtencion_Tratamiento);
            this.Name = "cuAtencion";
            this.Size = new System.Drawing.Size(732, 553);
            ((System.ComponentModel.ISupportInitialize)(this.nudAtencion_Cantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAtencion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTituloPacientes;
        private System.Windows.Forms.ComboBox cmbAtencion_Paciente;
        private System.Windows.Forms.Label lblAtencion_Paciente;
        private System.Windows.Forms.TextBox txtAtencion_Diagnostico;
        private System.Windows.Forms.Label lblAtencion_Diagnostico;
        private System.Windows.Forms.TextBox txtAtencion_Tratamiento;
        private System.Windows.Forms.Label lblAtencion_Tratamiento;
        private System.Windows.Forms.Button btnAtencion_Guardar;
        private System.Windows.Forms.Button btnAtencion_Diagnostico;
        private System.Windows.Forms.ComboBox cmbAtencion_Medicamento;
        private System.Windows.Forms.Label lblAtencion_Medicamento;
        private System.Windows.Forms.NumericUpDown nudAtencion_Cantidad;
        private System.Windows.Forms.Label lblAtencion_Cantidad;
        private System.Windows.Forms.Button btnAtencion_Recetar;
        private System.Windows.Forms.DataGridView dgvAtencion;
    }
}
