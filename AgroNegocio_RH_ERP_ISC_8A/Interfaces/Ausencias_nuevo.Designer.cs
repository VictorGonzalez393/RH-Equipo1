namespace AgroNegocio_RH_ERP_ISC_8A.Interfaces
{
    partial class Ausencias_nuevo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ausencias_nuevo));
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.inicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.atrásToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.id_au = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.empleadoS = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.fechaSol = new System.Windows.Forms.DateTimePicker();
            this.fechaIn = new System.Windows.Forms.DateTimePicker();
            this.fechaFin = new System.Windows.Forms.DateTimePicker();
            this.tipo_cm = new System.Windows.Forms.ComboBox();
            this.empleadoA_cm = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.id_au)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.BackColor = System.Drawing.Color.Firebrick;
            this.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelar.ForeColor = System.Drawing.Color.White;
            this.btn_cancelar.Location = new System.Drawing.Point(320, 294);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(94, 31);
            this.btn_cancelar.TabIndex = 18;
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
            this.btn_guardar.Location = new System.Drawing.Point(208, 294);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(94, 31);
            this.btn_guardar.TabIndex = 17;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = false;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(38, 38);
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(56, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(320, 25);
            this.label1.TabIndex = 15;
            this.label1.Text = "Agregar Ausencia Justificada";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inicioToolStripMenuItem,
            this.atrásToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(592, 24);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // inicioToolStripMenuItem
            // 
            this.inicioToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inicioToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("inicioToolStripMenuItem.Image")));
            this.inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            this.inicioToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.inicioToolStripMenuItem.Text = "Inicio";
            this.inicioToolStripMenuItem.Click += new System.EventHandler(this.inicioToolStripMenuItem_Click);
            // 
            // atrásToolStripMenuItem
            // 
            this.atrásToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.atrásToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("atrásToolStripMenuItem.Image")));
            this.atrásToolStripMenuItem.Name = "atrásToolStripMenuItem";
            this.atrásToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.atrásToolStripMenuItem.Text = "Atrás";
            this.atrásToolStripMenuItem.Click += new System.EventHandler(this.atrásToolStripMenuItem_Click);
            // 
            // id_au
            // 
            this.id_au.Enabled = false;
            this.id_au.Location = new System.Drawing.Point(61, 99);
            this.id_au.Name = "id_au";
            this.id_au.Size = new System.Drawing.Size(120, 20);
            this.id_au.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(25, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 24);
            this.label2.TabIndex = 19;
            this.label2.Text = "ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(25, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 24);
            this.label3.TabIndex = 21;
            this.label3.Text = "Fecha solicitud:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(25, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 24);
            this.label4.TabIndex = 22;
            this.label4.Text = "Fecha inicio:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(335, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 24);
            this.label5.TabIndex = 23;
            this.label5.Text = "Fecha fin:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(335, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 24);
            this.label6.TabIndex = 24;
            this.label6.Text = "Tipo:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(262, 99);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(130, 24);
            this.label7.TabIndex = 25;
            this.label7.Text = "Empleado S:";
            // 
            // empleadoS
            // 
            this.empleadoS.Enabled = false;
            this.empleadoS.Location = new System.Drawing.Point(398, 101);
            this.empleadoS.Name = "empleadoS";
            this.empleadoS.Size = new System.Drawing.Size(160, 20);
            this.empleadoS.TabIndex = 26;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label8.Location = new System.Drawing.Point(25, 242);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(232, 24);
            this.label8.TabIndex = 27;
            this.label8.Text = "Empleado que autoriza:";
            // 
            // fechaSol
            // 
            this.fechaSol.Enabled = false;
            this.fechaSol.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechaSol.Location = new System.Drawing.Point(190, 142);
            this.fechaSol.MinDate = new System.DateTime(2020, 5, 12, 0, 0, 0, 0);
            this.fechaSol.Name = "fechaSol";
            this.fechaSol.Size = new System.Drawing.Size(122, 20);
            this.fechaSol.TabIndex = 28;
            this.fechaSol.Value = new System.DateTime(2020, 5, 12, 18, 39, 19, 0);
            // 
            // fechaIn
            // 
            this.fechaIn.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechaIn.Location = new System.Drawing.Point(190, 186);
            this.fechaIn.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.fechaIn.Name = "fechaIn";
            this.fechaIn.Size = new System.Drawing.Size(122, 20);
            this.fechaIn.TabIndex = 29;
            this.fechaIn.Value = new System.DateTime(2020, 5, 12, 0, 0, 0, 0);
            // 
            // fechaFin
            // 
            this.fechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechaFin.Location = new System.Drawing.Point(436, 186);
            this.fechaFin.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.fechaFin.Name = "fechaFin";
            this.fechaFin.Size = new System.Drawing.Size(122, 20);
            this.fechaFin.TabIndex = 30;
            this.fechaFin.Value = new System.DateTime(2020, 5, 12, 0, 0, 0, 0);
            // 
            // tipo_cm
            // 
            this.tipo_cm.FormattingEnabled = true;
            this.tipo_cm.Location = new System.Drawing.Point(400, 140);
            this.tipo_cm.Name = "tipo_cm";
            this.tipo_cm.Size = new System.Drawing.Size(158, 21);
            this.tipo_cm.TabIndex = 31;
            // 
            // empleadoA_cm
            // 
            this.empleadoA_cm.FormattingEnabled = true;
            this.empleadoA_cm.Location = new System.Drawing.Point(263, 245);
            this.empleadoA_cm.Name = "empleadoA_cm";
            this.empleadoA_cm.Size = new System.Drawing.Size(295, 21);
            this.empleadoA_cm.TabIndex = 32;
            this.empleadoA_cm.SelectedIndexChanged += new System.EventHandler(this.empleadoA_cm_SelectedIndexChanged);
            // 
            // Ausencias_nuevo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 347);
            this.Controls.Add(this.empleadoA_cm);
            this.Controls.Add(this.tipo_cm);
            this.Controls.Add(this.fechaFin);
            this.Controls.Add(this.fechaIn);
            this.Controls.Add(this.fechaSol);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.empleadoS);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.id_au);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Ausencias_nuevo";
            this.Text = "Agregar ausencia";
            this.Load += new System.EventHandler(this.Ausencias_nuevo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.id_au)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem inicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem atrásToolStripMenuItem;
        private System.Windows.Forms.NumericUpDown id_au;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox empleadoS;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker fechaSol;
        private System.Windows.Forms.DateTimePicker fechaIn;
        private System.Windows.Forms.DateTimePicker fechaFin;
        private System.Windows.Forms.ComboBox tipo_cm;
        private System.Windows.Forms.ComboBox empleadoA_cm;
    }
}