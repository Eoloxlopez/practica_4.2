﻿namespace Trabajador
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.BBotonCrear = new System.Windows.Forms.Button();
            this.BBotonJubilacion = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.nu1 = new System.Windows.Forms.NumericUpDown();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nu1)).BeginInit();
            this.SuspendLayout();
            // 
            // BBotonCrear
            // 
            this.BBotonCrear.Location = new System.Drawing.Point(430, 37);
            this.BBotonCrear.Name = "BBotonCrear";
            this.BBotonCrear.Size = new System.Drawing.Size(116, 85);
            this.BBotonCrear.TabIndex = 0;
            this.BBotonCrear.Text = "Crear";
            this.BBotonCrear.UseVisualStyleBackColor = true;
            this.BBotonCrear.Click += new System.EventHandler(this.BBotonCrear_Click);
            // 
            // BBotonJubilacion
            // 
            this.BBotonJubilacion.Location = new System.Drawing.Point(318, 197);
            this.BBotonJubilacion.Name = "BBotonJubilacion";
            this.BBotonJubilacion.Size = new System.Drawing.Size(114, 81);
            this.BBotonJubilacion.TabIndex = 1;
            this.BBotonJubilacion.Text = "Jubilacion";
            this.BBotonJubilacion.UseVisualStyleBackColor = true;
            this.BBotonJubilacion.Click += new System.EventHandler(this.BBotonJubilacion_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Edad:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(150, 45);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(135, 20);
            this.textBox1.TabIndex = 4;
            // 
            // nu1
            // 
            this.nu1.Location = new System.Drawing.Point(151, 145);
            this.nu1.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.nu1.Name = "nu1";
            this.nu1.Size = new System.Drawing.Size(127, 20);
            this.nu1.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(151, 89);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(135, 20);
            this.textBox2.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Apellidos:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 325);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nu1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BBotonJubilacion);
            this.Controls.Add(this.BBotonCrear);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nu1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BBotonCrear;
        private System.Windows.Forms.Button BBotonJubilacion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.NumericUpDown nu1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
    }
}

