namespace HospitalDeLaSolidaridadDeLosOlivos
{
    partial class cuMedicamentos
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
            this.txtMedicamento_Nombre = new System.Windows.Forms.TextBox();
            this.lblMedicamento_Nombre = new System.Windows.Forms.Label();
            this.nudMedicamento_Cantidad = new System.Windows.Forms.NumericUpDown();
            this.lblMedicamento_Cantidad = new System.Windows.Forms.Label();
            this.btnMedicamento_Guardar = new System.Windows.Forms.Button();
            this.btnMedicamento_Ingreso = new System.Windows.Forms.Button();
            this.btnMedicamento_Salida = new System.Windows.Forms.Button();
            this.btnMedicamento_Eliminar = new System.Windows.Forms.Button();
            this.dgvMedicamentos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.nudMedicamento_Cantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicamentos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMedicamentos_Titulo
            // 
            this.lblMedicamentos_Titulo.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold);
            this.lblMedicamentos_Titulo.Location = new System.Drawing.Point(66, 31);
            this.lblMedicamentos_Titulo.Name = "lblMedicamentos_Titulo";
            this.lblMedicamentos_Titulo.Size = new System.Drawing.Size(266, 27);
            this.lblMedicamentos_Titulo.TabIndex = 1;
            this.lblMedicamentos_Titulo.Text = "Medicamentos";
            this.lblMedicamentos_Titulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtMedicamento_Nombre
            // 
            this.txtMedicamento_Nombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMedicamento_Nombre.Font = new System.Drawing.Font("Arial", 10F);
            this.txtMedicamento_Nombre.Location = new System.Drawing.Point(175, 76);
            this.txtMedicamento_Nombre.Name = "txtMedicamento_Nombre";
            this.txtMedicamento_Nombre.Size = new System.Drawing.Size(172, 27);
            this.txtMedicamento_Nombre.TabIndex = 4;
            // 
            // lblMedicamento_Nombre
            // 
            this.lblMedicamento_Nombre.Font = new System.Drawing.Font("Arial", 10F);
            this.lblMedicamento_Nombre.Location = new System.Drawing.Point(66, 76);
            this.lblMedicamento_Nombre.Name = "lblMedicamento_Nombre";
            this.lblMedicamento_Nombre.Size = new System.Drawing.Size(110, 30);
            this.lblMedicamento_Nombre.TabIndex = 5;
            this.lblMedicamento_Nombre.Text = "Nombre";
            this.lblMedicamento_Nombre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // nudMedicamento_Cantidad
            // 
            this.nudMedicamento_Cantidad.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudMedicamento_Cantidad.Location = new System.Drawing.Point(175, 114);
            this.nudMedicamento_Cantidad.Name = "nudMedicamento_Cantidad";
            this.nudMedicamento_Cantidad.Size = new System.Drawing.Size(172, 27);
            this.nudMedicamento_Cantidad.TabIndex = 6;
            // 
            // lblMedicamento_Cantidad
            // 
            this.lblMedicamento_Cantidad.Font = new System.Drawing.Font("Arial", 10F);
            this.lblMedicamento_Cantidad.Location = new System.Drawing.Point(66, 114);
            this.lblMedicamento_Cantidad.Name = "lblMedicamento_Cantidad";
            this.lblMedicamento_Cantidad.Size = new System.Drawing.Size(110, 30);
            this.lblMedicamento_Cantidad.TabIndex = 5;
            this.lblMedicamento_Cantidad.Text = "Cantidad";
            this.lblMedicamento_Cantidad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnMedicamento_Guardar
            // 
            this.btnMedicamento_Guardar.Font = new System.Drawing.Font("Arial", 10F);
            this.btnMedicamento_Guardar.Location = new System.Drawing.Point(66, 233);
            this.btnMedicamento_Guardar.Name = "btnMedicamento_Guardar";
            this.btnMedicamento_Guardar.Size = new System.Drawing.Size(110, 40);
            this.btnMedicamento_Guardar.TabIndex = 11;
            this.btnMedicamento_Guardar.Text = "Guardar";
            this.btnMedicamento_Guardar.UseVisualStyleBackColor = true;
            this.btnMedicamento_Guardar.Click += new System.EventHandler(this.btnMedicamento_Guardar_Click);
            // 
            // btnMedicamento_Ingreso
            // 
            this.btnMedicamento_Ingreso.Font = new System.Drawing.Font("Arial", 10F);
            this.btnMedicamento_Ingreso.Location = new System.Drawing.Point(186, 233);
            this.btnMedicamento_Ingreso.Name = "btnMedicamento_Ingreso";
            this.btnMedicamento_Ingreso.Size = new System.Drawing.Size(110, 40);
            this.btnMedicamento_Ingreso.TabIndex = 12;
            this.btnMedicamento_Ingreso.Text = "Aumentar";
            this.btnMedicamento_Ingreso.UseVisualStyleBackColor = true;
            this.btnMedicamento_Ingreso.Click += new System.EventHandler(this.btnMedicamento_Ingreso_Click);
            // 
            // btnMedicamento_Salida
            // 
            this.btnMedicamento_Salida.Font = new System.Drawing.Font("Arial", 10F);
            this.btnMedicamento_Salida.Location = new System.Drawing.Point(306, 233);
            this.btnMedicamento_Salida.Name = "btnMedicamento_Salida";
            this.btnMedicamento_Salida.Size = new System.Drawing.Size(110, 40);
            this.btnMedicamento_Salida.TabIndex = 12;
            this.btnMedicamento_Salida.Text = "Reducir";
            this.btnMedicamento_Salida.UseVisualStyleBackColor = true;
            this.btnMedicamento_Salida.Click += new System.EventHandler(this.btnMedicamento_Salida_Click);
            // 
            // btnMedicamento_Eliminar
            // 
            this.btnMedicamento_Eliminar.Font = new System.Drawing.Font("Arial", 10F);
            this.btnMedicamento_Eliminar.Location = new System.Drawing.Point(426, 233);
            this.btnMedicamento_Eliminar.Name = "btnMedicamento_Eliminar";
            this.btnMedicamento_Eliminar.Size = new System.Drawing.Size(110, 40);
            this.btnMedicamento_Eliminar.TabIndex = 12;
            this.btnMedicamento_Eliminar.Text = "Eliminar";
            this.btnMedicamento_Eliminar.UseVisualStyleBackColor = true;
            this.btnMedicamento_Eliminar.Click += new System.EventHandler(this.btnMedicamento_Eliminar_Click);
            // 
            // dgvMedicamentos
            // 
            this.dgvMedicamentos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMedicamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMedicamentos.Location = new System.Drawing.Point(66, 283);
            this.dgvMedicamentos.Name = "dgvMedicamentos";
            this.dgvMedicamentos.RowHeadersWidth = 51;
            this.dgvMedicamentos.RowTemplate.Height = 24;
            this.dgvMedicamentos.Size = new System.Drawing.Size(600, 241);
            this.dgvMedicamentos.TabIndex = 13;
            // 
            // cuMedicamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvMedicamentos);
            this.Controls.Add(this.btnMedicamento_Eliminar);
            this.Controls.Add(this.btnMedicamento_Salida);
            this.Controls.Add(this.btnMedicamento_Ingreso);
            this.Controls.Add(this.btnMedicamento_Guardar);
            this.Controls.Add(this.nudMedicamento_Cantidad);
            this.Controls.Add(this.txtMedicamento_Nombre);
            this.Controls.Add(this.lblMedicamentos_Titulo);
            this.Controls.Add(this.lblMedicamento_Cantidad);
            this.Controls.Add(this.lblMedicamento_Nombre);
            this.Name = "cuMedicamentos";
            this.Size = new System.Drawing.Size(732, 553);
            ((System.ComponentModel.ISupportInitialize)(this.nudMedicamento_Cantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicamentos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMedicamentos_Titulo;
        private System.Windows.Forms.TextBox txtMedicamento_Nombre;
        private System.Windows.Forms.Label lblMedicamento_Nombre;
        private System.Windows.Forms.NumericUpDown nudMedicamento_Cantidad;
        private System.Windows.Forms.Label lblMedicamento_Cantidad;
        private System.Windows.Forms.Button btnMedicamento_Guardar;
        private System.Windows.Forms.Button btnMedicamento_Ingreso;
        private System.Windows.Forms.Button btnMedicamento_Salida;
        private System.Windows.Forms.Button btnMedicamento_Eliminar;
        private System.Windows.Forms.DataGridView dgvMedicamentos;
    }
}
