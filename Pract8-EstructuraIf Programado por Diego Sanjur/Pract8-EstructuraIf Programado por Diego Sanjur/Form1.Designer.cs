namespace Pract8_EstructuraIf_Programado_por_Diego_Sanjur
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txtValorA = new System.Windows.Forms.TextBox();
            this.txtValorB = new System.Windows.Forms.TextBox();
            this.lblSimbolo = new System.Windows.Forms.Label();
            this.lblIgual = new System.Windows.Forms.Label();
            this.grpOperaciones = new System.Windows.Forms.GroupBox();
            this.rbDivision = new System.Windows.Forms.RadioButton();
            this.rbMultiplicacion = new System.Windows.Forms.RadioButton();
            this.rbResta = new System.Windows.Forms.RadioButton();
            this.rbSuma = new System.Windows.Forms.RadioButton();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.grpOperaciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(12, 31);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(269, 16);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Ingresa los valores y selecciona una opción";
            // 
            // txtValorA
            // 
            this.txtValorA.Location = new System.Drawing.Point(15, 72);
            this.txtValorA.Name = "txtValorA";
            this.txtValorA.Size = new System.Drawing.Size(100, 22);
            this.txtValorA.TabIndex = 1;
            // 
            // txtValorB
            // 
            this.txtValorB.Location = new System.Drawing.Point(151, 72);
            this.txtValorB.Name = "txtValorB";
            this.txtValorB.Size = new System.Drawing.Size(100, 22);
            this.txtValorB.TabIndex = 2;
            // 
            // lblSimbolo
            // 
            this.lblSimbolo.AutoSize = true;
            this.lblSimbolo.Location = new System.Drawing.Point(125, 75);
            this.lblSimbolo.Name = "lblSimbolo";
            this.lblSimbolo.Size = new System.Drawing.Size(14, 16);
            this.lblSimbolo.TabIndex = 4;
            this.lblSimbolo.Text = "+";
            // 
            // lblIgual
            // 
            this.lblIgual.AutoSize = true;
            this.lblIgual.Location = new System.Drawing.Point(263, 78);
            this.lblIgual.Name = "lblIgual";
            this.lblIgual.Size = new System.Drawing.Size(14, 16);
            this.lblIgual.TabIndex = 5;
            this.lblIgual.Text = "=";
            // 
            // grpOperaciones
            // 
            this.grpOperaciones.Controls.Add(this.rbDivision);
            this.grpOperaciones.Controls.Add(this.rbMultiplicacion);
            this.grpOperaciones.Controls.Add(this.rbResta);
            this.grpOperaciones.Controls.Add(this.rbSuma);
            this.grpOperaciones.Location = new System.Drawing.Point(15, 127);
            this.grpOperaciones.Name = "grpOperaciones";
            this.grpOperaciones.Size = new System.Drawing.Size(191, 131);
            this.grpOperaciones.TabIndex = 6;
            this.grpOperaciones.TabStop = false;
            this.grpOperaciones.Text = "Operaciones";
            // 
            // rbDivision
            // 
            this.rbDivision.AutoSize = true;
            this.rbDivision.Location = new System.Drawing.Point(7, 100);
            this.rbDivision.Name = "rbDivision";
            this.rbDivision.Size = new System.Drawing.Size(76, 20);
            this.rbDivision.TabIndex = 3;
            this.rbDivision.Text = "División";
            this.rbDivision.UseVisualStyleBackColor = true;
            this.rbDivision.CheckedChanged += new System.EventHandler(this.rbDivision_CheckedChanged);
            // 
            // rbMultiplicacion
            // 
            this.rbMultiplicacion.AutoSize = true;
            this.rbMultiplicacion.Location = new System.Drawing.Point(7, 74);
            this.rbMultiplicacion.Name = "rbMultiplicacion";
            this.rbMultiplicacion.Size = new System.Drawing.Size(109, 20);
            this.rbMultiplicacion.TabIndex = 2;
            this.rbMultiplicacion.Text = "Multiplicación";
            this.rbMultiplicacion.UseVisualStyleBackColor = true;
            this.rbMultiplicacion.CheckedChanged += new System.EventHandler(this.rbMultiplicacion_CheckedChanged);
            // 
            // rbResta
            // 
            this.rbResta.AutoSize = true;
            this.rbResta.Location = new System.Drawing.Point(7, 48);
            this.rbResta.Name = "rbResta";
            this.rbResta.Size = new System.Drawing.Size(64, 20);
            this.rbResta.TabIndex = 1;
            this.rbResta.Text = "Resta";
            this.rbResta.UseVisualStyleBackColor = true;
            this.rbResta.CheckedChanged += new System.EventHandler(this.rbResta_CheckedChanged);
            // 
            // rbSuma
            // 
            this.rbSuma.AutoSize = true;
            this.rbSuma.Checked = true;
            this.rbSuma.Location = new System.Drawing.Point(7, 22);
            this.rbSuma.Name = "rbSuma";
            this.rbSuma.Size = new System.Drawing.Size(63, 20);
            this.rbSuma.TabIndex = 0;
            this.rbSuma.TabStop = true;
            this.rbSuma.Text = "Suma";
            this.rbSuma.UseVisualStyleBackColor = true;
            this.rbSuma.CheckedChanged += new System.EventHandler(this.rbSuma_CheckedChanged);
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(287, 72);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(100, 22);
            this.txtResultado.TabIndex = 7;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(239, 174);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 8;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(239, 213);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 9;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(239, 136);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 10;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 340);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.grpOperaciones);
            this.Controls.Add(this.lblIgual);
            this.Controls.Add(this.lblSimbolo);
            this.Controls.Add(this.txtValorB);
            this.Controls.Add(this.txtValorA);
            this.Controls.Add(this.lblTitulo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grpOperaciones.ResumeLayout(false);
            this.grpOperaciones.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox txtValorA;
        private System.Windows.Forms.TextBox txtValorB;
        private System.Windows.Forms.Label lblSimbolo;
        private System.Windows.Forms.Label lblIgual;
        private System.Windows.Forms.GroupBox grpOperaciones;
        private System.Windows.Forms.RadioButton rbSuma;
        private System.Windows.Forms.RadioButton rbDivision;
        private System.Windows.Forms.RadioButton rbMultiplicacion;
        private System.Windows.Forms.RadioButton rbResta;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnCalcular;
    }
}

