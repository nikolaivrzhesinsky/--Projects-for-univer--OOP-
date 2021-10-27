
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
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Начальная дата";
            // 
            // TimeStartBox
            // 
            this.TimeStartBox.Location = new System.Drawing.Point(12, 50);
            this.TimeStartBox.Name = "TimeStartBox";
            this.TimeStartBox.Size = new System.Drawing.Size(153, 23);
            this.TimeStartBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Конечная дата";
            // 
            // EndTimeVox
            // 
            this.EndTimeVox.Location = new System.Drawing.Point(12, 137);
            this.EndTimeVox.Name = "EndTimeVox";
            this.EndTimeVox.Size = new System.Drawing.Size(153, 23);
            this.EndTimeVox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Комната";
            // 
            // RoomBox
            // 
            this.RoomBox.Location = new System.Drawing.Point(12, 235);
            this.RoomBox.Name = "RoomBox";
            this.RoomBox.Size = new System.Drawing.Size(153, 23);
            this.RoomBox.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(12, 284);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 21);
            this.label4.TabIndex = 7;
            this.label4.Text = "Шаг";
            // 
            // StepBox
            // 
            this.StepBox.Location = new System.Drawing.Point(13, 324);
            this.StepBox.Name = "StepBox";
            this.StepBox.Size = new System.Drawing.Size(152, 23);
            this.StepBox.TabIndex = 8;
            // 
            // AcceptButton
            // 
            this.AcceptButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AcceptButton.Location = new System.Drawing.Point(12, 383);
            this.AcceptButton.Name = "AcceptButton";
            this.AcceptButton.Size = new System.Drawing.Size(153, 55);
            this.AcceptButton.TabIndex = 9;
            this.AcceptButton.Text = "Принять";
            this.AcceptButton.UseVisualStyleBackColor = true;
            this.AcceptButton.Click += new System.EventHandler(this.AcceptButton_Click);
            // 
            // StepForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(191, 450);
            this.Controls.Add(this.AcceptButton);
            this.Controls.Add(this.StepBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.RoomBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.EndTimeVox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TimeStartBox);
            this.Controls.Add(this.label1);
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