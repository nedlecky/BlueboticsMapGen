﻿namespace BlueboticsMapGen
{
    partial class MainForm
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
            this.GenBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // GenBtn
            // 
            this.GenBtn.Location = new System.Drawing.Point(116, 74);
            this.GenBtn.Name = "GenBtn";
            this.GenBtn.Size = new System.Drawing.Size(211, 90);
            this.GenBtn.TabIndex = 0;
            this.GenBtn.Text = "Generate";
            this.GenBtn.UseVisualStyleBackColor = true;
            this.GenBtn.Click += new System.EventHandler(this.GenBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1583, 843);
            this.Controls.Add(this.GenBtn);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button GenBtn;
    }
}

