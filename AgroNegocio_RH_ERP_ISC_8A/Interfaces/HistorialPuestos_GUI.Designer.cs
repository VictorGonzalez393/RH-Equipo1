namespace AgroNegocio_RH_ERP_ISC_8A.Interfaces
{
    partial class HistorialPuestos_GUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HistorialPuestos_GUI));
            this.tablaHistorialpuestos = new System.Windows.Forms.DataGridView();
            this.lbl_total = new System.Windows.Forms.Label();
            this.lbl_pagina = new System.Windows.Forms.Label();
            this.buscar_TXT = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_anterior = new System.Windows.Forms.Button();
            this.btn_siguiente = new System.Windows.Forms.Button();
            this.btn_buscarEmpleado = new System.Windows.Forms.Button();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.atrasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.tablaHistorialpuestos)).BeginInit();
            this.menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tablaHistorialpuestos
            // 
            this.tablaHistorialpuestos.AllowUserToAddRows = false;
            this.tablaHistorialpuestos.AllowUserToDeleteRows = false;
            this.tablaHistorialpuestos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaHistorialpuestos.Location = new System.Drawing.Point(13, 106);
            this.tablaHistorialpuestos.Name = "tablaHistorialpuestos";
            this.tablaHistorialpuestos.ReadOnly = true;
            this.tablaHistorialpuestos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tablaHistorialpuestos.Size = new System.Drawing.Size(765, 244);
            this.tablaHistorialpuestos.TabIndex = 27;
            this.tablaHistorialpuestos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablaHistorialpuestos_CellContentClick);
            // 
            // lbl_total
            // 
            this.lbl_total.AutoSize = true;
            this.lbl_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_total.Location = new System.Drawing.Point(379, 389);
            this.lbl_total.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(34, 20);
            this.lbl_total.TabIndex = 26;
            this.lbl_total.Text = "de ";
            // 
            // lbl_pagina
            // 
            this.lbl_pagina.AutoSize = true;
            this.lbl_pagina.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pagina.Location = new System.Drawing.Point(280, 389);
            this.lbl_pagina.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_pagina.Name = "lbl_pagina";
            this.lbl_pagina.Size = new System.Drawing.Size(69, 20);
            this.lbl_pagina.TabIndex = 25;
            this.lbl_pagina.Text = "Página ";
            // 
            // buscar_TXT
            // 
            this.buscar_TXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buscar_TXT.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.buscar_TXT.Location = new System.Drawing.Point(462, 72);
            this.buscar_TXT.Margin = new System.Windows.Forms.Padding(5);
            this.buscar_TXT.Name = "buscar_TXT";
            this.buscar_TXT.Size = new System.Drawing.Size(259, 26);
            this.buscar_TXT.TabIndex = 21;
            this.buscar_TXT.TextChanged += new System.EventHandler(this.nombre_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(64, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 31);
            this.label1.TabIndex = 20;
            this.label1.Text = "Historial de puestos";
            // 
            // btn_anterior
            // 
            this.btn_anterior.Image = ((System.Drawing.Image)(resources.GetObject("btn_anterior.Image")));
            this.btn_anterior.Location = new System.Drawing.Point(223, 382);
            this.btn_anterior.Margin = new System.Windows.Forms.Padding(5);
            this.btn_anterior.Name = "btn_anterior";
            this.btn_anterior.Size = new System.Drawing.Size(34, 34);
            this.btn_anterior.TabIndex = 24;
            this.btn_anterior.UseVisualStyleBackColor = true;
            this.btn_anterior.Click += new System.EventHandler(this.btn_anterior_Click);
            // 
            // btn_siguiente
            // 
            this.btn_siguiente.Image = ((System.Drawing.Image)(resources.GetObject("btn_siguiente.Image")));
            this.btn_siguiente.Location = new System.Drawing.Point(445, 382);
            this.btn_siguiente.Margin = new System.Windows.Forms.Padding(5);
            this.btn_siguiente.Name = "btn_siguiente";
            this.btn_siguiente.Size = new System.Drawing.Size(32, 34);
            this.btn_siguiente.TabIndex = 23;
            this.btn_siguiente.UseVisualStyleBackColor = true;
            this.btn_siguiente.Click += new System.EventHandler(this.btn_siguiente_Click);
            // 
            // btn_buscarEmpleado
            // 
            this.btn_buscarEmpleado.Image = ((System.Drawing.Image)(resources.GetObject("btn_buscarEmpleado.Image")));
            this.btn_buscarEmpleado.Location = new System.Drawing.Point(717, 70);
            this.btn_buscarEmpleado.Margin = new System.Windows.Forms.Padding(5);
            this.btn_buscarEmpleado.Name = "btn_buscarEmpleado";
            this.btn_buscarEmpleado.Size = new System.Drawing.Size(45, 31);
            this.btn_buscarEmpleado.TabIndex = 22;
            this.btn_buscarEmpleado.UseVisualStyleBackColor = true;
            this.btn_buscarEmpleado.Click += new System.EventHandler(this.btn_buscarEmpleado_Click);
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("editarToolStripMenuItem.Image")));
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(129, 21);
            this.editarToolStripMenuItem.Text = "Editar Historial";
            this.editarToolStripMenuItem.Click += new System.EventHandler(this.editarToolStripMenuItem_Click);
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.menu.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.atrasToolStripMenuItem,
            this.editarToolStripMenuItem});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Padding = new System.Windows.Forms.Padding(17, 5, 0, 5);
            this.menu.Size = new System.Drawing.Size(800, 31);
            this.menu.TabIndex = 28;
            this.menu.Text = "menuStrip1";
            // 
            // atrasToolStripMenuItem
            // 
            this.atrasToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("atrasToolStripMenuItem.Image")));
            this.atrasToolStripMenuItem.Name = "atrasToolStripMenuItem";
            this.atrasToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.atrasToolStripMenuItem.Text = "Atrás";
            this.atrasToolStripMenuItem.Click += new System.EventHandler(this.atrasToolStripMenuItem_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(166, 67);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(192, 26);
            this.textBox1.TabIndex = 48;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(66, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 20);
            this.label4.TabIndex = 47;
            this.label4.Text = "Empleado:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 56);
            this.pictureBox1.TabIndex = 49;
            this.pictureBox1.TabStop = false;
            // 
            // HistorialPuestos_GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.tablaHistorialpuestos);
            this.Controls.Add(this.lbl_total);
            this.Controls.Add(this.lbl_pagina);
            this.Controls.Add(this.btn_anterior);
            this.Controls.Add(this.btn_siguiente);
            this.Controls.Add(this.btn_buscarEmpleado);
            this.Controls.Add(this.buscar_TXT);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HistorialPuestos_GUI";
            this.Text = "Historial Puestos";
            this.Load += new System.EventHandler(this.HistorialPuestos_GUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablaHistorialpuestos)).EndInit();
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tablaHistorialpuestos;
        private System.Windows.Forms.Label lbl_total;
        private System.Windows.Forms.Label lbl_pagina;
        private System.Windows.Forms.Button btn_anterior;
        private System.Windows.Forms.Button btn_siguiente;
        private System.Windows.Forms.Button btn_buscarEmpleado;
        private System.Windows.Forms.TextBox buscar_TXT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStripMenuItem atrasToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}