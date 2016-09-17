namespace tpestacionamiento
{
    partial class frmGestionAutomovil
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.nuevosVehiculosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoautoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevamotoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevaCamionetaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.borrarVehiculosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarVehiculosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirDelSistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.AllowMerge = false;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevosVehiculosToolStripMenuItem,
            this.borrarVehiculosToolStripMenuItem,
            this.modificarVehiculosToolStripMenuItem,
            this.salirDelSistemaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(684, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // nuevosVehiculosToolStripMenuItem
            // 
            this.nuevosVehiculosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoautoToolStripMenuItem,
            this.nuevamotoToolStripMenuItem,
            this.nuevaCamionetaToolStripMenuItem});
            this.nuevosVehiculosToolStripMenuItem.Name = "nuevosVehiculosToolStripMenuItem";
            this.nuevosVehiculosToolStripMenuItem.Size = new System.Drawing.Size(112, 20);
            this.nuevosVehiculosToolStripMenuItem.Text = "&Nuevos vehiculos";
            // 
            // nuevoautoToolStripMenuItem
            // 
            this.nuevoautoToolStripMenuItem.Name = "nuevoautoToolStripMenuItem";
            this.nuevoautoToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.nuevoautoToolStripMenuItem.Text = "Nuevo &auto";
            this.nuevoautoToolStripMenuItem.Click += new System.EventHandler(this.nuevoautoToolStripMenuItem_Click);
            // 
            // nuevamotoToolStripMenuItem
            // 
            this.nuevamotoToolStripMenuItem.Name = "nuevamotoToolStripMenuItem";
            this.nuevamotoToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.nuevamotoToolStripMenuItem.Text = "Nueva &moto";
            this.nuevamotoToolStripMenuItem.Click += new System.EventHandler(this.nuevamotoToolStripMenuItem_Click);
            // 
            // nuevaCamionetaToolStripMenuItem
            // 
            this.nuevaCamionetaToolStripMenuItem.Name = "nuevaCamionetaToolStripMenuItem";
            this.nuevaCamionetaToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.nuevaCamionetaToolStripMenuItem.Text = "Nueva &Camioneta";
            // 
            // borrarVehiculosToolStripMenuItem
            // 
            this.borrarVehiculosToolStripMenuItem.Name = "borrarVehiculosToolStripMenuItem";
            this.borrarVehiculosToolStripMenuItem.Size = new System.Drawing.Size(104, 20);
            this.borrarVehiculosToolStripMenuItem.Text = "&Borrar vehiculos";
            // 
            // modificarVehiculosToolStripMenuItem
            // 
            this.modificarVehiculosToolStripMenuItem.Name = "modificarVehiculosToolStripMenuItem";
            this.modificarVehiculosToolStripMenuItem.Size = new System.Drawing.Size(123, 20);
            this.modificarVehiculosToolStripMenuItem.Text = "&Modificar vehiculos";
            // 
            // salirDelSistemaToolStripMenuItem
            // 
            this.salirDelSistemaToolStripMenuItem.Name = "salirDelSistemaToolStripMenuItem";
            this.salirDelSistemaToolStripMenuItem.Size = new System.Drawing.Size(156, 20);
            this.salirDelSistemaToolStripMenuItem.Text = "&Salir de adm. de vehiculos";
            this.salirDelSistemaToolStripMenuItem.Click += new System.EventHandler(this.salirDelSistemaToolStripMenuItem_Click);
            // 
            // frmGestionAutomovil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 461);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmGestionAutomovil";
            this.Text = "frmGestionAutomovil";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmGestionAutomovil_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem nuevosVehiculosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoautoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevamotoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevaCamionetaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem borrarVehiculosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarVehiculosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirDelSistemaToolStripMenuItem;
    }
}