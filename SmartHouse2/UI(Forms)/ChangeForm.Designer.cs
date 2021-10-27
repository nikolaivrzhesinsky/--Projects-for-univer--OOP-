
namespace UI_Forms_
{
    partial class ChangeForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.LineNumberBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.DateBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.RoomBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.DetectorBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SignalBox = new System.Windows.Forms.TextBox();
            this.AcceptButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Реадктирование элемента";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(13, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(291, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Номер элемента для изменения";
            // 
            // LineNumberBox
            // 
            this.LineNumberBox.Location = new System.Drawing.Point(13, 92);
            this.LineNumberBox.Name = "LineNumberBox";
            this.LineNumberBox.Size = new System.Drawing.Size(291, 23);
            this.LineNumberBox.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Изменение даты";
            // 
            // DateBox
            // 
            this.DateBox.Location = new System.Drawing.Point(13, 164);
            this.DateBox.Name = "DateBox";
            this.DateBox.Size = new System.Drawing.Size(291, 23);
            this.DateBox.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(13, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(190, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Изменение комнаты";
            // 
            // RoomBox
            // 
            this.RoomBox.Location = new System.Drawing.Point(12, 239);
            this.RoomBox.Name = "RoomBox";
            this.RoomBox.Size = new System.Drawing.Size(291, 23);
            this.RoomBox.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(12, 279);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(202, 25);
            this.label5.TabIndex = 7;
            this.label5.Text = "Изменение детектора";
            // 
            // DetectorBox
            // 
            this.DetectorBox.Location = new System.Drawing.Point(12, 325);
            this.DetectorBox.Name = "DetectorBox";
            this.DetectorBox.Size = new System.Drawing.Size(291, 23);
            this.DetectorBox.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(12, 368);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(214, 25);
            this.label6.TabIndex = 9;
            this.label6.Text = "Изменение показатния";
            // 
            // SignalBox
            // 
            this.SignalBox.Location = new System.Drawing.Point(12, 415);
            this.SignalBox.Name = "SignalBox";
            this.SignalBox.Size = new System.Drawing.Size(291, 23);
            this.SignalBox.TabIndex = 10;
            // 
            // AcceptButton
            // 
            this.AcceptButton.Location = new System.Drawing.Point(355, 202);
            this.AcceptButton.Name = "AcceptButton";
            this.AcceptButton.Size = new System.Drawing.Size(96, 60);
            this.AcceptButton.TabIndex = 11;
            this.AcceptButton.Text = "Принять";
            this.AcceptButton.UseVisualStyleBackColor = true;
            this.AcceptButton.Click += new System.EventHandler(this.AcceptButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(297, 54);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(21, 25);
            this.label7.TabIndex = 12;
            this.label7.Text = "*";
            // 
            // ChangeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.AcceptButton);
            this.Controls.Add(this.SignalBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.DetectorBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.RoomBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DateBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LineNumberBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ChangeForm";
            this.Text = "ChangeForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox LineNumberBox;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox DateBox;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox RoomBox;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox DetectorBox;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox SignalBox;
        private System.Windows.Forms.Button AcceptButton;
        private System.Windows.Forms.Label label7;
    }
}