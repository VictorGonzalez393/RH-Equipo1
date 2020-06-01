namespace AgroNegocio_RH_ERP_ISC_8A.Interfaces
{
    partial class Horarios_editar
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Horarios_editar));
            this.label1 = new System.Windows.Forms.Label();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.idEmpleado = new System.Windows.Forms.TextBox();
            this.dias = new System.Windows.Forms.ComboBox();
            this.tablaHorario = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Inicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.agregar = new System.Windows.Forms.Button();
            this.horai = new System.Windows.Forms.DateTimePicker();
            this.horaf = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.editar = new System.Windows.Forms.Button();
            this.nombre = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cancelarEditar = new System.Windows.Forms.Button();
            this.eliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tablaHorario)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(96, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(291, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Horario del empleado";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btn_guardar
            // 
            this.btn_guardar.BackColor = System.Drawing.Color.LimeGreen;
            this.btn_guardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_guardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_guardar.ForeColor = System.Drawing.Color.White;
            this.btn_guardar.Location = new System.Drawing.Point(31, 426);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(94, 31);
            this.btn_guardar.TabIndex = 23;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = false;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.BackColor = System.Drawing.Color.Firebrick;
            this.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelar.ForeColor = System.Drawing.Color.White;
            this.btn_cancelar.Location = new System.Drawing.Point(354, 426);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(94, 31);
            this.btn_cancelar.TabIndex = 24;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = false;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "Dias laborales:";
            // 
            // idEmpleado
            // 
            this.idEmpleado.Location = new System.Drawing.Point(52, 76);
            this.idEmpleado.Name = "idEmpleado";
            this.idEmpleado.ReadOnly = true;
            this.idEmpleado.Size = new System.Drawing.Size(65, 20);
            this.idEmpleado.TabIndex = 28;
            // 
            // dias
            // 
            this.dias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dias.FormattingEnabled = true;
            this.dias.Items.AddRange(new object[] {
            "Lunes",
            "Martes",
            "Miércoles",
            "Jueves",
            "Viernes",
            "Sabado",
            "Domingo"});
            this.dias.Location = new System.Drawing.Point(25, 124);
            this.dias.Name = "dias";
            this.dias.Size = new System.Drawing.Size(92, 21);
            this.dias.TabIndex = 36;
            // 
            // tablaHorario
            // 
            this.tablaHorario.AllowUserToAddRows = false;
            this.tablaHorario.AllowUserToDeleteRows = false;
            this.tablaHorario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaHorario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Dia,
            this.Inicio,
            this.Fin,
            this.Estatus});
            this.tablaHorario.Location = new System.Drawing.Point(7, 197);
            this.tablaHorario.MultiSelect = false;
            this.tablaHorario.Name = "tablaHorario";
            this.tablaHorario.ReadOnly = true;
            this.tablaHorario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tablaHorario.Size = new System.Drawing.Size(448, 213);
            this.tablaHorario.TabIndex = 39;
            this.tablaHorario.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablaHorario_CellDoubleClick);
            this.tablaHorario.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.tablaHorario_CellFormatting);
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // Dia
            // 
            this.Dia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Dia.HeaderText = "Dia";
            this.Dia.Name = "Dia";
            this.Dia.ReadOnly = true;
            // 
            // Inicio
            // 
            this.Inicio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle1.NullValue = null;
            this.Inicio.DefaultCellStyle = dataGridViewCellStyle1;
            this.Inicio.HeaderText = "Inicio";
            this.Inicio.Name = "Inicio";
            this.Inicio.ReadOnly = true;
            // 
            // Fin
            // 
            this.Fin.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.NullValue = null;
            this.Fin.DefaultCellStyle = dataGridViewCellStyle2;
            this.Fin.HeaderText = "Fin";
            this.Fin.Name = "Fin";
            this.Fin.ReadOnly = true;
            // 
            // Estatus
            // 
            this.Estatus.HeaderText = "Estatus";
            this.Estatus.Name = "Estatus";
            this.Estatus.ReadOnly = true;
            // 
            // agregar
            // 
            this.agregar.Location = new System.Drawing.Point(25, 167);
            this.agregar.Name = "agregar";
            this.agregar.Size = new System.Drawing.Size(75, 23);
            this.agregar.TabIndex = 40;
            this.agregar.Text = "Agregar";
            this.agregar.UseVisualStyleBackColor = true;
            this.agregar.Click += new System.EventHandler(this.button1_Click);
            // 
            // horai
            // 
            this.horai.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.horai.Location = new System.Drawing.Point(123, 125);
            this.horai.Name = "horai";
            this.horai.ShowUpDown = true;
            this.horai.Size = new System.Drawing.Size(93, 20);
            this.horai.TabIndex = 37;
            this.horai.FormatChanged += new System.EventHandler(this.horai_FormatChanged);
            // 
            // horaf
            // 
            this.horaf.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.horaf.Location = new System.Drawing.Point(222, 125);
            this.horaf.Name = "horaf";
            this.horaf.ShowUpDown = true;
            this.horaf.Size = new System.Drawing.Size(93, 20);
            this.horaf.TabIndex = 38;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(123, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 41;
            this.label4.Text = "Nombre";
            // 
            // editar
            // 
            this.editar.Location = new System.Drawing.Point(25, 168);
            this.editar.Name = "editar";
            this.editar.Size = new System.Drawing.Size(75, 23);
            this.editar.TabIndex = 42;
            this.editar.Text = "Editar";
            this.editar.UseVisualStyleBackColor = true;
            this.editar.Visible = false;
            this.editar.Click += new System.EventHandler(this.editar_Click);
            // 
            // nombre
            // 
            this.nombre.Location = new System.Drawing.Point(173, 76);
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            this.nombre.Size = new System.Drawing.Size(142, 20);
            this.nombre.TabIndex = 44;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.AliceBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(460, 67);
            this.panel1.TabIndex = 45;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(7, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(37, 42);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // cancelarEditar
            // 
            this.cancelarEditar.Location = new System.Drawing.Point(240, 154);
            this.cancelarEditar.Name = "cancelarEditar";
            this.cancelarEditar.Size = new System.Drawing.Size(75, 37);
            this.cancelarEditar.TabIndex = 46;
            this.cancelarEditar.Text = "Cancelar Edición";
            this.cancelarEditar.UseVisualStyleBackColor = true;
            this.cancelarEditar.Visible = false;
            this.cancelarEditar.Click += new System.EventHandler(this.cancelarEditar_Click);
            // 
            // eliminar
            // 
            this.eliminar.Location = new System.Drawing.Point(240, 167);
            this.eliminar.Name = "eliminar";
            this.eliminar.Size = new System.Drawing.Size(75, 23);
            this.eliminar.TabIndex = 43;
            this.eliminar.Text = "Eliminar";
            this.eliminar.UseVisualStyleBackColor = true;
            this.eliminar.Click += new System.EventHandler(this.eliminar_Click);
            // 
            // Horarios_editar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 469);
            this.Controls.Add(this.cancelarEditar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.eliminar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.agregar);
            this.Controls.Add(this.tablaHorario);
            this.Controls.Add(this.horaf);
            this.Controls.Add(this.horai);
            this.Controls.Add(this.dias);
            this.Controls.Add(this.idEmpleado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.editar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Horarios_editar";
            this.Text = "Horarios";
            this.Load += new System.EventHandler(this.Horarios_editar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablaHorario)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox idEmpleado;
        private System.Windows.Forms.ComboBox dias;
        private System.Windows.Forms.DataGridView tablaHorario;
        private System.Windows.Forms.Button agregar;
        private System.Windows.Forms.DateTimePicker horai;
        private System.Windows.Forms.DateTimePicker horaf;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button editar;
        private System.Windows.Forms.TextBox nombre;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button cancelarEditar;
        private System.Windows.Forms.Button eliminar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Inicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fin;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estatus;
    }
}