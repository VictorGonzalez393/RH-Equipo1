namespace AgroNegocio_RH_ERP_ISC_8A.Interfaces
{
    partial class Ausencias_justificadas_editar
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ausencias_justificadas_editar));
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.fechaSolicitud_ausencia_Justificada = new System.Windows.Forms.DateTimePicker();
            this.id_empleadoA = new System.Windows.Forms.NumericUpDown();
            this.id_empleadoS = new System.Windows.Forms.NumericUpDown();
            this.id_justificacion = new System.Windows.Forms.NumericUpDown();
            this.tipo_ausencia_Justificada = new System.Windows.Forms.TextBox();
            this.fechaInicio_ausencia_Justificada = new System.Windows.Forms.DateTimePicker();
            this.fechaFin_ausencia_Justficada = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.justificaciones = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.IniciotoolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.id_empleadoA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.id_empleadoS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.id_justificacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.justificaciones)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.BackColor = System.Drawing.Color.Firebrick;
            this.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelar.ForeColor = System.Drawing.Color.White;
            this.btn_cancelar.Location = new System.Drawing.Point(352, 390);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(94, 31);
            this.btn_cancelar.TabIndex = 44;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = false;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_guardar
            // 
            this.btn_guardar.BackColor = System.Drawing.Color.LimeGreen;
            this.btn_guardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_guardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_guardar.ForeColor = System.Drawing.Color.White;
            this.btn_guardar.Location = new System.Drawing.Point(252, 390);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(94, 31);
            this.btn_guardar.TabIndex = 43;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = false;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // fechaSolicitud_ausencia_Justificada
            // 
            this.fechaSolicitud_ausencia_Justificada.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechaSolicitud_ausencia_Justificada.Location = new System.Drawing.Point(179, 165);
            this.fechaSolicitud_ausencia_Justificada.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.fechaSolicitud_ausencia_Justificada.Name = "fechaSolicitud_ausencia_Justificada";
            this.fechaSolicitud_ausencia_Justificada.Size = new System.Drawing.Size(220, 22);
            this.fechaSolicitud_ausencia_Justificada.TabIndex = 42;
            this.fechaSolicitud_ausencia_Justificada.Value = new System.DateTime(2020, 5, 25, 23, 59, 59, 0);
            this.fechaSolicitud_ausencia_Justificada.ValueChanged += new System.EventHandler(this.fechaSolicitud_ausencia_Justificada_ValueChanged);
            // 
            // id_empleadoA
            // 
            this.id_empleadoA.Enabled = false;
            this.id_empleadoA.Location = new System.Drawing.Point(199, 336);
            this.id_empleadoA.Name = "id_empleadoA";
            this.id_empleadoA.Size = new System.Drawing.Size(166, 22);
            this.id_empleadoA.TabIndex = 41;
            this.id_empleadoA.ValueChanged += new System.EventHandler(this.id_empleadoA_ValueChanged);
            // 
            // id_empleadoS
            // 
            this.id_empleadoS.Enabled = false;
            this.id_empleadoS.Location = new System.Drawing.Point(199, 296);
            this.id_empleadoS.Name = "id_empleadoS";
            this.id_empleadoS.Size = new System.Drawing.Size(166, 22);
            this.id_empleadoS.TabIndex = 40;
            this.id_empleadoS.ValueChanged += new System.EventHandler(this.id_empleadoS_ValueChanged);
            // 
            // id_justificacion
            // 
            this.id_justificacion.Enabled = false;
            this.id_justificacion.Location = new System.Drawing.Point(158, 128);
            this.id_justificacion.Name = "id_justificacion";
            this.id_justificacion.Size = new System.Drawing.Size(155, 22);
            this.id_justificacion.TabIndex = 39;
            this.id_justificacion.ValueChanged += new System.EventHandler(this.id_justificacion_ValueChanged_1);
            // 
            // tipo_ausencia_Justificada
            // 
            this.tipo_ausencia_Justificada.Location = new System.Drawing.Point(123, 256);
            this.tipo_ausencia_Justificada.Name = "tipo_ausencia_Justificada";
            this.tipo_ausencia_Justificada.Size = new System.Drawing.Size(100, 22);
            this.tipo_ausencia_Justificada.TabIndex = 38;
            this.tipo_ausencia_Justificada.TextChanged += new System.EventHandler(this.tipo_ausencia_Justificada_TextChanged);
            // 
            // fechaInicio_ausencia_Justificada
            // 
            this.fechaInicio_ausencia_Justificada.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechaInicio_ausencia_Justificada.Location = new System.Drawing.Point(135, 211);
            this.fechaInicio_ausencia_Justificada.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.fechaInicio_ausencia_Justificada.Name = "fechaInicio_ausencia_Justificada";
            this.fechaInicio_ausencia_Justificada.Size = new System.Drawing.Size(218, 22);
            this.fechaInicio_ausencia_Justificada.TabIndex = 37;
            this.fechaInicio_ausencia_Justificada.Value = new System.DateTime(2020, 5, 25, 23, 59, 59, 0);
            this.fechaInicio_ausencia_Justificada.ValueChanged += new System.EventHandler(this.fechaInicio_ausencia_Justificada_ValueChanged);
            // 
            // fechaFin_ausencia_Justficada
            // 
            this.fechaFin_ausencia_Justficada.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechaFin_ausencia_Justficada.Location = new System.Drawing.Point(443, 212);
            this.fechaFin_ausencia_Justficada.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.fechaFin_ausencia_Justficada.Name = "fechaFin_ausencia_Justficada";
            this.fechaFin_ausencia_Justficada.Size = new System.Drawing.Size(223, 22);
            this.fechaFin_ausencia_Justficada.TabIndex = 36;
            this.fechaFin_ausencia_Justficada.Value = new System.DateTime(2020, 5, 25, 23, 59, 59, 0);
            this.fechaFin_ausencia_Justficada.ValueChanged += new System.EventHandler(this.fechaFin_ausencia_Justficada_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.SteelBlue;
            this.label8.Location = new System.Drawing.Point(215, 51);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(185, 29);
            this.label8.TabIndex = 35;
            this.label8.Text = "Justificaciones";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(71, 336);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 18);
            this.label7.TabIndex = 34;
            this.label7.Text = "id Empleado A:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(70, 296);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 18);
            this.label6.TabIndex = 33;
            this.label6.Text = "id Empleado S:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(71, 256);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 18);
            this.label5.TabIndex = 32;
            this.label5.Text = "Tipo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(359, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 18);
            this.label4.TabIndex = 31;
            this.label4.Text = "Fecha Fin:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(35, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 18);
            this.label3.TabIndex = 30;
            this.label3.Text = "Fecha Inicio:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(53, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 18);
            this.label2.TabIndex = 29;
            this.label2.Text = "Fecha Solicitud:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(53, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 18);
            this.label1.TabIndex = 28;
            this.label1.Text = "id Ausencia:";
            // 
            // justificaciones
            // 
            this.justificaciones.Image = ((System.Drawing.Image)(resources.GetObject("justificaciones.Image")));
            this.justificaciones.Location = new System.Drawing.Point(20, -40);
            this.justificaciones.Name = "justificaciones";
            this.justificaciones.Size = new System.Drawing.Size(189, 151);
            this.justificaciones.TabIndex = 45;
            this.justificaciones.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.IniciotoolStripMenuItem1,
            this.backToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(692, 24);
            this.menuStrip1.TabIndex = 46;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // IniciotoolStripMenuItem1
            // 
            this.IniciotoolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IniciotoolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("IniciotoolStripMenuItem1.Image")));
            this.IniciotoolStripMenuItem1.Name = "IniciotoolStripMenuItem1";
            this.IniciotoolStripMenuItem1.Size = new System.Drawing.Size(65, 20);
            this.IniciotoolStripMenuItem1.Text = "Inicio";
            this.IniciotoolStripMenuItem1.Click += new System.EventHandler(this.IniciotoolStripMenuItem1_Click);
            // 
            // backToolStripMenuItem
            // 
            this.backToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.backToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("backToolStripMenuItem.Image")));
            this.backToolStripMenuItem.Name = "backToolStripMenuItem";
            this.backToolStripMenuItem.Size = new System.Drawing.Size(28, 20);
            this.backToolStripMenuItem.Text = "Back";
            this.backToolStripMenuItem.Click += new System.EventHandler(this.backToolStripMenuItem_Click);
            // 
            // Ausencias_justificadas_editar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 451);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.justificaciones);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.fechaSolicitud_ausencia_Justificada);
            this.Controls.Add(this.id_empleadoA);
            this.Controls.Add(this.id_empleadoS);
            this.Controls.Add(this.id_justificacion);
            this.Controls.Add(this.tipo_ausencia_Justificada);
            this.Controls.Add(this.fechaInicio_ausencia_Justificada);
            this.Controls.Add(this.fechaFin_ausencia_Justficada);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Ausencias_justificadas_editar";
            this.Text = "Ausencias_Justificadas_editar";
            this.Load += new System.EventHandler(this.Ausencias_justificadas_editar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.id_empleadoA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.id_empleadoS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.id_justificacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.justificaciones)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.DateTimePicker fechaSolicitud_ausencia_Justificada;
        private System.Windows.Forms.NumericUpDown id_empleadoA;
        private System.Windows.Forms.NumericUpDown id_empleadoS;
        private System.Windows.Forms.NumericUpDown id_justificacion;
        private System.Windows.Forms.TextBox tipo_ausencia_Justificada;
        private System.Windows.Forms.DateTimePicker fechaInicio_ausencia_Justificada;
        private System.Windows.Forms.DateTimePicker fechaFin_ausencia_Justficada;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox justificaciones;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem IniciotoolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
    }
}