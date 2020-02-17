using System;

namespace AgroNegocio_RH_ERP_ISC_8A.Interfaces
{
    partial class Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.uBICACIONToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eSTADOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cIUDADESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dETToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dECUCCIONESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pERCEPCIONESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uBICACIONToolStripMenuItem,
            this.dETToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(715, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // uBICACIONToolStripMenuItem
            // 
            this.uBICACIONToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eSTADOSToolStripMenuItem,
            this.cIUDADESToolStripMenuItem});
            this.uBICACIONToolStripMenuItem.Name = "uBICACIONToolStripMenuItem";
            this.uBICACIONToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.uBICACIONToolStripMenuItem.Text = "UBICACION";
            // 
            // eSTADOSToolStripMenuItem
            // 
            this.eSTADOSToolStripMenuItem.Name = "eSTADOSToolStripMenuItem";
            this.eSTADOSToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.eSTADOSToolStripMenuItem.Text = "ESTADOS";
            this.eSTADOSToolStripMenuItem.Click += new System.EventHandler(this.eSTADOSToolStripMenuItem_Click);
            // 
            // cIUDADESToolStripMenuItem
            // 
            this.cIUDADESToolStripMenuItem.Name = "cIUDADESToolStripMenuItem";
            this.cIUDADESToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.cIUDADESToolStripMenuItem.Text = "CIUDADES";
            this.cIUDADESToolStripMenuItem.Click += new System.EventHandler(this.cIUDADESToolStripMenuItem_Click);
            // 
            // dETToolStripMenuItem
            // 
            this.dETToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dECUCCIONESToolStripMenuItem,
            this.pERCEPCIONESToolStripMenuItem});
            this.dETToolStripMenuItem.Name = "dETToolStripMenuItem";
            this.dETToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.dETToolStripMenuItem.Text = "NOMINA";
            // 
            // dECUCCIONESToolStripMenuItem
            // 
            this.dECUCCIONESToolStripMenuItem.Name = "dECUCCIONESToolStripMenuItem";
            this.dECUCCIONESToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.dECUCCIONESToolStripMenuItem.Text = "DECUCCIONES";
            // 
            // pERCEPCIONESToolStripMenuItem
            // 
            this.pERCEPCIONESToolStripMenuItem.Name = "pERCEPCIONESToolStripMenuItem";
            this.pERCEPCIONESToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.pERCEPCIONESToolStripMenuItem.Text = "PERCEPCIONES";
            this.pERCEPCIONESToolStripMenuItem.Click += new System.EventHandler(this.pERCEPCIONESToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 368);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "fecha";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(632, 368);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "hora";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AgroNegocio_RH_ERP_ISC_8A.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(37, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(601, 303);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(715, 408);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Principal";
            this.Text = "Principal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void cIUDADESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ciudades_GUI ciudades = new Ciudades_GUI();
            this.SetVisibleCore(false);
            ciudades.ShowDialog();
            this.SetVisibleCore(true);
        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem uBICACIONToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eSTADOSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cIUDADESToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dETToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dECUCCIONESToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pERCEPCIONESToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}