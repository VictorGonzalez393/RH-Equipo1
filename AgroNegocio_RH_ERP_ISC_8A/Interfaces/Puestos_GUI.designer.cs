namespace AgroNegocio_RH_ERP_ISC_8A.Interfaces
{
    partial class Puestos_GUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Puestos_GUI));
            this.menu = new System.Windows.Forms.MenuStrip();
            this.inicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.buscarPerTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tablaPuestos = new System.Windows.Forms.DataGridView();
            this.ID_Puestos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre_Puestos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SalarioMinimo_Puestos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SalarioMaximo_Puestos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado_Puestos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaPuestos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.menu.Size = new System.Drawing.Size(640, 27);
            this.menu.TabIndex = 1;
            this.menu.Text = "menuStrip1";
            // 
            // inicioToolStripMenuItem
            // 
            this.inicioToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.inicioToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("inicioToolStripMenuItem.Image")));
            this.inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            this.inicioToolStripMenuItem.Size = new System.Drawing.Size(70, 21);
            this.inicioToolStripMenuItem.Text = "Inicio";
            // 
            // nuevoToolStripMenuItem
            // 
            this.nuevoToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.nuevoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("nuevoToolStripMenuItem.Image")));
            this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            this.nuevoToolStripMenuItem.Size = new System.Drawing.Size(156, 21);
            this.nuevoToolStripMenuItem.Text = "Agregar percepción";
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("editarToolStripMenuItem.Image")));
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(143, 21);
            this.editarToolStripMenuItem.Text = "Editar percepción";
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("eliminarToolStripMenuItem.Image")));
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(87, 21);
            this.eliminarToolStripMenuItem.Text = "Eliminar";
            // 
            // btn_buscar
            // 
            this.btn_buscar.Image = ((System.Drawing.Image)(resources.GetObject("btn_buscar.Image")));
            this.btn_buscar.Location = new System.Drawing.Point(534, 55);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(33, 26);
            this.btn_buscar.TabIndex = 8;
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // buscarPerTxt
            // 
            this.buscarPerTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buscarPerTxt.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.buscarPerTxt.Location = new System.Drawing.Point(332, 55);
            this.buscarPerTxt.Name = "buscarPerTxt";
            this.buscarPerTxt.Size = new System.Drawing.Size(196, 26);
            this.buscarPerTxt.TabIndex = 7;
            this.buscarPerTxt.TextChanged += new System.EventHandler(this.buscarPerTxt_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(108, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 31);
            this.label1.TabIndex = 6;
            this.label1.Text = "Puestos";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tablaPuestos
            // 
            this.tablaPuestos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaPuestos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_Puestos,
            this.Nombre_Puestos,
            this.SalarioMinimo_Puestos,
            this.SalarioMaximo_Puestos,
            this.Estado_Puestos});
            this.tablaPuestos.Location = new System.Drawing.Point(48, 116);
            this.tablaPuestos.Name = "tablaPuestos";
            this.tablaPuestos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tablaPuestos.Size = new System.Drawing.Size(544, 257);
            this.tablaPuestos.TabIndex = 9;
            // 
            // ID_Puestos
            // 
            this.ID_Puestos.HeaderText = "ID";
            this.ID_Puestos.Name = "ID_Puestos";
            this.ID_Puestos.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ID_Puestos.Width = 50;
            // 
            // Nombre_Puestos
            // 
            this.Nombre_Puestos.HeaderText = "Nombre";
            this.Nombre_Puestos.Name = "Nombre_Puestos";
            this.Nombre_Puestos.Width = 150;
            // 
            // SalarioMinimo_Puestos
            // 
            this.SalarioMinimo_Puestos.HeaderText = "SalarioMinimo";
            this.SalarioMinimo_Puestos.Name = "SalarioMinimo_Puestos";
            // 
            // SalarioMaximo_Puestos
            // 
            this.SalarioMaximo_Puestos.HeaderText = "SalarioMaximo";
            this.SalarioMaximo_Puestos.Name = "SalarioMaximo_Puestos";
            // 
            // Estado_Puestos
            // 
            this.Estado_Puestos.HeaderText = "Estado";
            this.Estado_Puestos.Name = "Estado_Puestos";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(40, 50);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(52, 50);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // Puestos_GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 410);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tablaPuestos);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.buscarPerTxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Puestos_GUI";
            this.Text = "Puestos";
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaPuestos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem inicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.TextBox buscarPerTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView tablaPuestos;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Puestos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre_Puestos;
        private System.Windows.Forms.DataGridViewTextBoxColumn SalarioMinimo_Puestos;
        private System.Windows.Forms.DataGridViewTextBoxColumn SalarioMaximo_Puestos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado_Puestos;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}