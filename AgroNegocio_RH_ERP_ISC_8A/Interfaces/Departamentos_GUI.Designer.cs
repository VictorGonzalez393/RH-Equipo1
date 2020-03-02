namespace AgroNegocio_RH_ERP_ISC_8A.Interfaces
{
    partial class Departamentos_GUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Departamentos_GUI));
            this.tablaDepartamentos = new System.Windows.Forms.DataGridView();
            this.buscarDepartamentoTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.ID_Depa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre_Depa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estatus_Depa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.inicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.tablaDepartamentos)).BeginInit();
            this.menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tablaDepartamentos
            // 
            this.tablaDepartamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaDepartamentos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_Depa,
            this.Nombre_Depa,
            this.Estatus_Depa});
            this.tablaDepartamentos.Location = new System.Drawing.Point(82, 154);
            this.tablaDepartamentos.Margin = new System.Windows.Forms.Padding(5);
            this.tablaDepartamentos.Name = "tablaDepartamentos";
            this.tablaDepartamentos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tablaDepartamentos.Size = new System.Drawing.Size(398, 235);
            this.tablaDepartamentos.TabIndex = 12;
            // 
            // buscarDepartamentoTxt
            // 
            this.buscarDepartamentoTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buscarDepartamentoTxt.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.buscarDepartamentoTxt.Location = new System.Drawing.Point(221, 96);
            this.buscarDepartamentoTxt.Margin = new System.Windows.Forms.Padding(5);
            this.buscarDepartamentoTxt.Name = "buscarDepartamentoTxt";
            this.buscarDepartamentoTxt.Size = new System.Drawing.Size(259, 26);
            this.buscarDepartamentoTxt.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(76, 49);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 31);
            this.label1.TabIndex = 14;
            this.label1.Text = "Departamentos";
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
            this.menu.Padding = new System.Windows.Forms.Padding(17, 5, 0, 5);
            this.menu.Size = new System.Drawing.Size(556, 31);
            this.menu.TabIndex = 13;
            this.menu.Text = "menuStrip1";
            // 
            // ID_Depa
            // 
            this.ID_Depa.HeaderText = "ID";
            this.ID_Depa.Name = "ID_Depa";
            this.ID_Depa.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ID_Depa.Width = 50;
            // 
            // Nombre_Depa
            // 
            this.Nombre_Depa.HeaderText = "Nombre";
            this.Nombre_Depa.Name = "Nombre_Depa";
            this.Nombre_Depa.Width = 150;
            // 
            // Estatus_Depa
            // 
            this.Estatus_Depa.HeaderText = "Estatus";
            this.Estatus_Depa.Name = "Estatus_Depa";
            this.Estatus_Depa.Width = 80;
            // 
            // btn_buscar
            // 
            this.btn_buscar.Image = ((System.Drawing.Image)(resources.GetObject("btn_buscar.Image")));
            this.btn_buscar.Location = new System.Drawing.Point(480, 93);
            this.btn_buscar.Margin = new System.Windows.Forms.Padding(5);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(45, 31);
            this.btn_buscar.TabIndex = 17;
            this.btn_buscar.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AgroNegocio_RH_ERP_ISC_8A.Properties.Resources.departamento;
            this.pictureBox1.Location = new System.Drawing.Point(8, 36);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(67, 73);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
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
            this.nuevoToolStripMenuItem.Size = new System.Drawing.Size(178, 21);
            this.nuevoToolStripMenuItem.Text = "Agregar Departamento";
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("editarToolStripMenuItem.Image")));
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(165, 21);
            this.editarToolStripMenuItem.Text = "Editar Departamento";
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("eliminarToolStripMenuItem.Image")));
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(87, 21);
            this.eliminarToolStripMenuItem.Text = "Eliminar";
            // 
            // Departamentos_GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 416);
            this.Controls.Add(this.tablaDepartamentos);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.buscarDepartamentoTxt);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Departamentos_GUI";
            this.Text = "Departamentos";
            ((System.ComponentModel.ISupportInitialize)(this.tablaDepartamentos)).EndInit();
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tablaDepartamentos;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.TextBox buscarDepartamentoTxt;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem inicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Depa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre_Depa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estatus_Depa;
    }
}