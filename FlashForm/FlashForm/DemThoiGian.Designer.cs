﻿namespace FlashForm
{
    partial class DemThoiGian
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
            this.btnDem = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btnDem
            // 
            this.btnDem.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDem.Location = new System.Drawing.Point(210, 99);
            this.btnDem.Name = "btnDem";
            this.btnDem.Size = new System.Drawing.Size(169, 77);
            this.btnDem.TabIndex = 0;
            this.btnDem.Text = "Đếm";
            this.btnDem.UseVisualStyleBackColor = true;
            this.btnDem.Click += new System.EventHandler(this.btnDem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(236, 214);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 45);
            this.label1.TabIndex = 1;
            this.label1.Text = "00:00";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // DemThoiGian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 377);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDem);
            this.Name = "DemThoiGian";
            this.Text = "DemThoiGian";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
    }
}