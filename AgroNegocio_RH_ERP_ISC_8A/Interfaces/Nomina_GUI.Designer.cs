namespace AgroNegocio_RH_ERP_ISC_8A.Interfaces
{
    partial class Nomina_GUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Nomina_GUI));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.inicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nóminaPercepcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nóminaDeduccionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.atrásToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevaNóminaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarNóminaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbl_total = new System.Windows.Forms.Label();
            this.lbl_pagina = new System.Windows.Forms.Label();
            this.btn_anterior = new System.Windows.Forms.Button();
            this.btn_siguiente = new System.Windows.Forms.Button();
            this.btn_buscarNomina = new System.Windows.Forms.Button();
            this.buscarNomina = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nombre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inicioToolStripMenuItem,
            this.atrásToolStripMenuItem,
            this.nuevaNóminaToolStripMenuItem,
            this.editarNóminaToolStripMenuItem,
            this.eliminarToolStripMenuItem,
            this.nóminaPercepcionesToolStripMenuItem,
            this.nóminaDeduccionesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(832, 25);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // inicioToolStripMenuItem
            // 
            this.inicioToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("inicioToolStripMenuItem.Image")));
            this.inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            this.inicioToolStripMenuItem.Size = new System.Drawing.Size(70, 21);
            this.inicioToolStripMenuItem.Text = "Inicio";
            // 
            // nóminaPercepcionesToolStripMenuItem
            // 
            this.nóminaPercepcionesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("nóminaPercepcionesToolStripMenuItem.Image")));
            this.nóminaPercepcionesToolStripMenuItem.Name = "nóminaPercepcionesToolStripMenuItem";
            this.nóminaPercepcionesToolStripMenuItem.Size = new System.Drawing.Size(169, 21);
            this.nóminaPercepcionesToolStripMenuItem.Text = "Nómina percepciones";
            // 
            // nóminaDeduccionesToolStripMenuItem
            // 
            this.nóminaDeduccionesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("nóminaDeduccionesToolStripMenuItem.Image")));
            this.nóminaDeduccionesToolStripMenuItem.Name = "nóminaDeduccionesToolStripMenuItem";
            this.nóminaDeduccionesToolStripMenuItem.Size = new System.Drawing.Size(165, 21);
            this.nóminaDeduccionesToolStripMenuItem.Text = "Nómina deducciones";
            // 
            // atrásToolStripMenuItem
            // 
            this.atrásToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("atrásToolStripMenuItem.Image")));
            this.atrásToolStripMenuItem.Name = "atrásToolStripMenuItem";
            this.atrásToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.atrásToolStripMenuItem.Text = "Atrás";
            // 
            // nuevaNóminaToolStripMenuItem
            // 
            this.nuevaNóminaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("nuevaNóminaToolStripMenuItem.Image")));
            this.nuevaNóminaToolStripMenuItem.Name = "nuevaNóminaToolStripMenuItem";
            this.nuevaNóminaToolStripMenuItem.Size = new System.Drawing.Size(126, 21);
            this.nuevaNóminaToolStripMenuItem.Text = "Nueva nómina";
            // 
            // editarNóminaToolStripMenuItem
            // 
            this.editarNóminaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("editarNóminaToolStripMenuItem.Image")));
            this.editarNóminaToolStripMenuItem.Name = "editarNóminaToolStripMenuItem";
            this.editarNóminaToolStripMenuItem.Size = new System.Drawing.Size(123, 21);
            this.editarNóminaToolStripMenuItem.Text = "Editar nómina";
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("eliminarToolStripMenuItem.Image")));
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(87, 21);
            this.eliminarToolStripMenuItem.Text = "Eliminar";
            // 
            // lbl_total
            // 
            this.lbl_total.AutoSize = true;
            this.lbl_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_total.Location = new System.Drawing.Point(417, 401);
            this.lbl_total.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(34, 20);
            this.lbl_total.TabIndex = 25;
            this.lbl_total.Text = "de ";
            // 
            // lbl_pagina
            // 
            this.lbl_pagina.AutoSize = true;
            this.lbl_pagina.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pagina.Location = new System.Drawing.Point(318, 401);
            this.lbl_pagina.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_pagina.Name = "lbl_pagina";
            this.lbl_pagina.Size = new System.Drawing.Size(69, 20);
            this.lbl_pagina.TabIndex = 24;
            this.lbl_pagina.Text = "Página ";
            // 
            // btn_anterior
            // 
            this.btn_anterior.Image = ((System.Drawing.Image)(resources.GetObject("btn_anterior.Image")));
            this.btn_anterior.Location = new System.Drawing.Point(261, 394);
            this.btn_anterior.Margin = new System.Windows.Forms.Padding(5);
            this.btn_anterior.Name = "btn_anterior";
            this.btn_anterior.Size = new System.Drawing.Size(34, 34);
            this.btn_anterior.TabIndex = 23;
            this.btn_anterior.UseVisualStyleBackColor = true;
            // 
            // btn_siguiente
            // 
            this.btn_siguiente.Image = ((System.Drawing.Image)(resources.GetObject("btn_siguiente.Image")));
            this.btn_siguiente.Location = new System.Drawing.Point(483, 394);
            this.btn_siguiente.Margin = new System.Windows.Forms.Padding(5);
            this.btn_siguiente.Name = "btn_siguiente";
            this.btn_siguiente.Size = new System.Drawing.Size(32, 34);
            this.btn_siguiente.TabIndex = 22;
            this.btn_siguiente.UseVisualStyleBackColor = true;
            // 
            // btn_buscarNomina
            // 
            this.btn_buscarNomina.Image = ((System.Drawing.Image)(resources.GetObject("btn_buscarNomina.Image")));
            this.btn_buscarNomina.Location = new System.Drawing.Point(709, 89);
            this.btn_buscarNomina.Margin = new System.Windows.Forms.Padding(5);
            this.btn_buscarNomina.Name = "btn_buscarNomina";
            this.btn_buscarNomina.Size = new System.Drawing.Size(43, 29);
            this.btn_buscarNomina.TabIndex = 21;
            this.btn_buscarNomina.UseVisualStyleBackColor = true;
            // 
            // buscarNomina
            // 
            this.buscarNomina.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buscarNomina.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.buscarNomina.Location = new System.Drawing.Point(452, 91);
            this.buscarNomina.Margin = new System.Windows.Forms.Padding(5);
            this.buscarNomina.Name = "buscarNomina";
            this.buscarNomina.Size = new System.Drawing.Size(259, 26);
            this.buscarNomina.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(62, 48);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 31);
            this.label1.TabIndex = 19;
            this.label1.Text = "Nómina";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(67, 125);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(685, 248);
            this.dataGridView1.TabIndex = 26;
            // 
            // nombre
            // 
            this.nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombre.Location = new System.Drawing.Point(164, 93);
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            this.nombre.Size = new System.Drawing.Size(174, 26);
            this.nombre.TabIndex = 46;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(64, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 20);
            this.label4.TabIndex = 45;
            this.label4.Text = "Empleado:";
            // 
            // Nomina_GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 466);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lbl_total);
            this.Controls.Add(this.lbl_pagina);
            this.Controls.Add(this.btn_anterior);
            this.Controls.Add(this.btn_siguiente);
            this.Controls.Add(this.btn_buscarNomina);
            this.Controls.Add(this.buscarNomina);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Nomina_GUI";
            this.Text = "Nomina";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem inicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem atrásToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevaNóminaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarNóminaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nóminaPercepcionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nóminaDeduccionesToolStripMenuItem;
        private System.Windows.Forms.Label lbl_total;
        private System.Windows.Forms.Label lbl_pagina;
        private System.Windows.Forms.Button btn_anterior;
        private System.Windows.Forms.Button btn_siguiente;
        private System.Windows.Forms.Button btn_buscarNomina;
        private System.Windows.Forms.TextBox buscarNomina;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox nombre;
        private System.Windows.Forms.Label label4;
    }
}