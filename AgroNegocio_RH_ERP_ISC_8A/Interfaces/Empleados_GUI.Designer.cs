namespace AgroNegocio_RH_ERP_ISC_8A.Interfaces
{
    partial class Empleados_GUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Empleados_GUI));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.buscarEmpleado = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_total = new System.Windows.Forms.Label();
            this.lbl_pagina = new System.Windows.Forms.Label();
            this.tablaEmpleados1 = new System.Windows.Forms.DataGridView();
            this.btn_anterior = new System.Windows.Forms.Button();
            this.btn_siguiente = new System.Windows.Forms.Button();
            this.btn_buscarEmpleado = new System.Windows.Forms.Button();
            this.inicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarEmpleadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarEmpleadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verHorarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.documentaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.permisosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ausenciasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vacacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nóminaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaEmpleados1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inicioToolStripMenuItem,
            this.agregarEmpleadoToolStripMenuItem,
            this.editarEmpleadoToolStripMenuItem,
            this.eliminarToolStripMenuItem,
            this.verHorarioToolStripMenuItem,
            this.documentaciónToolStripMenuItem,
            this.permisosToolStripMenuItem,
            this.nóminaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(936, 25);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // buscarEmpleado
            // 
            this.buscarEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buscarEmpleado.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.buscarEmpleado.Location = new System.Drawing.Point(269, 47);
            this.buscarEmpleado.Margin = new System.Windows.Forms.Padding(5);
            this.buscarEmpleado.Name = "buscarEmpleado";
            this.buscarEmpleado.Size = new System.Drawing.Size(259, 26);
            this.buscarEmpleado.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(86, 45);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 31);
            this.label1.TabIndex = 12;
            this.label1.Text = "Empleados";
            // 
            // lbl_total
            // 
            this.lbl_total.AutoSize = true;
            this.lbl_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_total.Location = new System.Drawing.Point(458, 399);
            this.lbl_total.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(34, 20);
            this.lbl_total.TabIndex = 18;
            this.lbl_total.Text = "de ";
            // 
            // lbl_pagina
            // 
            this.lbl_pagina.AutoSize = true;
            this.lbl_pagina.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pagina.Location = new System.Drawing.Point(359, 399);
            this.lbl_pagina.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_pagina.Name = "lbl_pagina";
            this.lbl_pagina.Size = new System.Drawing.Size(69, 20);
            this.lbl_pagina.TabIndex = 17;
            this.lbl_pagina.Text = "Página ";
            // 
            // tablaEmpleados1
            // 
            this.tablaEmpleados1.AllowUserToAddRows = false;
            this.tablaEmpleados1.AllowUserToDeleteRows = false;
            this.tablaEmpleados1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaEmpleados1.Location = new System.Drawing.Point(107, 115);
            this.tablaEmpleados1.Name = "tablaEmpleados1";
            this.tablaEmpleados1.ReadOnly = true;
            this.tablaEmpleados1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tablaEmpleados1.Size = new System.Drawing.Size(765, 244);
            this.tablaEmpleados1.TabIndex = 19;
            // 
            // btn_anterior
            // 
            this.btn_anterior.Image = ((System.Drawing.Image)(resources.GetObject("btn_anterior.Image")));
            this.btn_anterior.Location = new System.Drawing.Point(302, 392);
            this.btn_anterior.Margin = new System.Windows.Forms.Padding(5);
            this.btn_anterior.Name = "btn_anterior";
            this.btn_anterior.Size = new System.Drawing.Size(34, 34);
            this.btn_anterior.TabIndex = 16;
            this.btn_anterior.UseVisualStyleBackColor = true;
            this.btn_anterior.Click += new System.EventHandler(this.btn_anterior_Click);
            // 
            // btn_siguiente
            // 
            this.btn_siguiente.Image = ((System.Drawing.Image)(resources.GetObject("btn_siguiente.Image")));
            this.btn_siguiente.Location = new System.Drawing.Point(524, 392);
            this.btn_siguiente.Margin = new System.Windows.Forms.Padding(5);
            this.btn_siguiente.Name = "btn_siguiente";
            this.btn_siguiente.Size = new System.Drawing.Size(32, 34);
            this.btn_siguiente.TabIndex = 15;
            this.btn_siguiente.UseVisualStyleBackColor = true;
            this.btn_siguiente.Click += new System.EventHandler(this.btn_siguiente_Click_1);
            // 
            // btn_buscarEmpleado
            // 
            this.btn_buscarEmpleado.Image = ((System.Drawing.Image)(resources.GetObject("btn_buscarEmpleado.Image")));
            this.btn_buscarEmpleado.Location = new System.Drawing.Point(524, 45);
            this.btn_buscarEmpleado.Margin = new System.Windows.Forms.Padding(5);
            this.btn_buscarEmpleado.Name = "btn_buscarEmpleado";
            this.btn_buscarEmpleado.Size = new System.Drawing.Size(45, 31);
            this.btn_buscarEmpleado.TabIndex = 14;
            this.btn_buscarEmpleado.UseVisualStyleBackColor = true;
            this.btn_buscarEmpleado.Click += new System.EventHandler(this.btn_buscarEmpleado_Click);
            // 
            // inicioToolStripMenuItem
            // 
            this.inicioToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("inicioToolStripMenuItem.Image")));
            this.inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            this.inicioToolStripMenuItem.Size = new System.Drawing.Size(70, 21);
            this.inicioToolStripMenuItem.Text = "Inicio";
            this.inicioToolStripMenuItem.Click += new System.EventHandler(this.inicioToolStripMenuItem_Click);
            // 
            // agregarEmpleadoToolStripMenuItem
            // 
            this.agregarEmpleadoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("agregarEmpleadoToolStripMenuItem.Image")));
            this.agregarEmpleadoToolStripMenuItem.Name = "agregarEmpleadoToolStripMenuItem";
            this.agregarEmpleadoToolStripMenuItem.Size = new System.Drawing.Size(150, 21);
            this.agregarEmpleadoToolStripMenuItem.Text = "Agregar Empleado";
            this.agregarEmpleadoToolStripMenuItem.Click += new System.EventHandler(this.agregarEmpleadoToolStripMenuItem_Click);
            // 
            // editarEmpleadoToolStripMenuItem
            // 
            this.editarEmpleadoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("editarEmpleadoToolStripMenuItem.Image")));
            this.editarEmpleadoToolStripMenuItem.Name = "editarEmpleadoToolStripMenuItem";
            this.editarEmpleadoToolStripMenuItem.Size = new System.Drawing.Size(137, 21);
            this.editarEmpleadoToolStripMenuItem.Text = "Editar Empleado";
            this.editarEmpleadoToolStripMenuItem.Click += new System.EventHandler(this.editarEmpleadoToolStripMenuItem_Click);
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("eliminarToolStripMenuItem.Image")));
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(87, 21);
            this.eliminarToolStripMenuItem.Text = "Eliminar";
            this.eliminarToolStripMenuItem.Click += new System.EventHandler(this.eliminarToolStripMenuItem_Click);
            // 
            // verHorarioToolStripMenuItem
            // 
            this.verHorarioToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("verHorarioToolStripMenuItem.Image")));
            this.verHorarioToolStripMenuItem.Name = "verHorarioToolStripMenuItem";
            this.verHorarioToolStripMenuItem.Size = new System.Drawing.Size(107, 21);
            this.verHorarioToolStripMenuItem.Text = "Ver Horario";
            this.verHorarioToolStripMenuItem.Click += new System.EventHandler(this.editarHorarioToolStripMenuItem_Click);
            // 
            // documentaciónToolStripMenuItem
            // 
            this.documentaciónToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("documentaciónToolStripMenuItem.Image")));
            this.documentaciónToolStripMenuItem.Name = "documentaciónToolStripMenuItem";
            this.documentaciónToolStripMenuItem.Size = new System.Drawing.Size(133, 21);
            this.documentaciónToolStripMenuItem.Text = "Documentación";
            // 
            // permisosToolStripMenuItem
            // 
            this.permisosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ausenciasToolStripMenuItem,
            this.vacacionesToolStripMenuItem});
            this.permisosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("permisosToolStripMenuItem.Image")));
            this.permisosToolStripMenuItem.Name = "permisosToolStripMenuItem";
            this.permisosToolStripMenuItem.Size = new System.Drawing.Size(92, 21);
            this.permisosToolStripMenuItem.Text = "Permisos";
            // 
            // ausenciasToolStripMenuItem
            // 
            this.ausenciasToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ausenciasToolStripMenuItem.Image")));
            this.ausenciasToolStripMenuItem.Name = "ausenciasToolStripMenuItem";
            this.ausenciasToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.ausenciasToolStripMenuItem.Text = "Ausencias";
            // 
            // vacacionesToolStripMenuItem
            // 
            this.vacacionesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("vacacionesToolStripMenuItem.Image")));
            this.vacacionesToolStripMenuItem.Name = "vacacionesToolStripMenuItem";
            this.vacacionesToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.vacacionesToolStripMenuItem.Text = "Vacaciones";
            // 
            // nóminaToolStripMenuItem
            // 
            this.nóminaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("nóminaToolStripMenuItem.Image")));
            this.nóminaToolStripMenuItem.Name = "nóminaToolStripMenuItem";
            this.nóminaToolStripMenuItem.Size = new System.Drawing.Size(85, 21);
            this.nóminaToolStripMenuItem.Text = "Nómina";
            this.nóminaToolStripMenuItem.Click += new System.EventHandler(this.nóminaToolStripMenuItem_Click);
            // 
            // Empleados_GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 443);
            this.Controls.Add(this.tablaEmpleados1);
            this.Controls.Add(this.lbl_total);
            this.Controls.Add(this.lbl_pagina);
            this.Controls.Add(this.btn_anterior);
            this.Controls.Add(this.btn_siguiente);
            this.Controls.Add(this.btn_buscarEmpleado);
            this.Controls.Add(this.buscarEmpleado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Empleados_GUI";
            this.Text = "Empleados";
            this.Load += new System.EventHandler(this.Empleados_GUI_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaEmpleados1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem inicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarEmpleadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarEmpleadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private System.Windows.Forms.Button btn_buscarEmpleado;
        private System.Windows.Forms.TextBox buscarEmpleado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_total;
        private System.Windows.Forms.Label lbl_pagina;
        private System.Windows.Forms.Button btn_anterior;
        private System.Windows.Forms.Button btn_siguiente;
        private System.Windows.Forms.DataGridView tablaEmpleados1;
        private System.Windows.Forms.ToolStripMenuItem verHorarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem documentaciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem permisosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ausenciasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vacacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nóminaToolStripMenuItem;
    }
}