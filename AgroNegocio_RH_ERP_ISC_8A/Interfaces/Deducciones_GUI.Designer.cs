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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.IniciotoolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID_Percepciones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre_Percepcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion_Percepcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dias_Pagar_Percepcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.editar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.IniciotoolStripMenuItem1,
            this.backToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(727, 24);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // IniciotoolStripMenuItem1
            // 
            this.IniciotoolStripMenuItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.IniciotoolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("IniciotoolStripMenuItem1.Image")));
            this.IniciotoolStripMenuItem1.Name = "IniciotoolStripMenuItem1";
            this.IniciotoolStripMenuItem1.Size = new System.Drawing.Size(28, 20);
            this.IniciotoolStripMenuItem1.Text = "Inicio";
            // 
            // backToolStripMenuItem
            // 
            this.backToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.backToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("backToolStripMenuItem.Image")));
            this.backToolStripMenuItem.Name = "backToolStripMenuItem";
            this.backToolStripMenuItem.Size = new System.Drawing.Size(28, 20);
            this.backToolStripMenuItem.Text = "Back";
            // 
            // btn_buscar
            // 
            this.btn_buscar.Image = ((System.Drawing.Image)(resources.GetObject("btn_buscar.Image")));
            this.btn_buscar.Location = new System.Drawing.Point(584, 110);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(33, 26);
            this.btn_buscar.TabIndex = 18;
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox1.Location = new System.Drawing.Point(382, 109);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(196, 26);
            this.textBox1.TabIndex = 17;
            this.textBox1.Text = "Buscar deducción";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_Percepciones,
            this.Nombre_Percepcion,
            this.Descripcion_Percepcion,
            this.Dias_Pagar_Percepcion,
            this.editar,
            this.Eliminar});
            this.dataGridView1.Location = new System.Drawing.Point(38, 166);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(643, 136);
            this.dataGridView1.TabIndex = 16;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            // 
            // Descripcion_Percepcion
            // 
            this.Descripcion_Percepcion.HeaderText = "Descripción";
            this.Descripcion_Percepcion.Name = "Descripcion_Percepcion";
            this.Descripcion_Percepcion.ReadOnly = true;
            this.Descripcion_Percepcion.Width = 150;
            // 
            // Dias_Pagar_Percepcion
            // 
            this.Dias_Pagar_Percepcion.HeaderText = "Días a pagar";
            this.Dias_Pagar_Percepcion.Name = "Dias_Pagar_Percepcion";
            // 
            // editar
            // 
            this.editar.HeaderText = "Editar";
            this.editar.Name = "editar";
            this.editar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(148, 63);
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
            // Deducciones_GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 387);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Deducciones_GUI";
            this.Text = "Deducciones";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem IniciotoolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Percepciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre_Percepcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion_Percepcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dias_Pagar_Percepcion;
        private System.Windows.Forms.DataGridViewButtonColumn editar;
        private System.Windows.Forms.DataGridViewButtonColumn Eliminar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}