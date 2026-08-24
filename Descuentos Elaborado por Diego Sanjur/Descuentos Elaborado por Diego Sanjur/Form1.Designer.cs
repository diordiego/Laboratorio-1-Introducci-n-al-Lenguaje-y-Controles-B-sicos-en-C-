namespace Descuentos_Elaborado_por_Diego_Sanjur
{
    partial class Form1
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
            this.lblValorVenta = new System.Windows.Forms.Label();
            this.lblDescuentoDin = new System.Windows.Forms.Label();
            this.lblDescuentoPorc = new System.Windows.Forms.Label();
            this.lblVentaFinal = new System.Windows.Forms.Label();
            this.txtValorVentas = new System.Windows.Forms.TextBox();
            this.txtDescuentoPorc = new System.Windows.Forms.TextBox();
            this.txtVentaFinal = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.txtDescuentoDin = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblValorVenta
            // 
            this.lblValorVenta.AutoSize = true;
            this.lblValorVenta.Location = new System.Drawing.Point(48, 38);
            this.lblValorVenta.Name = "lblValorVenta";
            this.lblValorVenta.Size = new System.Drawing.Size(84, 16);
            this.lblValorVenta.TabIndex = 0;
            this.lblValorVenta.Text = "Valor Ventas";
            // 
            // lblDescuentoDin
            // 
            this.lblDescuentoDin.AutoSize = true;
            this.lblDescuentoDin.Location = new System.Drawing.Point(48, 102);
            this.lblDescuentoDin.Name = "lblDescuentoDin";
            this.lblDescuentoDin.Size = new System.Drawing.Size(82, 16);
            this.lblDescuentoDin.TabIndex = 1;
            this.lblDescuentoDin.Text = "Descuento $";
            // 
            // lblDescuentoPorc
            // 
            this.lblDescuentoPorc.AutoSize = true;
            this.lblDescuentoPorc.Location = new System.Drawing.Point(48, 147);
            this.lblDescuentoPorc.Name = "lblDescuentoPorc";
            this.lblDescuentoPorc.Size = new System.Drawing.Size(87, 16);
            this.lblDescuentoPorc.TabIndex = 2;
            this.lblDescuentoPorc.Text = "Descuento %";
            // 
            // lblVentaFinal
            // 
            this.lblVentaFinal.AutoSize = true;
            this.lblVentaFinal.Location = new System.Drawing.Point(48, 197);
            this.lblVentaFinal.Name = "lblVentaFinal";
            this.lblVentaFinal.Size = new System.Drawing.Size(74, 16);
            this.lblVentaFinal.TabIndex = 3;
            this.lblVentaFinal.Text = "Venta Final";
            // 
            // txtValorVentas
            // 
            this.txtValorVentas.Location = new System.Drawing.Point(170, 38);
            this.txtValorVentas.Name = "txtValorVentas";
            this.txtValorVentas.Size = new System.Drawing.Size(100, 22);
            this.txtValorVentas.TabIndex = 4;
            // 
            // txtDescuentoPorc
            // 
            this.txtDescuentoPorc.Location = new System.Drawing.Point(170, 147);
            this.txtDescuentoPorc.Name = "txtDescuentoPorc";
            this.txtDescuentoPorc.ReadOnly = true;
            this.txtDescuentoPorc.Size = new System.Drawing.Size(100, 22);
            this.txtDescuentoPorc.TabIndex = 6;
            // 
            // txtVentaFinal
            // 
            this.txtVentaFinal.Location = new System.Drawing.Point(170, 197);
            this.txtVentaFinal.Name = "txtVentaFinal";
            this.txtVentaFinal.ReadOnly = true;
            this.txtVentaFinal.Size = new System.Drawing.Size(100, 22);
            this.txtVentaFinal.TabIndex = 7;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(434, 38);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 8;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(434, 67);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 9;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(434, 147);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 10;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // txtDescuentoDin
            // 
            this.txtDescuentoDin.Location = new System.Drawing.Point(170, 96);
            this.txtDescuentoDin.Name = "txtDescuentoDin";
            this.txtDescuentoDin.ReadOnly = true;
            this.txtDescuentoDin.Size = new System.Drawing.Size(100, 22);
            this.txtDescuentoDin.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 297);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtVentaFinal);
            this.Controls.Add(this.txtDescuentoPorc);
            this.Controls.Add(this.txtDescuentoDin);
            this.Controls.Add(this.txtValorVentas);
            this.Controls.Add(this.lblVentaFinal);
            this.Controls.Add(this.lblDescuentoPorc);
            this.Controls.Add(this.lblDescuentoDin);
            this.Controls.Add(this.lblValorVenta);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblValorVenta;
        private System.Windows.Forms.Label lblDescuentoDin;
        private System.Windows.Forms.Label lblDescuentoPorc;
        private System.Windows.Forms.Label lblVentaFinal;
        private System.Windows.Forms.TextBox txtValorVentas;
        private System.Windows.Forms.TextBox txtDescuentoPorc;
        private System.Windows.Forms.TextBox txtVentaFinal;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.TextBox txtDescuentoDin;
    }
}

