﻿
namespace UI_Forms_
{
    partial class PrintLineForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.LineNumberBox = new System.Windows.Forms.TextBox();
            this.ok_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите номер строчки";
            // 
            // LineNumberBox
            // 
            this.LineNumberBox.Location = new System.Drawing.Point(13, 56);
            this.LineNumberBox.Name = "LineNumberBox";
            this.LineNumberBox.Size = new System.Drawing.Size(212, 23);
            this.LineNumberBox.TabIndex = 1;
            // 
            // ok_button
            // 
            this.ok_button.Location = new System.Drawing.Point(246, 56);
            this.ok_button.Name = "ok_button";
            this.ok_button.Size = new System.Drawing.Size(54, 23);
            this.ok_button.TabIndex = 2;
            this.ok_button.Text = "OK";
            this.ok_button.UseVisualStyleBackColor = true;
            this.ok_button.Click += new System.EventHandler(this.ok_button_Click);
            // 
            // PrintLineForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 98);
            this.Controls.Add(this.ok_button);
            this.Controls.Add(this.LineNumberBox);
            this.Controls.Add(this.label1);
            this.Name = "PrintLineForm";
            this.Text = "PrintLineForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox LineNumberBox;
        private System.Windows.Forms.Button ok_button;
    }
}