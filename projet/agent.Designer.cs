﻿
namespace projet
{
    partial class agent
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
            this.saisirb = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // saisirb
            // 
            this.saisirb.Location = new System.Drawing.Point(29, 70);
            this.saisirb.Name = "saisirb";
            this.saisirb.Size = new System.Drawing.Size(139, 53);
            this.saisirb.TabIndex = 0;
            this.saisirb.Text = "saisir un bulletin ";
            this.saisirb.UseVisualStyleBackColor = true;
            // 
            // agent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.saisirb);
            this.Name = "agent";
            this.Text = "Form4";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button saisirb;
    }
}