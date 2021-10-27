
namespace UI_Forms_
{
    partial class PeakForm
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
            this.AcceptButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Начальная дата";
            // 
            // TimeStartBox
            // 
            this.TimeStartBox.Location = new System.Drawing.Point(13, 53);
            this.TimeStartBox.Name = "TimeStartBox";
            this.TimeStartBox.Size = new System.Drawing.Size(153, 23);
            this.TimeStartBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(13, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Конечная дата";
            // 
            // EndTimeVox
            // 
            this.EndTimeVox.Location = new System.Drawing.Point(13, 150);
            this.EndTimeVox.Name = "EndTimeVox";
            this.EndTimeVox.Size = new System.Drawing.Size(153, 23);
            this.EndTimeVox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(13, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Комната";
            // 
            // RoomBox
            // 
            this.RoomBox.Location = new System.Drawing.Point(13, 246);
            this.RoomBox.Name = "RoomBox";
            this.RoomBox.Size = new System.Drawing.Size(153, 23);
            this.RoomBox.TabIndex = 5;
            // 
            // AcceptButton
            // 
            this.AcceptButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AcceptButton.Location = new System.Drawing.Point(13, 306);
            this.AcceptButton.Name = "AcceptButton";
            this.AcceptButton.Size = new System.Drawing.Size(153, 39);
            this.AcceptButton.TabIndex = 6;
            this.AcceptButton.Text = "Принять";
            this.AcceptButton.UseVisualStyleBackColor = true;
            this.AcceptButton.Click += new System.EventHandler(this.AcceptButton_Click);
            // 
            // PeakForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(181, 400);
            this.Controls.Add(this.AcceptButton);
            this.Controls.Add(this.RoomBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.EndTimeVox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TimeStartBox);
            this.Controls.Add(this.label1);
            this.Name = "PeakForm";
            this.Text = "PeakForm";
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
        private System.Windows.Forms.Button AcceptButton;
    }
}