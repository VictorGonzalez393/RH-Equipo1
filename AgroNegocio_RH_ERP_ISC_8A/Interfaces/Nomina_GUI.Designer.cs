﻿namespace AgroNegocio_RH_ERP_ISC_8A.Interfaces
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
            this.atrásToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevaNóminaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarNóminaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nóminaPercepcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nóminaDeduccionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbl_total = new System.Windows.Forms.Label();
            this.lbl_pagina = new System.Windows.Forms.Label();
            this.btn_anterior = new System.Windows.Forms.Button();
            this.btn_siguiente = new System.Windows.Forms.Button();
            this.btn_buscarNomina = new System.Windows.Forms.Button();
            this.buscarNominaTXT = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tablaNomina = new System.Windows.Forms.DataGridView();
            this.nombre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.descargarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaNomina)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.nóminaDeduccionesToolStripMenuItem,
            this.descargarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(911, 25);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // inicioToolStripMenuItem
            // 
            this.inicioToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("inicioToolStripMenuItem.Image")));
            this.inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            this.inicioToolStripMenuItem.Size = new System.Drawing.Size(70, 21);
            this.inicioToolStripMenuItem.Text = "Inicio";
            this.inicioToolStripMenuItem.Click += new System.EventHandler(this.inicioToolStripMenuItem_Click);
            // 
            // atrásToolStripMenuItem
            // 
            this.atrásToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("atrásToolStripMenuItem.Image")));
            this.atrásToolStripMenuItem.Name = "atrásToolStripMenuItem";
            this.atrásToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.atrásToolStripMenuItem.Text = "Atrás";
            this.atrásToolStripMenuItem.Click += new System.EventHandler(this.atrásToolStripMenuItem_Click);
            // 
            // nuevaNóminaToolStripMenuItem
            // 
            this.nuevaNóminaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("nuevaNóminaToolStripMenuItem.Image")));
            this.nuevaNóminaToolStripMenuItem.Name = "nuevaNóminaToolStripMenuItem";
            this.nuevaNóminaToolStripMenuItem.Size = new System.Drawing.Size(126, 21);
            this.nuevaNóminaToolStripMenuItem.Text = "Nueva nómina";
            this.nuevaNóminaToolStripMenuItem.Click += new System.EventHandler(this.nuevaNóminaToolStripMenuItem_Click);
            // 
            // editarNóminaToolStripMenuItem
            // 
            this.editarNóminaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("editarNóminaToolStripMenuItem.Image")));
            this.editarNóminaToolStripMenuItem.Name = "editarNóminaToolStripMenuItem";
            this.editarNóminaToolStripMenuItem.Size = new System.Drawing.Size(123, 21);
            this.editarNóminaToolStripMenuItem.Text = "Editar nómina";
            this.editarNóminaToolStripMenuItem.Click += new System.EventHandler(this.editarNóminaToolStripMenuItem_Click);
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("eliminarToolStripMenuItem.Image")));
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(87, 21);
            this.eliminarToolStripMenuItem.Text = "Eliminar";
            this.eliminarToolStripMenuItem.Click += new System.EventHandler(this.eliminarToolStripMenuItem_Click);
            // 
            // nóminaPercepcionesToolStripMenuItem
            // 
            this.nóminaPercepcionesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("nóminaPercepcionesToolStripMenuItem.Image")));
            this.nóminaPercepcionesToolStripMenuItem.Name = "nóminaPercepcionesToolStripMenuItem";
            this.nóminaPercepcionesToolStripMenuItem.Size = new System.Drawing.Size(169, 21);
            this.nóminaPercepcionesToolStripMenuItem.Text = "Nómina percepciones";
            this.nóminaPercepcionesToolStripMenuItem.Click += new System.EventHandler(this.nóminaPercepcionesToolStripMenuItem_Click);
            // 
            // nóminaDeduccionesToolStripMenuItem
            // 
            this.nóminaDeduccionesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("nóminaDeduccionesToolStripMenuItem.Image")));
            this.nóminaDeduccionesToolStripMenuItem.Name = "nóminaDeduccionesToolStripMenuItem";
            this.nóminaDeduccionesToolStripMenuItem.Size = new System.Drawing.Size(165, 21);
            this.nóminaDeduccionesToolStripMenuItem.Text = "Nómina deducciones";
            this.nóminaDeduccionesToolStripMenuItem.Click += new System.EventHandler(this.nóminaDeduccionesToolStripMenuItem_Click);
            // 
            // lbl_total
            // 
            this.lbl_total.AutoSize = true;
            this.lbl_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_total.Location = new System.Drawing.Point(469, 399);
            this.lbl_total.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(34, 20);
            this.lbl_total.TabIndex = 25;
            this.lbl_total.Text = "de ";
            // 
            // lbl_pagina
            // 
            this.lbl_pagina.AutoSize = true;
            this.lbl_pagina.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pagina.Location = new System.Drawing.Point(385, 399);
            this.lbl_pagina.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_pagina.Name = "lbl_pagina";
            this.lbl_pagina.Size = new System.Drawing.Size(69, 20);
            this.lbl_pagina.TabIndex = 24;
            this.lbl_pagina.Text = "Página ";
            // 
            // btn_anterior
            // 
            this.btn_anterior.Image = ((System.Drawing.Image)(resources.GetObject("btn_anterior.Image")));
            this.btn_anterior.Location = new System.Drawing.Point(336, 392);
            this.btn_anterior.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_anterior.Name = "btn_anterior";
            this.btn_anterior.Size = new System.Drawing.Size(29, 34);
            this.btn_anterior.TabIndex = 23;
            this.btn_anterior.UseVisualStyleBackColor = true;
            this.btn_anterior.Click += new System.EventHandler(this.btn_anterior_Click);
            // 
            // btn_siguiente
            // 
            this.btn_siguiente.Image = ((System.Drawing.Image)(resources.GetObject("btn_siguiente.Image")));
            this.btn_siguiente.Location = new System.Drawing.Point(526, 392);
            this.btn_siguiente.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_siguiente.Name = "btn_siguiente";
            this.btn_siguiente.Size = new System.Drawing.Size(27, 34);
            this.btn_siguiente.TabIndex = 22;
            this.btn_siguiente.UseVisualStyleBackColor = true;
            this.btn_siguiente.Click += new System.EventHandler(this.btn_siguiente_Click);
            // 
            // btn_buscarNomina
            // 
            this.btn_buscarNomina.Image = ((System.Drawing.Image)(resources.GetObject("btn_buscarNomina.Image")));
            this.btn_buscarNomina.Location = new System.Drawing.Point(799, 88);
            this.btn_buscarNomina.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_buscarNomina.Name = "btn_buscarNomina";
            this.btn_buscarNomina.Size = new System.Drawing.Size(37, 29);
            this.btn_buscarNomina.TabIndex = 21;
            this.btn_buscarNomina.UseVisualStyleBackColor = true;
            this.btn_buscarNomina.Click += new System.EventHandler(this.btn_buscarNomina_Click);
            // 
            // buscarNominaTXT
            // 
            this.buscarNominaTXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buscarNominaTXT.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.buscarNominaTXT.Location = new System.Drawing.Point(625, 90);
            this.buscarNominaTXT.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buscarNominaTXT.Name = "buscarNominaTXT";
            this.buscarNominaTXT.Size = new System.Drawing.Size(176, 26);
            this.buscarNominaTXT.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(50, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 37);
            this.label1.TabIndex = 19;
            this.label1.Text = "Nómina";
            // 
            // tablaNomina
            // 
            this.tablaNomina.AllowUserToAddRows = false;
            this.tablaNomina.AllowUserToDeleteRows = false;
            this.tablaNomina.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaNomina.Location = new System.Drawing.Point(59, 125);
            this.tablaNomina.Name = "tablaNomina";
            this.tablaNomina.ReadOnly = true;
            this.tablaNomina.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tablaNomina.Size = new System.Drawing.Size(779, 248);
            this.tablaNomina.TabIndex = 26;
            // 
            // nombre
            // 
            this.nombre.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombre.Location = new System.Drawing.Point(141, 93);
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            this.nombre.Size = new System.Drawing.Size(192, 26);
            this.nombre.TabIndex = 46;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(55, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 20);
            this.label4.TabIndex = 45;
            this.label4.Text = "Empleado:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(10, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(36, 31);
            this.pictureBox1.TabIndex = 47;
            this.pictureBox1.TabStop = false;
            // 
            // descargarToolStripMenuItem
            // 
            this.descargarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("descargarToolStripMenuItem.Image")));
            this.descargarToolStripMenuItem.Name = "descargarToolStripMenuItem";
            this.descargarToolStripMenuItem.Size = new System.Drawing.Size(97, 21);
            this.descargarToolStripMenuItem.Text = "Descargar";
            // 
            // Nomina_GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 466);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tablaNomina);
            this.Controls.Add(this.lbl_total);
            this.Controls.Add(this.lbl_pagina);
            this.Controls.Add(this.btn_anterior);
            this.Controls.Add(this.btn_siguiente);
            this.Controls.Add(this.btn_buscarNomina);
            this.Controls.Add(this.buscarNominaTXT);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Nomina_GUI";
            this.Text = "Nomina";
            this.Load += new System.EventHandler(this.Nomina_GUI_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaNomina)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.TextBox buscarNominaTXT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView tablaNomina;
        private System.Windows.Forms.TextBox nombre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem descargarToolStripMenuItem;
    }
}