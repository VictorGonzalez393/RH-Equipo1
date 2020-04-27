namespace AgroNegocio_RH_ERP_ISC_8A.Interfaces
{
    partial class Deducciones_GUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Deducciones_GUI));
            this.btn_buscar = new System.Windows.Forms.Button();
            this.buscarDedTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.inicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tablaDeducciones = new System.Windows.Forms.DataGridView();
            this.ID_Percepciones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre_Percepcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion_Percepcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Porcentaje_Deduccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estatus_Per = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaDeducciones)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_buscar
            // 
            this.btn_buscar.Image = ((System.Drawing.Image)(resources.GetObject("btn_buscar.Image")));
            this.btn_buscar.Location = new System.Drawing.Point(573, 89);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(33, 26);
            this.btn_buscar.TabIndex = 18;
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // buscarDedTxt
            // 
            this.buscarDedTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buscarDedTxt.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.buscarDedTxt.Location = new System.Drawing.Point(371, 88);
            this.buscarDedTxt.Name = "buscarDedTxt";
            this.buscarDedTxt.Size = new System.Drawing.Size(196, 26);
            this.buscarDedTxt.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(132, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 31);
            this.label1.TabIndex = 15;
            this.label1.Text = "Deducciones";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(38, 63);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(88, 72);
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.menu.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inicioToolStripMenuItem,
            this.nuevoToolStripMenuItem,
            this.editarToolStripMenuItem,
            this.eliminarToolStripMenuItem});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Padding = new System.Windows.Forms.Padding(10, 3, 0, 3);
            this.menu.Size = new System.Drawing.Size(727, 27);
            this.menu.TabIndex = 20;
            this.menu.Text = "menuStrip1";
            // 
            // inicioToolStripMenuItem
            // 
            this.inicioToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.inicioToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("inicioToolStripMenuItem.Image")));
            this.inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            this.inicioToolStripMenuItem.Size = new System.Drawing.Size(70, 21);
            this.inicioToolStripMenuItem.Text = "Inicio";
            this.inicioToolStripMenuItem.Click += new System.EventHandler(this.inicioToolStripMenuItem_Click);
            // 
            // nuevoToolStripMenuItem
            // 
            this.nuevoToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.nuevoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("nuevoToolStripMenuItem.Image")));
            this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            this.nuevoToolStripMenuItem.Size = new System.Drawing.Size(165, 21);
            this.nuevoToolStripMenuItem.Text = "Agregar deducciones";
            this.nuevoToolStripMenuItem.Click += new System.EventHandler(this.nuevoToolStripMenuItem_Click_2);
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("editarToolStripMenuItem.Image")));
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(152, 21);
            this.editarToolStripMenuItem.Text = "Editar deducciones";
            this.editarToolStripMenuItem.Click += new System.EventHandler(this.editarToolStripMenuItem_Click_1);
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("eliminarToolStripMenuItem.Image")));
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(87, 21);
            this.eliminarToolStripMenuItem.Text = "Eliminar";
            this.eliminarToolStripMenuItem.Click += new System.EventHandler(this.eliminarToolStripMenuItem_Click_1);
            // 
            // tablaDeducciones
            // 
            this.tablaDeducciones.AllowUserToAddRows = false;
            this.tablaDeducciones.AllowUserToDeleteRows = false;
            this.tablaDeducciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaDeducciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_Percepciones,
            this.Nombre_Percepcion,
            this.Descripcion_Percepcion,
            this.Porcentaje_Deduccion,
            this.Estatus_Per});
            this.tablaDeducciones.Enabled = false;
            this.tablaDeducciones.Location = new System.Drawing.Point(62, 150);
            this.tablaDeducciones.MultiSelect = false;
            this.tablaDeducciones.Name = "tablaDeducciones";
            this.tablaDeducciones.ReadOnly = true;
            this.tablaDeducciones.Size = new System.Drawing.Size(594, 228);
            this.tablaDeducciones.TabIndex = 0;
            // 
            // ID_Percepciones
            // 
            this.ID_Percepciones.HeaderText = "ID";
            this.ID_Percepciones.Name = "ID_Percepciones";
            this.ID_Percepciones.ReadOnly = true;
            this.ID_Percepciones.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ID_Percepciones.Width = 50;
            // 
            // Nombre_Percepcion
            // 
            this.Nombre_Percepcion.HeaderText = "Nombre";
            this.Nombre_Percepcion.Name = "Nombre_Percepcion";
            this.Nombre_Percepcion.ReadOnly = true;
            this.Nombre_Percepcion.Width = 150;
            // 
            // Descripcion_Percepcion
            // 
            this.Descripcion_Percepcion.HeaderText = "Descripción";
            this.Descripcion_Percepcion.Name = "Descripcion_Percepcion";
            this.Descripcion_Percepcion.ReadOnly = true;
            this.Descripcion_Percepcion.Width = 170;
            // 
            // Porcentaje_Deduccion
            // 
            this.Porcentaje_Deduccion.HeaderText = "Porcentaje (%)";
            this.Porcentaje_Deduccion.Name = "Porcentaje_Deduccion";
            this.Porcentaje_Deduccion.ReadOnly = true;
            // 
            // Estatus_Per
            // 
            this.Estatus_Per.HeaderText = "Estatus";
            this.Estatus_Per.Name = "Estatus_Per";
            this.Estatus_Per.ReadOnly = true;
            this.Estatus_Per.Width = 80;
            // 
            // Deducciones_GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 401);
            this.Controls.Add(this.tablaDeducciones);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.buscarDedTxt);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Deducciones_GUI";
            this.Text = "Deducciones";
            this.Load += new System.EventHandler(this.Deducciones_GUI_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaDeducciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.TextBox buscarDedTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem inicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private System.Windows.Forms.DataGridView tablaDeducciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Percepciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre_Percepcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion_Percepcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Porcentaje_Deduccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estatus_Per;
    }
}