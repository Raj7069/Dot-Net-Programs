using System;
using System.Drawing;

namespace IncreaseDecreaseFont
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
            this.lblFont = new System.Windows.Forms.Label();
            this.btnIncrease = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDecrease = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblFont
            // 
            this.lblFont.AutoSize = true;
            this.lblFont.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFont.Location = new System.Drawing.Point(12, 68);
            this.lblFont.Name = "lblFont";
            this.lblFont.Size = new System.Drawing.Size(458, 63);
            this.lblFont.TabIndex = 0;
            this.lblFont.Text = "Change Font Size";
            // 
            // btnIncrease
            // 
            this.btnIncrease.Location = new System.Drawing.Point(107, 23);
            this.btnIncrease.Name = "btnIncrease";
            this.btnIncrease.Size = new System.Drawing.Size(100, 23);
            this.btnIncrease.TabIndex = 1;
            this.btnIncrease.Text = "Increase Size";
            this.btnIncrease.UseVisualStyleBackColor = true;
            this.btnIncrease.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "FontSize";
            // 
            // btnDecrease
            // 
            this.btnDecrease.Location = new System.Drawing.Point(239, 23);
            this.btnDecrease.Name = "btnDecrease";
            this.btnDecrease.Size = new System.Drawing.Size(100, 23);
            this.btnDecrease.TabIndex = 1;
            this.btnDecrease.Text = "Decrease Size";
            this.btnDecrease.UseVisualStyleBackColor = true;
            this.btnDecrease.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 223);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDecrease);
            this.Controls.Add(this.btnIncrease);
            this.Controls.Add(this.lblFont);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            float fontSize = lblFont.Font.Size;
            lblFont.Font = new Font(lblFont.Font.FontFamily, ++fontSize);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            float fontSize = lblFont.Font.Size;
            lblFont.Font = new Font(lblFont.Font.FontFamily, --fontSize);
        }

        #endregion

        private System.Windows.Forms.Label lblFont;
        private System.Windows.Forms.Button btnIncrease;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDecrease;
    }
}

