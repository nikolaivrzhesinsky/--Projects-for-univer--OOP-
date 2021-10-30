
namespace UI_Forms_
{
    partial class StepForm
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
            this.TimeStartBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.EndTimeVox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.RoomBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.StepBox = new System.Windows.Forms.TextBox();
            this.AcceptButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(14, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Начальная дата";
            // 
            // TimeStartBox
            // 
            this.TimeStartBox.Location = new System.Drawing.Point(14, 67);
            this.TimeStartBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TimeStartBox.Name = "TimeStartBox";
            this.TimeStartBox.Size = new System.Drawing.Size(192, 27);
            this.TimeStartBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(14, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "Конечная дата";
            // 
            // EndTimeVox
            // 
            this.EndTimeVox.Location = new System.Drawing.Point(14, 183);
            this.EndTimeVox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.EndTimeVox.Name = "EndTimeVox";
            this.EndTimeVox.Size = new System.Drawing.Size(192, 27);
            this.EndTimeVox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(12, 244);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 32);
            this.label3.TabIndex = 5;
            this.label3.Text = "Комната";
            // 
            // RoomBox
            // 
            this.RoomBox.Location = new System.Drawing.Point(14, 301);
            this.RoomBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RoomBox.Name = "RoomBox";
            this.RoomBox.Size = new System.Drawing.Size(192, 27);
            this.RoomBox.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(12, 351);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 28);
            this.label4.TabIndex = 7;
            this.label4.Text = "Шаг";
            // 
            // StepBox
            // 
            this.StepBox.Location = new System.Drawing.Point(12, 394);
            this.StepBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.StepBox.Name = "StepBox";
            this.StepBox.Size = new System.Drawing.Size(194, 27);
            this.StepBox.TabIndex = 8;
            // 
            // AcceptButton
            // 
            this.AcceptButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AcceptButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AcceptButton.Location = new System.Drawing.Point(20, 462);
            this.AcceptButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AcceptButton.Name = "AcceptButton";
            this.AcceptButton.Size = new System.Drawing.Size(189, 76);
            this.AcceptButton.TabIndex = 9;
            this.AcceptButton.Text = "Принять";
            this.AcceptButton.UseVisualStyleBackColor = true;
            this.AcceptButton.Click += new System.EventHandler(this.AcceptButton_Click);
            // 
            // StepForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Indigo;
            this.ClientSize = new System.Drawing.Size(229, 560);
            this.Controls.Add(this.AcceptButton);
            this.Controls.Add(this.StepBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.RoomBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.EndTimeVox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TimeStartBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "StepForm";
            this.Text = "StepForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TimeStartBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox EndTimeVox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox RoomBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox StepBox;
        private System.Windows.Forms.Button AcceptButton;
    }
}