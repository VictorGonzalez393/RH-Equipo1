namespace AgroNegocio_RH_ERP_ISC_8A.Interfaces
{
    partial class pago_GUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pago_GUI));
            this.tablaPagos = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.inicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarpagoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarpagoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.buscar_pago = new System.Windows.Forms.TextBox();
            this.lbl_total = new System.Windows.Forms.Label();
            this.lbl_pagina = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_anterior = new System.Windows.Forms.Button();
            this.btn_siguiente = new System.Windows.Forms.Button();
            this.btn_buscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tablaPagos)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tablaPagos
            // 
            this.tablaPagos.AllowUserToAddRows = false;
            this.tablaPagos.AllowUserToDeleteRows = false;
            this.tablaPagos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaPagos.Location = new System.Drawing.Point(42, 150);
            this.tablaPagos.MultiSelect = false;
            this.tablaPagos.Name = "tablaPagos";
            this.tablaPagos.ReadOnly = true;
            this.tablaPagos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tablaPagos.Size = new System.Drawing.Size(393, 213);
            this.tablaPagos.TabIndex = 47;
            this.tablaPagos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablaPagos_CellContentClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inicioToolStripMenuItem,
            this.agregarpagoToolStripMenuItem,
            this.editarpagoToolStripMenuItem,
            this.eliminarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(10, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(470, 27);
            this.menuStrip1.TabIndex = 48;
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
            // agregarpagoToolStripMenuItem
            // 
            this.agregarpagoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("agregarpagoToolStripMenuItem.Image")));
            this.agregarpagoToolStripMenuItem.Name = "agregarpagoToolStripMenuItem";
            this.agregarpagoToolStripMenuItem.Size = new System.Drawing.Size(120, 21);
            this.agregarpagoToolStripMenuItem.Text = "Agregar Pago";
            this.agregarpagoToolStripMenuItem.Click += new System.EventHandler(this.agregarpagoToolStripMenuItem_Click);
            // 
            // editarpagoToolStripMenuItem
            // 
            this.editarpagoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("editarpagoToolStripMenuItem.Image")));
            this.editarpagoToolStripMenuItem.Name = "editarpagoToolStripMenuItem";
            this.editarpagoToolStripMenuItem.Size = new System.Drawing.Size(107, 21);
            this.editarpagoToolStripMenuItem.Text = "Editar Pago";
            this.editarpagoToolStripMenuItem.Click += new System.EventHandler(this.editarpagoToolStripMenuItem_Click);
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("eliminarToolStripMenuItem.Image")));
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(87, 21);
            this.eliminarToolStripMenuItem.Text = "Eliminar";
            this.eliminarToolStripMenuItem.Click += new System.EventHandler(this.eliminarToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(118, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 31);
            this.label1.TabIndex = 49;
            this.label1.Text = "Formas de Pago";
            // 
            // buscar_pago
            // 
            this.buscar_pago.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buscar_pago.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.buscar_pago.Location = new System.Drawing.Point(124, 90);
            this.buscar_pago.Margin = new System.Windows.Forms.Padding(5);
            this.buscar_pago.Name = "buscar_pago";
            this.buscar_pago.Size = new System.Drawing.Size(202, 26);
            this.buscar_pago.TabIndex = 50;
            // 
            // lbl_total
            // 
            this.lbl_total.AutoSize = true;
            this.lbl_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_total.Location = new System.Drawing.Point(259, 390);
            this.lbl_total.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(34, 20);
            this.lbl_total.TabIndex = 55;
            this.lbl_total.Text = "de ";
            // 
            // lbl_pagina
            // 
            this.lbl_pagina.AutoSize = true;
            this.lbl_pagina.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pagina.Location = new System.Drawing.Point(160, 390);
            this.lbl_pagina.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_pagina.Name = "lbl_pagina";
            this.lbl_pagina.Size = new System.Drawing.Size(69, 20);
            this.lbl_pagina.TabIndex = 54;
            this.lbl_pagina.Text = "Página ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(60, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(36, 31);
            this.pictureBox1.TabIndex = 56;
            this.pictureBox1.TabStop = false;
            // 
            // btn_anterior
            // 
            this.btn_anterior.Image = ((System.Drawing.Image)(resources.GetObject("btn_anterior.Image")));
            this.btn_anterior.Location = new System.Drawing.Point(103, 383);
            this.btn_anterior.Margin = new System.Windows.Forms.Padding(5);
            this.btn_anterior.Name = "btn_anterior";
            this.btn_anterior.Size = new System.Drawing.Size(34, 34);
            this.btn_anterior.TabIndex = 53;
            this.btn_anterior.UseVisualStyleBackColor = true;
            this.btn_anterior.Click += new System.EventHandler(this.btn_anterior_Click);
            // 
            // btn_siguiente
            // 
            this.btn_siguiente.Image = ((System.Drawing.Image)(resources.GetObject("btn_siguiente.Image")));
            this.btn_siguiente.Location = new System.Drawing.Point(325, 383);
            this.btn_siguiente.Margin = new System.Windows.Forms.Padding(5);
            this.btn_siguiente.Name = "btn_siguiente";
            this.btn_siguiente.Size = new System.Drawing.Size(32, 34);
            this.btn_siguiente.TabIndex = 52;
            this.btn_siguiente.UseVisualStyleBackColor = true;
            this.btn_siguiente.Click += new System.EventHandler(this.btn_siguiente_Click);
            // 
            // btn_buscar
            // 
            this.btn_buscar.Image = ((System.Drawing.Image)(resources.GetObject("btn_buscar.Image")));
            this.btn_buscar.Location = new System.Drawing.Point(336, 90);
            this.btn_buscar.Margin = new System.Windows.Forms.Padding(5);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(32, 28);
            this.btn_buscar.TabIndex = 51;
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // pago_GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbl_total);
            this.Controls.Add(this.lbl_pagina);
            this.Controls.Add(this.btn_anterior);
            this.Controls.Add(this.btn_siguiente);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.buscar_pago);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.tablaPagos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "pago_GUI";
            this.Text = "Formas de Pago";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablaPagos)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView tablaPagos;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem inicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarpagoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarpagoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox buscar_pago;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.Label lbl_total;
        private System.Windows.Forms.Label lbl_pagina;
        private System.Windows.Forms.Button btn_anterior;
        private System.Windows.Forms.Button btn_siguiente;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}