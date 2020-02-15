namespace AgroNegocio_RH_ERP_ISC_8A.Interfaces
{
    partial class Ciudades_GUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ciudades_GUI));
            this.tablaCiudad = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buscar_ciudad = new System.Windows.Forms.TextBox();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.id_ciudad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre_ciudad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarCiudadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.editarCiudadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.tablaCiudad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tablaCiudad
            // 
            this.tablaCiudad.AllowUserToAddRows = false;
            this.tablaCiudad.AllowUserToDeleteRows = false;
            this.tablaCiudad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaCiudad.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_ciudad,
            this.nombre_ciudad,
            this.estado,
            this.estatus});
            this.tablaCiudad.Location = new System.Drawing.Point(38, 159);
            this.tablaCiudad.MultiSelect = false;
            this.tablaCiudad.Name = "tablaCiudad";
            this.tablaCiudad.ReadOnly = true;
            this.tablaCiudad.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tablaCiudad.Size = new System.Drawing.Size(596, 87);
            this.tablaCiudad.TabIndex = 0;
            this.tablaCiudad.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablaCiudad_CellDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(61, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ciudades";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(20, 41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(39, 42);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // buscar_ciudad
            // 
            this.buscar_ciudad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buscar_ciudad.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.buscar_ciudad.Location = new System.Drawing.Point(399, 60);
            this.buscar_ciudad.Name = "buscar_ciudad";
            this.buscar_ciudad.Size = new System.Drawing.Size(196, 26);
            this.buscar_ciudad.TabIndex = 5;
            // 
            // btn_buscar
            // 
            this.btn_buscar.Image = ((System.Drawing.Image)(resources.GetObject("btn_buscar.Image")));
            this.btn_buscar.Location = new System.Drawing.Point(601, 60);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(33, 26);
            this.btn_buscar.TabIndex = 6;
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // id_ciudad
            // 
            this.id_ciudad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.id_ciudad.HeaderText = "ID";
            this.id_ciudad.Name = "id_ciudad";
            this.id_ciudad.ReadOnly = true;
            // 
            // nombre_ciudad
            // 
            this.nombre_ciudad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nombre_ciudad.HeaderText = "Nombre";
            this.nombre_ciudad.Name = "nombre_ciudad";
            // 
            // estado
            // 
            this.estado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.estado.HeaderText = "Estado";
            this.estado.Name = "estado";
            // 
            // estatus
            // 
            this.estatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.estatus.HeaderText = "Estatus";
            this.estatus.Name = "estatus";
            // 
            // inicioToolStripMenuItem
            // 
            this.inicioToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("inicioToolStripMenuItem.Image")));
            this.inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            this.inicioToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.inicioToolStripMenuItem.Text = "Inicio";
            this.inicioToolStripMenuItem.Click += new System.EventHandler(this.inicioToolStripMenuItem_Click);
            // 
            // agregarCiudadToolStripMenuItem
            // 
            this.agregarCiudadToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("agregarCiudadToolStripMenuItem.Image")));
            this.agregarCiudadToolStripMenuItem.Name = "agregarCiudadToolStripMenuItem";
            this.agregarCiudadToolStripMenuItem.Size = new System.Drawing.Size(118, 20);
            this.agregarCiudadToolStripMenuItem.Text = "Agregar Ciudad";
            this.agregarCiudadToolStripMenuItem.Click += new System.EventHandler(this.agregarCiudadToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inicioToolStripMenuItem,
            this.agregarCiudadToolStripMenuItem,
            this.editarCiudadToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(670, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // editarCiudadToolStripMenuItem
            // 
            this.editarCiudadToolStripMenuItem.Name = "editarCiudadToolStripMenuItem";
            this.editarCiudadToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.editarCiudadToolStripMenuItem.Text = "Editar Ciudad";
            this.editarCiudadToolStripMenuItem.Click += new System.EventHandler(this.editarCiudadToolStripMenuItem_Click);
            // 
            // Ciudades_GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 439);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.buscar_ciudad);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tablaCiudad);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Ciudades_GUI";
            this.Text = "Ciudades";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablaCiudad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tablaCiudad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox buscar_ciudad;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_ciudad;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_ciudad;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn estatus;
        private System.Windows.Forms.ToolStripMenuItem inicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarCiudadToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editarCiudadToolStripMenuItem;
    }
}