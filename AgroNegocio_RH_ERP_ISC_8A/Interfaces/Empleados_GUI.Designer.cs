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
            this.inicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarEmpleadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarEmpleadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tablaEmpleados = new System.Windows.Forms.DataGridView();
            this.ID_Empleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre_Empleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fNacimiento_Empleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fContratacion_Empleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estatus_Empleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buscarEmpleadoTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_buscarEmpleado = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaEmpleados)).BeginInit();
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
            this.eliminarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 25);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // inicioToolStripMenuItem
            // 
            this.inicioToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("inicioToolStripMenuItem.Image")));
            this.inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            this.inicioToolStripMenuItem.Size = new System.Drawing.Size(70, 21);
            this.inicioToolStripMenuItem.Text = "Inicio";
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
            // 
            // tablaEmpleados
            // 
            this.tablaEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaEmpleados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_Empleado,
            this.Nombre_Empleado,
            this.fNacimiento_Empleado,
            this.fContratacion_Empleado,
            this.Estatus_Empleado});
            this.tablaEmpleados.Location = new System.Drawing.Point(77, 250);
            this.tablaEmpleados.Margin = new System.Windows.Forms.Padding(5);
            this.tablaEmpleados.Name = "tablaEmpleados";
            this.tablaEmpleados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tablaEmpleados.Size = new System.Drawing.Size(614, 235);
            this.tablaEmpleados.TabIndex = 5;
            this.tablaEmpleados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablaEmpleados_CellContentClick);
            // 
            // ID_Empleado
            // 
            this.ID_Empleado.HeaderText = "ID";
            this.ID_Empleado.Name = "ID_Empleado";
            this.ID_Empleado.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ID_Empleado.Width = 50;
            // 
            // Nombre_Empleado
            // 
            this.Nombre_Empleado.HeaderText = "Nombre";
            this.Nombre_Empleado.Name = "Nombre_Empleado";
            this.Nombre_Empleado.Width = 150;
            // 
            // fNacimiento_Empleado
            // 
            this.fNacimiento_Empleado.HeaderText = "Fecha Nacimiento ";
            this.fNacimiento_Empleado.Name = "fNacimiento_Empleado";
            this.fNacimiento_Empleado.Width = 170;
            // 
            // fContratacion_Empleado
            // 
            this.fContratacion_Empleado.HeaderText = "Fecha Contratación";
            this.fContratacion_Empleado.Name = "fContratacion_Empleado";
            // 
            // Estatus_Empleado
            // 
            this.Estatus_Empleado.HeaderText = "Estatus";
            this.Estatus_Empleado.Name = "Estatus_Empleado";
            // 
            // buscarEmpleadoTxt
            // 
            this.buscarEmpleadoTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buscarEmpleadoTxt.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.buscarEmpleadoTxt.Location = new System.Drawing.Point(388, 154);
            this.buscarEmpleadoTxt.Margin = new System.Windows.Forms.Padding(5);
            this.buscarEmpleadoTxt.Name = "buscarEmpleadoTxt";
            this.buscarEmpleadoTxt.Size = new System.Drawing.Size(259, 26);
            this.buscarEmpleadoTxt.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(205, 152);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 31);
            this.label1.TabIndex = 12;
            this.label1.Text = "Empleados";
            // 
            // btn_buscarEmpleado
            // 
            this.btn_buscarEmpleado.Image = ((System.Drawing.Image)(resources.GetObject("btn_buscarEmpleado.Image")));
            this.btn_buscarEmpleado.Location = new System.Drawing.Point(643, 152);
            this.btn_buscarEmpleado.Margin = new System.Windows.Forms.Padding(5);
            this.btn_buscarEmpleado.Name = "btn_buscarEmpleado";
            this.btn_buscarEmpleado.Size = new System.Drawing.Size(45, 31);
            this.btn_buscarEmpleado.TabIndex = 14;
            this.btn_buscarEmpleado.UseVisualStyleBackColor = true;
            // 
            // Empleados_GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 597);
            this.Controls.Add(this.btn_buscarEmpleado);
            this.Controls.Add(this.buscarEmpleadoTxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tablaEmpleados);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Empleados_GUI";
            this.Text = "Empleados_GUI";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaEmpleados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem inicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarEmpleadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarEmpleadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private System.Windows.Forms.DataGridView tablaEmpleados;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Empleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre_Empleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn fNacimiento_Empleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn fContratacion_Empleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estatus_Empleado;
        private System.Windows.Forms.Button btn_buscarEmpleado;
        private System.Windows.Forms.TextBox buscarEmpleadoTxt;
        private System.Windows.Forms.Label label1;
    }
}