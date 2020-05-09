namespace AgroNegocio_RH_ERP_ISC_8A.Interfaces
{
    partial class Nomina_editar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Nomina_editar));
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.IniciotoolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.atrásToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label14 = new System.Windows.Forms.Label();
            this.listDeducciones = new System.Windows.Forms.ListBox();
            this.label13 = new System.Windows.Forms.Label();
            this.listPercepciones = new System.Windows.Forms.ListBox();
            this.formaPago_cm = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.fechaFin = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.fechaInicio = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.faltas = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.diasTrabajados = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.txtEmp = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.fechaPago = new System.Windows.Forms.DateTimePicker();
            this.idNomina = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.cantNeta = new System.Windows.Forms.TextBox();
            this.totalD = new System.Windows.Forms.TextBox();
            this.totalP = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCalPer = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.faltas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diasTrabajados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.idNomina)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.BackColor = System.Drawing.Color.Firebrick;
            this.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelar.ForeColor = System.Drawing.Color.White;
            this.btn_cancelar.Location = new System.Drawing.Point(379, 476);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(94, 31);
            this.btn_cancelar.TabIndex = 54;
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
            this.btn_guardar.Location = new System.Drawing.Point(244, 476);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(94, 31);
            this.btn_guardar.TabIndex = 53;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = false;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.IniciotoolStripMenuItem1,
            this.atrásToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(760, 24);
            this.menuStrip1.TabIndex = 48;
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
            // atrásToolStripMenuItem
            // 
            this.atrásToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.atrásToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("atrásToolStripMenuItem.Image")));
            this.atrásToolStripMenuItem.Name = "atrásToolStripMenuItem";
            this.atrásToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.atrásToolStripMenuItem.Text = "Atrás";
            this.atrásToolStripMenuItem.Click += new System.EventHandler(this.atrásToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(13, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(38, 38);
            this.pictureBox1.TabIndex = 76;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(57, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 25);
            this.label1.TabIndex = 75;
            this.label1.Text = "Editar nómina";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(13, 83);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(736, 387);
            this.tabControl1.TabIndex = 77;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label14);
            this.tabPage1.Controls.Add(this.listDeducciones);
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.listPercepciones);
            this.tabPage1.Controls.Add(this.formaPago_cm);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.fechaFin);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.fechaInicio);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.faltas);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.diasTrabajados);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.txtEmp);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.fechaPago);
            this.tabPage1.Controls.Add(this.idNomina);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(728, 361);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Asignar datos";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label14.Location = new System.Drawing.Point(282, 150);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(202, 18);
            this.label14.TabIndex = 80;
            this.label14.Text = "Seleccionar deducciones:";
            // 
            // listDeducciones
            // 
            this.listDeducciones.FormattingEnabled = true;
            this.listDeducciones.Location = new System.Drawing.Point(285, 171);
            this.listDeducciones.Name = "listDeducciones";
            this.listDeducciones.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listDeducciones.Size = new System.Drawing.Size(161, 173);
            this.listDeducciones.TabIndex = 79;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label13.Location = new System.Drawing.Point(8, 149);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(208, 18);
            this.label13.TabIndex = 78;
            this.label13.Text = "Seleccionar percepciones:";
            // 
            // listPercepciones
            // 
            this.listPercepciones.FormattingEnabled = true;
            this.listPercepciones.Location = new System.Drawing.Point(11, 170);
            this.listPercepciones.Name = "listPercepciones";
            this.listPercepciones.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listPercepciones.Size = new System.Drawing.Size(161, 173);
            this.listPercepciones.TabIndex = 77;
            // 
            // formaPago_cm
            // 
            this.formaPago_cm.FormattingEnabled = true;
            this.formaPago_cm.Location = new System.Drawing.Point(601, 87);
            this.formaPago_cm.Name = "formaPago_cm";
            this.formaPago_cm.Size = new System.Drawing.Size(104, 21);
            this.formaPago_cm.TabIndex = 72;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label12.Location = new System.Drawing.Point(441, 85);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(159, 24);
            this.label12.TabIndex = 71;
            this.label12.Text = "Forma de pago:";
            // 
            // fechaFin
            // 
            this.fechaFin.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechaFin.Location = new System.Drawing.Point(339, 89);
            this.fechaFin.MinDate = new System.DateTime(2020, 5, 2, 0, 0, 0, 0);
            this.fechaFin.Name = "fechaFin";
            this.fechaFin.Size = new System.Drawing.Size(97, 20);
            this.fechaFin.TabIndex = 70;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label11.Location = new System.Drawing.Point(238, 87);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(103, 24);
            this.label11.TabIndex = 69;
            this.label11.Text = "Fecha fin:";
            // 
            // fechaInicio
            // 
            this.fechaInicio.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechaInicio.Location = new System.Drawing.Point(133, 89);
            this.fechaInicio.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.fechaInicio.Name = "fechaInicio";
            this.fechaInicio.Size = new System.Drawing.Size(97, 20);
            this.fechaInicio.TabIndex = 68;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label10.Location = new System.Drawing.Point(6, 87);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(131, 24);
            this.label10.TabIndex = 67;
            this.label10.Text = "Fecha inicio:";
            // 
            // faltas
            // 
            this.faltas.Location = new System.Drawing.Point(539, 48);
            this.faltas.Maximum = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.faltas.Name = "faltas";
            this.faltas.Size = new System.Drawing.Size(49, 20);
            this.faltas.TabIndex = 66;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label9.Location = new System.Drawing.Point(470, 46);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 24);
            this.label9.TabIndex = 65;
            this.label9.Text = "Faltas:";
            // 
            // diasTrabajados
            // 
            this.diasTrabajados.Location = new System.Drawing.Point(411, 48);
            this.diasTrabajados.Maximum = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.diasTrabajados.Name = "diasTrabajados";
            this.diasTrabajados.Size = new System.Drawing.Size(54, 20);
            this.diasTrabajados.TabIndex = 64;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label8.Location = new System.Drawing.Point(257, 46);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(158, 24);
            this.label8.TabIndex = 63;
            this.label8.Text = "Días trabajados:";
            // 
            // txtEmp
            // 
            this.txtEmp.Enabled = false;
            this.txtEmp.Location = new System.Drawing.Point(285, 5);
            this.txtEmp.Name = "txtEmp";
            this.txtEmp.Size = new System.Drawing.Size(157, 20);
            this.txtEmp.TabIndex = 56;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(176, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 24);
            this.label5.TabIndex = 55;
            this.label5.Text = "Empleado:";
            // 
            // fechaPago
            // 
            this.fechaPago.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fechaPago.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechaPago.Location = new System.Drawing.Point(158, 50);
            this.fechaPago.MinDate = new System.DateTime(2020, 5, 2, 0, 0, 0, 0);
            this.fechaPago.Name = "fechaPago";
            this.fechaPago.Size = new System.Drawing.Size(97, 20);
            this.fechaPago.TabIndex = 53;
            // 
            // idNomina
            // 
            this.idNomina.Enabled = false;
            this.idNomina.Location = new System.Drawing.Point(45, 5);
            this.idNomina.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.idNomina.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.idNomina.Name = "idNomina";
            this.idNomina.Size = new System.Drawing.Size(103, 20);
            this.idNomina.TabIndex = 50;
            this.idNomina.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(3, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 24);
            this.label3.TabIndex = 49;
            this.label3.Text = "Fecha de pago:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(7, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 24);
            this.label2.TabIndex = 48;
            this.label2.Text = "ID:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.cantNeta);
            this.tabPage2.Controls.Add(this.totalD);
            this.tabPage2.Controls.Add(this.totalP);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.btnCalPer);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(728, 361);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Calcular nómina";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // cantNeta
            // 
            this.cantNeta.Enabled = false;
            this.cantNeta.Location = new System.Drawing.Point(164, 121);
            this.cantNeta.Name = "cantNeta";
            this.cantNeta.Size = new System.Drawing.Size(100, 20);
            this.cantNeta.TabIndex = 73;
            // 
            // totalD
            // 
            this.totalD.Enabled = false;
            this.totalD.Location = new System.Drawing.Point(243, 79);
            this.totalD.Name = "totalD";
            this.totalD.Size = new System.Drawing.Size(100, 20);
            this.totalD.TabIndex = 72;
            // 
            // totalP
            // 
            this.totalP.Enabled = false;
            this.totalP.Location = new System.Drawing.Point(243, 40);
            this.totalP.Name = "totalP";
            this.totalP.Size = new System.Drawing.Size(100, 20);
            this.totalP.TabIndex = 71;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(14, 116);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(144, 24);
            this.label7.TabIndex = 70;
            this.label7.Text = "Cantidad neta:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(14, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(219, 24);
            this.label6.TabIndex = 67;
            this.label6.Text = "Total de deducciones:";
            // 
            // btnCalPer
            // 
            this.btnCalPer.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnCalPer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCalPer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalPer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCalPer.Location = new System.Drawing.Point(283, 119);
            this.btnCalPer.Name = "btnCalPer";
            this.btnCalPer.Size = new System.Drawing.Size(105, 23);
            this.btnCalPer.TabIndex = 66;
            this.btnCalPer.Text = "Calcular nómina";
            this.btnCalPer.UseVisualStyleBackColor = false;
            this.btnCalPer.Click += new System.EventHandler(this.btnCalPer_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(11, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(226, 24);
            this.label4.TabIndex = 65;
            this.label4.Text = "Total de percepciones:";
            // 
            // Nomina_editar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 518);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Nomina_editar";
            this.Text = "Editar nómina";
            this.Load += new System.EventHandler(this.Nomina_editar_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.faltas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diasTrabajados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.idNomina)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem IniciotoolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem atrásToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ComboBox formaPago_cm;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker fechaFin;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker fechaInicio;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown faltas;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown diasTrabajados;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtEmp;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker fechaPago;
        private System.Windows.Forms.NumericUpDown idNomina;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCalPer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ListBox listDeducciones;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ListBox listPercepciones;
        private System.Windows.Forms.TextBox cantNeta;
        private System.Windows.Forms.TextBox totalD;
        private System.Windows.Forms.TextBox totalP;
    }
}