﻿namespace Menu
{
    partial class Listados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Listados));
            this.bVolver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bVolver
            // 
            this.bVolver.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bVolver.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bVolver.Location = new System.Drawing.Point(664, 364);
            this.bVolver.Name = "bVolver";
            this.bVolver.Size = new System.Drawing.Size(108, 35);
            this.bVolver.TabIndex = 1;
            this.bVolver.Text = "Volver";
            this.bVolver.UseVisualStyleBackColor = false;
            this.bVolver.Click += new System.EventHandler(this.bVolver_Click);
            // 
            // Listados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 411);
            this.ControlBox = false;
            this.Controls.Add(this.bVolver);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Listados";
            this.Text = "Menu | Listados";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bVolver;
    }
}