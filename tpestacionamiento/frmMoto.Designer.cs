namespace tpestacionamiento
{
    partial class frmMoto
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
            this.label4 = new System.Windows.Forms.Label();
            this.txtCilindrada = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cmbColor
            // 
            this.cmbColor.Items.AddRange(new object[] {
            eColores.Rojo,
            eColores.Amarillo,
            eColores.Negro,
            eColores.Azul,
            eColores.Rojo,
            eColores.Amarillo,
            eColores.Negro,
            eColores.Azul,
            eColores.Rojo,
            eColores.Amarillo,
            eColores.Negro,
            eColores.Azul,
            eColores.Rojo,
            eColores.Amarillo,
            eColores.Negro,
            eColores.Azul,
            eColores.Rojo,
            eColores.Amarillo,
            eColores.Negro,
            eColores.Azul,
            eColores.Rojo,
            eColores.Amarillo,
            eColores.Negro,
            eColores.Azul,
            eColores.Rojo,
            eColores.Amarillo,
            eColores.Negro,
            eColores.Azul});
            // 
            // btnAceptar
            // 
            this.btnAceptar.TabIndex = 4;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click_1);
            // 
            // btnCancelar
            // 
            this.btnCancelar.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Cilindrada:";
            // 
            // txtCilindrada
            // 
            this.txtCilindrada.Location = new System.Drawing.Point(37, 210);
            this.txtCilindrada.Name = "txtCilindrada";
            this.txtCilindrada.Size = new System.Drawing.Size(121, 20);
            this.txtCilindrada.TabIndex = 3;
            // 
            // frmMoto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::tpestacionamiento.Properties.Resources.jjjoooojj;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(534, 361);
            this.Controls.Add(this.txtCilindrada);
            this.Controls.Add(this.label4);
            this.DoubleBuffered = true;
            this.Name = "frmMoto";
            this.Text = "frmMoto";
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.txtPatente, 0);
            this.Controls.SetChildIndex(this.txtMarca, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.cmbColor, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.btnAceptar, 0);
            this.Controls.SetChildIndex(this.btnCancelar, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.txtCilindrada, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCilindrada;
    }
}