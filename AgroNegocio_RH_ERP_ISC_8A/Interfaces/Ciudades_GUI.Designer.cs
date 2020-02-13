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
            this.id_ciudad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre_ciudad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.editar_ciudad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eliminar_ciudad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.tablaCiudad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tablaCiudad
            // 
            this.tablaCiudad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaCiudad.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_ciudad,
            this.nombre_ciudad,
            this.estado,
            this.estatus,
            this.editar_ciudad,
            this.eliminar_ciudad});
            this.tablaCiudad.Location = new System.Drawing.Point(38, 119);
            this.tablaCiudad.Name = "tablaCiudad";
            this.tablaCiudad.Size = new System.Drawing.Size(596, 87);
            this.tablaCiudad.TabIndex = 0;
            this.tablaCiudad.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablaCiudad_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(61, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ciudades";
            // 
            // id_ciudad
            // 
            this.id_ciudad.HeaderText = "ID";
            this.id_ciudad.Name = "id_ciudad";
            this.id_ciudad.ReadOnly = true;
            this.id_ciudad.Width = 50;
            // 
            // nombre_ciudad
            // 
            this.nombre_ciudad.HeaderText = "Nombre";
            this.nombre_ciudad.Name = "nombre_ciudad";
            // 
            // estado
            // 
            this.estado.HeaderText = "Estado";
            this.estado.Name = "estado";
            // 
            // estatus
            // 
            this.estatus.HeaderText = "Estatus";
            this.estatus.Name = "estatus";
            // 
            // editar_ciudad
            // 
            this.editar_ciudad.HeaderText = "Editar";
            this.editar_ciudad.Name = "editar_ciudad";
            // 
            // eliminar_ciudad
            // 
            this.eliminar_ciudad.HeaderText = "Eliminar";
            this.eliminar_ciudad.Name = "eliminar_ciudad";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(2, 41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 42);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Ciudades_GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 439);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tablaCiudad);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Ciudades_GUI";
            this.Text = "Ciudades";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablaCiudad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tablaCiudad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_ciudad;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_ciudad;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn estatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn editar_ciudad;
        private System.Windows.Forms.DataGridViewTextBoxColumn eliminar_ciudad;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}