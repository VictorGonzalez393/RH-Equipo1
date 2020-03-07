namespace AgroNegocio_RH_ERP_ISC_8A.Interfaces
{
    partial class Percepciones_GUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Percepciones_GUI));
            this.menu = new System.Windows.Forms.MenuStrip();
            this.inicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tablaPercepciones = new System.Windows.Forms.DataGridView();
            this.ID_Percepciones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre_Percepcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion_Percepcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dias_Pagar_Percepcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estatus_Per = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buscarPerTxt = new System.Windows.Forms.TextBox();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaPercepciones)).BeginInit();
            this.SuspendLayout();
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
            this.menu.Size = new System.Drawing.Size(673, 27);
            this.menu.TabIndex = 0;
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
            this.nuevoToolStripMenuItem.Size = new System.Drawing.Size(156, 21);
            this.nuevoToolStripMenuItem.Text = "Agregar percepción";
            this.nuevoToolStripMenuItem.Click += new System.EventHandler(this.nuevoToolStripMenuItem_Click_1);
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("editarToolStripMenuItem.Image")));
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(143, 21);
            this.editarToolStripMenuItem.Text = "Editar percepción";
            this.editarToolStripMenuItem.Click += new System.EventHandler(this.editarToolStripMenuItem_Click);
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
            this.label1.Location = new System.Drawing.Point(65, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Percepciones";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(47, 47);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // tablaPercepciones
            // 
            this.tablaPercepciones.AllowUserToAddRows = false;
            this.tablaPercepciones.AllowUserToDeleteRows = false;
            this.tablaPercepciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaPercepciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_Percepciones,
            this.Nombre_Percepcion,
            this.Descripcion_Percepcion,
            this.Dias_Pagar_Percepcion,
            this.Estatus_Per});
            this.tablaPercepciones.Enabled = false;
            this.tablaPercepciones.Location = new System.Drawing.Point(31, 112);
            this.tablaPercepciones.MultiSelect = false;
            this.tablaPercepciones.Name = "tablaPercepciones";
            this.tablaPercepciones.ReadOnly = true;
            this.tablaPercepciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tablaPercepciones.Size = new System.Drawing.Size(594, 228);
            this.tablaPercepciones.TabIndex = 0;
            this.tablaPercepciones.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            // Dias_Pagar_Percepcion
            // 
            this.Dias_Pagar_Percepcion.HeaderText = "Días a pagar";
            this.Dias_Pagar_Percepcion.Name = "Dias_Pagar_Percepcion";
            this.Dias_Pagar_Percepcion.ReadOnly = true;
            // 
            // Estatus_Per
            // 
            this.Estatus_Per.HeaderText = "Estatus";
            this.Estatus_Per.Name = "Estatus_Per";
            this.Estatus_Per.ReadOnly = true;
            this.Estatus_Per.Width = 80;
            // 
            // buscarPerTxt
            // 
            this.buscarPerTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buscarPerTxt.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.buscarPerTxt.Location = new System.Drawing.Point(353, 46);
            this.buscarPerTxt.Name = "buscarPerTxt";
            this.buscarPerTxt.Size = new System.Drawing.Size(196, 26);
            this.buscarPerTxt.TabIndex = 4;
            this.buscarPerTxt.TextChanged += new System.EventHandler(this.buscarPerTxt_TextChanged);
            // 
            // btn_buscar
            // 
            this.btn_buscar.Image = ((System.Drawing.Image)(resources.GetObject("btn_buscar.Image")));
            this.btn_buscar.Location = new System.Drawing.Point(541, 46);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(33, 26);
            this.btn_buscar.TabIndex = 5;
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // Percepciones_GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 451);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.buscarPerTxt);
            this.Controls.Add(this.tablaPercepciones);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Percepciones_GUI";
            this.Text = "Percepciones";
            this.Load += new System.EventHandler(this.Percepciones_GUI_Load);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaPercepciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem inicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView tablaPercepciones;
        private System.Windows.Forms.TextBox buscarPerTxt;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Percepciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre_Percepcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion_Percepcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dias_Pagar_Percepcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estatus_Per;
    }
}