
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Начальная дата";
            // 
            // TimeStartBox
            // 
            this.TimeStartBox.Location = new System.Drawing.Point(6, 54);
            this.TimeStartBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TimeStartBox.Name = "TimeStartBox";
            this.TimeStartBox.Size = new System.Drawing.Size(195, 27);
            this.TimeStartBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(6, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "Конечная дата";
            // 
            // EndTimeVox
            // 
            this.EndTimeVox.Location = new System.Drawing.Point(6, 183);
            this.EndTimeVox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.EndTimeVox.Name = "EndTimeVox";
            this.EndTimeVox.Size = new System.Drawing.Size(195, 27);
            this.EndTimeVox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(6, 244);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 32);
            this.label3.TabIndex = 4;
            this.label3.Text = "Комната";
            // 
            // RoomBox
            // 
            this.RoomBox.Location = new System.Drawing.Point(6, 301);
            this.RoomBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RoomBox.Name = "RoomBox";
            this.RoomBox.Size = new System.Drawing.Size(195, 27);
            this.RoomBox.TabIndex = 5;
            // 
            // AcceptButton
            // 
            this.AcceptButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AcceptButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AcceptButton.Location = new System.Drawing.Point(6, 362);
            this.AcceptButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AcceptButton.Name = "AcceptButton";
            this.AcceptButton.Size = new System.Drawing.Size(198, 52);
            this.AcceptButton.TabIndex = 6;
            this.AcceptButton.Text = "Принять";
            this.AcceptButton.UseVisualStyleBackColor = true;
            this.AcceptButton.Click += new System.EventHandler(this.AcceptButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Indigo;
            this.panel1.Controls.Add(this.AcceptButton);
            this.panel1.Controls.Add(this.RoomBox);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.EndTimeVox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.TimeStartBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(9, 17);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(209, 434);
            this.panel1.TabIndex = 7;
            // 
            // PeakForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(225, 460);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "PeakForm";
            this.Text = "PeakForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TimeStartBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox EndTimeVox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox RoomBox;
        private System.Windows.Forms.Button AcceptButton;
        private System.Windows.Forms.Panel panel1;
    }
}