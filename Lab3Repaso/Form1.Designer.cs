namespace Lab3Repaso
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDpi = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnPropietario = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNumeroCasa = new System.Windows.Forms.TextBox();
            this.txtMantenimiento = new System.Windows.Forms.TextBox();
            this.dataGridViewdatos = new System.Windows.Forms.DataGridView();
            this.dataGridViewPropietarios = new System.Windows.Forms.DataGridView();
            this.dataGridViewPropiedades = new System.Windows.Forms.DataGridView();
            this.BtnPropiedades = new System.Windows.Forms.Button();
            this.btnOrdenarCuota = new System.Windows.Forms.Button();
            this.btnCuotaAlta = new System.Windows.Forms.Button();
            this.btnCuotaBaja = new System.Windows.Forms.Button();
            this.btnMostrarDatos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewdatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPropietarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPropiedades)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 65);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "DPI:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 102);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 135);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Apellido";
            // 
            // txtDpi
            // 
            this.txtDpi.Location = new System.Drawing.Point(108, 65);
            this.txtDpi.Margin = new System.Windows.Forms.Padding(2);
            this.txtDpi.Name = "txtDpi";
            this.txtDpi.Size = new System.Drawing.Size(76, 20);
            this.txtDpi.TabIndex = 3;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(108, 100);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(76, 20);
            this.txtNombre.TabIndex = 4;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(108, 135);
            this.txtApellido.Margin = new System.Windows.Forms.Padding(2);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(76, 20);
            this.txtApellido.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(37, 27);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(194, 22);
            this.label4.TabIndex = 6;
            this.label4.Text = "DATOS PROPIETARIOS";
            // 
            // btnPropietario
            // 
            this.btnPropietario.Location = new System.Drawing.Point(41, 173);
            this.btnPropietario.Margin = new System.Windows.Forms.Padding(2);
            this.btnPropietario.Name = "btnPropietario";
            this.btnPropietario.Size = new System.Drawing.Size(59, 25);
            this.btnPropietario.TabIndex = 7;
            this.btnPropietario.Text = "Ingresar";
            this.btnPropietario.UseVisualStyleBackColor = true;
            this.btnPropietario.Click += new System.EventHandler(this.btnPropietario_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(306, 27);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(190, 22);
            this.label5.TabIndex = 8;
            this.label5.Text = "DATOS PROPIEDADES";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(307, 65);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Nùmero De Casa:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(307, 100);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(127, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Cuota De Mantenimiento:";
            // 
            // txtNumeroCasa
            // 
            this.txtNumeroCasa.Location = new System.Drawing.Point(447, 62);
            this.txtNumeroCasa.Margin = new System.Windows.Forms.Padding(2);
            this.txtNumeroCasa.Name = "txtNumeroCasa";
            this.txtNumeroCasa.Size = new System.Drawing.Size(76, 20);
            this.txtNumeroCasa.TabIndex = 13;
            // 
            // txtMantenimiento
            // 
            this.txtMantenimiento.Location = new System.Drawing.Point(447, 95);
            this.txtMantenimiento.Margin = new System.Windows.Forms.Padding(2);
            this.txtMantenimiento.Name = "txtMantenimiento";
            this.txtMantenimiento.Size = new System.Drawing.Size(76, 20);
            this.txtMantenimiento.TabIndex = 15;
            // 
            // dataGridViewdatos
            // 
            this.dataGridViewdatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewdatos.Location = new System.Drawing.Point(678, 27);
            this.dataGridViewdatos.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewdatos.Name = "dataGridViewdatos";
            this.dataGridViewdatos.RowHeadersWidth = 51;
            this.dataGridViewdatos.RowTemplate.Height = 24;
            this.dataGridViewdatos.Size = new System.Drawing.Size(527, 274);
            this.dataGridViewdatos.TabIndex = 16;
            // 
            // dataGridViewPropietarios
            // 
            this.dataGridViewPropietarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPropietarios.Location = new System.Drawing.Point(12, 339);
            this.dataGridViewPropietarios.Name = "dataGridViewPropietarios";
            this.dataGridViewPropietarios.Size = new System.Drawing.Size(290, 250);
            this.dataGridViewPropietarios.TabIndex = 17;
            // 
            // dataGridViewPropiedades
            // 
            this.dataGridViewPropiedades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPropiedades.Location = new System.Drawing.Point(331, 339);
            this.dataGridViewPropiedades.Name = "dataGridViewPropiedades";
            this.dataGridViewPropiedades.Size = new System.Drawing.Size(310, 250);
            this.dataGridViewPropiedades.TabIndex = 18;
            // 
            // BtnPropiedades
            // 
            this.BtnPropiedades.Location = new System.Drawing.Point(310, 174);
            this.BtnPropiedades.Name = "BtnPropiedades";
            this.BtnPropiedades.Size = new System.Drawing.Size(56, 23);
            this.BtnPropiedades.TabIndex = 19;
            this.BtnPropiedades.Text = "Ingresar";
            this.BtnPropiedades.UseVisualStyleBackColor = true;
            this.BtnPropiedades.Click += new System.EventHandler(this.BtnPropiedades_Click_1);
            // 
            // btnOrdenarCuota
            // 
            this.btnOrdenarCuota.Location = new System.Drawing.Point(756, 306);
            this.btnOrdenarCuota.Name = "btnOrdenarCuota";
            this.btnOrdenarCuota.Size = new System.Drawing.Size(101, 52);
            this.btnOrdenarCuota.TabIndex = 20;
            this.btnOrdenarCuota.Text = "Ordenar Por Cuota Mantenimiento";
            this.btnOrdenarCuota.UseVisualStyleBackColor = true;
            this.btnOrdenarCuota.Click += new System.EventHandler(this.btnOrdenarCuota_Click);
            // 
            // btnCuotaAlta
            // 
            this.btnCuotaAlta.Location = new System.Drawing.Point(863, 306);
            this.btnCuotaAlta.Name = "btnCuotaAlta";
            this.btnCuotaAlta.Size = new System.Drawing.Size(60, 52);
            this.btnCuotaAlta.TabIndex = 21;
            this.btnCuotaAlta.Text = "Cuotas Más altas";
            this.btnCuotaAlta.UseVisualStyleBackColor = true;
            this.btnCuotaAlta.Click += new System.EventHandler(this.btnCuotaAlta_Click);
            // 
            // btnCuotaBaja
            // 
            this.btnCuotaBaja.Location = new System.Drawing.Point(929, 306);
            this.btnCuotaBaja.Name = "btnCuotaBaja";
            this.btnCuotaBaja.Size = new System.Drawing.Size(60, 52);
            this.btnCuotaBaja.TabIndex = 22;
            this.btnCuotaBaja.Text = "Cuotas Más Bajas";
            this.btnCuotaBaja.UseVisualStyleBackColor = true;
            this.btnCuotaBaja.Click += new System.EventHandler(this.btnCuotaBaja_Click);
            // 
            // btnMostrarDatos
            // 
            this.btnMostrarDatos.Location = new System.Drawing.Point(678, 306);
            this.btnMostrarDatos.Name = "btnMostrarDatos";
            this.btnMostrarDatos.Size = new System.Drawing.Size(72, 42);
            this.btnMostrarDatos.TabIndex = 23;
            this.btnMostrarDatos.Text = "Mostrar";
            this.btnMostrarDatos.UseVisualStyleBackColor = true;
            this.btnMostrarDatos.Click += new System.EventHandler(this.btnMostrarDatos_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1240, 613);
            this.Controls.Add(this.btnMostrarDatos);
            this.Controls.Add(this.btnCuotaBaja);
            this.Controls.Add(this.btnCuotaAlta);
            this.Controls.Add(this.btnOrdenarCuota);
            this.Controls.Add(this.BtnPropiedades);
            this.Controls.Add(this.dataGridViewPropiedades);
            this.Controls.Add(this.dataGridViewPropietarios);
            this.Controls.Add(this.dataGridViewdatos);
            this.Controls.Add(this.txtMantenimiento);
            this.Controls.Add(this.txtNumeroCasa);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnPropietario);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtDpi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pago De Condominio";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewdatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPropietarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPropiedades)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDpi;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnPropietario;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNumeroCasa;
        private System.Windows.Forms.TextBox txtMantenimiento;
        private System.Windows.Forms.DataGridView dataGridViewdatos;
        private System.Windows.Forms.DataGridView dataGridViewPropietarios;
        private System.Windows.Forms.DataGridView dataGridViewPropiedades;
        private System.Windows.Forms.Button BtnPropiedades;
        private System.Windows.Forms.Button btnOrdenarCuota;
        private System.Windows.Forms.Button btnCuotaAlta;
        private System.Windows.Forms.Button btnCuotaBaja;
        private System.Windows.Forms.Button btnMostrarDatos;
    }
}

