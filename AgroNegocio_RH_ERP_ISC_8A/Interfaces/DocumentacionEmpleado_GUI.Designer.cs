namespace AgroNegocio_RH_ERP_ISC_8A.Interfaces
{
    partial class DocumentacionEmpleado_GUI
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DocumentacionEmpleado_GUI));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.eliminar = new System.Windows.Forms.Button();
            this.editar = new System.Windows.Forms.Button();
            this.agregar = new System.Windows.Forms.Button();
            this.tablaDocumentacionEmpleado = new System.Windows.Forms.DataGridView();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.nombreEmpleado = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.idDocEmpleado = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nombreDocumento = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnVer = new System.Windows.Forms.Button();
            this.abrir = new System.Windows.Forms.Button();
            this.btnCancelarDoc = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaDocumentacionEmpleado)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.AliceBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(512, 54);
            this.panel1.TabIndex = 46;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(85, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(358, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Documentos del empleado";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(7, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(37, 42);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // eliminar
            // 
            this.eliminar.Location = new System.Drawing.Point(407, 168);
            this.eliminar.Name = "eliminar";
            this.eliminar.Size = new System.Drawing.Size(75, 23);
            this.eliminar.TabIndex = 56;
            this.eliminar.Text = "Eliminar";
            this.toolTip1.SetToolTip(this.eliminar, "Elimina un documento");
            this.eliminar.UseVisualStyleBackColor = true;
            this.eliminar.Click += new System.EventHandler(this.eliminar_Click);
            // 
            // editar
            // 
            this.editar.Location = new System.Drawing.Point(407, 139);
            this.editar.Name = "editar";
            this.editar.Size = new System.Drawing.Size(75, 23);
            this.editar.TabIndex = 55;
            this.editar.Text = "Editar";
            this.toolTip1.SetToolTip(this.editar, "Edita un documento de la lista");
            this.editar.UseVisualStyleBackColor = true;
            this.editar.Click += new System.EventHandler(this.editar_Click);
            // 
            // agregar
            // 
            this.agregar.Location = new System.Drawing.Point(407, 109);
            this.agregar.Name = "agregar";
            this.agregar.Size = new System.Drawing.Size(75, 23);
            this.agregar.TabIndex = 53;
            this.agregar.Text = "Agregar";
            this.toolTip1.SetToolTip(this.agregar, "Agrega un nuevo documento");
            this.agregar.UseVisualStyleBackColor = true;
            this.agregar.Click += new System.EventHandler(this.agregar_Click);
            // 
            // tablaDocumentacionEmpleado
            // 
            this.tablaDocumentacionEmpleado.AllowUserToAddRows = false;
            this.tablaDocumentacionEmpleado.AllowUserToDeleteRows = false;
            this.tablaDocumentacionEmpleado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaDocumentacionEmpleado.Location = new System.Drawing.Point(34, 197);
            this.tablaDocumentacionEmpleado.MultiSelect = false;
            this.tablaDocumentacionEmpleado.Name = "tablaDocumentacionEmpleado";
            this.tablaDocumentacionEmpleado.ReadOnly = true;
            this.tablaDocumentacionEmpleado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tablaDocumentacionEmpleado.Size = new System.Drawing.Size(448, 182);
            this.tablaDocumentacionEmpleado.TabIndex = 60;
            this.toolTip1.SetToolTip(this.tablaDocumentacionEmpleado, "Pulsa doble clic para editar");
            this.tablaDocumentacionEmpleado.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablaDocumentacionEmpleado_CellClick);
            this.tablaDocumentacionEmpleado.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablaDocumentacionEmpleado_CellDoubleClick);
            this.tablaDocumentacionEmpleado.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.tablaDocumentacionEmpleado_DataBindingComplete);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.BackColor = System.Drawing.Color.Firebrick;
            this.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelar.ForeColor = System.Drawing.Color.White;
            this.btn_cancelar.Location = new System.Drawing.Point(388, 385);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(94, 31);
            this.btn_cancelar.TabIndex = 62;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = false;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_guardar
            // 
            this.btn_guardar.BackColor = System.Drawing.Color.LimeGreen;
            this.btn_guardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_guardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_guardar.ForeColor = System.Drawing.Color.White;
            this.btn_guardar.Location = new System.Drawing.Point(34, 385);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(94, 31);
            this.btn_guardar.TabIndex = 61;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = false;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.nombreEmpleado);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.idDocEmpleado);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(3, 64);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(512, 27);
            this.panel2.TabIndex = 64;
            // 
            // nombreEmpleado
            // 
            this.nombreEmpleado.Location = new System.Drawing.Point(301, 3);
            this.nombreEmpleado.Name = "nombreEmpleado";
            this.nombreEmpleado.ReadOnly = true;
            this.nombreEmpleado.Size = new System.Drawing.Size(142, 20);
            this.nombreEmpleado.TabIndex = 61;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(248, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 60;
            this.label4.Text = "Nombre";
            // 
            // idDocEmpleado
            // 
            this.idDocEmpleado.Location = new System.Drawing.Point(90, 3);
            this.idDocEmpleado.Name = "idDocEmpleado";
            this.idDocEmpleado.ReadOnly = true;
            this.idDocEmpleado.Size = new System.Drawing.Size(65, 20);
            this.idDocEmpleado.TabIndex = 59;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 58;
            this.label2.Text = "ID";
            // 
            // nombreDocumento
            // 
            this.nombreDocumento.Location = new System.Drawing.Point(34, 161);
            this.nombreDocumento.Name = "nombreDocumento";
            this.nombreDocumento.Size = new System.Drawing.Size(318, 20);
            this.nombreDocumento.TabIndex = 66;
            this.nombreDocumento.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 13);
            this.label3.TabIndex = 65;
            this.label3.Text = "Nombre del documento:";
            this.label3.Visible = false;
            // 
            // btnVer
            // 
            this.btnVer.Enabled = false;
            this.btnVer.Location = new System.Drawing.Point(134, 109);
            this.btnVer.Name = "btnVer";
            this.btnVer.Size = new System.Drawing.Size(75, 23);
            this.btnVer.TabIndex = 67;
            this.btnVer.Text = "Ver";
            this.toolTip1.SetToolTip(this.btnVer, "Ver documento seleccionado");
            this.btnVer.UseVisualStyleBackColor = true;
            this.btnVer.Visible = false;
            this.btnVer.Click += new System.EventHandler(this.button1_Click);
            // 
            // abrir
            // 
            this.abrir.Location = new System.Drawing.Point(34, 109);
            this.abrir.Name = "abrir";
            this.abrir.Size = new System.Drawing.Size(75, 23);
            this.abrir.TabIndex = 68;
            this.abrir.Text = "Abrir";
            this.toolTip1.SetToolTip(this.abrir, "Abre un documento local");
            this.abrir.UseVisualStyleBackColor = true;
            this.abrir.Visible = false;
            this.abrir.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnCancelarDoc
            // 
            this.btnCancelarDoc.Location = new System.Drawing.Point(277, 109);
            this.btnCancelarDoc.Name = "btnCancelarDoc";
            this.btnCancelarDoc.Size = new System.Drawing.Size(75, 23);
            this.btnCancelarDoc.TabIndex = 69;
            this.btnCancelarDoc.Text = "Cancelar";
            this.toolTip1.SetToolTip(this.btnCancelarDoc, "Cancelar documento actual");
            this.btnCancelarDoc.UseVisualStyleBackColor = true;
            this.btnCancelarDoc.Visible = false;
            this.btnCancelarDoc.Click += new System.EventHandler(this.btnCancelarDoc_Click);
            // 
            // DocumentacionEmpleado_GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 435);
            this.Controls.Add(this.btnCancelarDoc);
            this.Controls.Add(this.abrir);
            this.Controls.Add(this.btnVer);
            this.Controls.Add(this.nombreDocumento);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.tablaDocumentacionEmpleado);
            this.Controls.Add(this.eliminar);
            this.Controls.Add(this.editar);
            this.Controls.Add(this.agregar);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DocumentacionEmpleado_GUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Documentos del empleado";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DocumentacionEmpleado_GUI_FormClosing);
            this.Load += new System.EventHandler(this.DocumentacionEmpleado_GUI_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaDocumentacionEmpleado)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button eliminar;
        private System.Windows.Forms.Button editar;
        private System.Windows.Forms.Button agregar;
        private System.Windows.Forms.DataGridView tablaDocumentacionEmpleado;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox nombreEmpleado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox idDocEmpleado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nombreDocumento;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnVer;
        private System.Windows.Forms.Button abrir;
        private System.Windows.Forms.Button btnCancelarDoc;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}