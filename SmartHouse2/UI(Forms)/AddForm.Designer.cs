
namespace UI_Forms_
{
    partial class AddForm
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
            this.DateBox = new System.Windows.Forms.TextBox();
            this.RoomBox = new System.Windows.Forms.TextBox();
            this.DetectorBox = new System.Windows.Forms.TextBox();
            this.SignalBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuccessButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(319, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Добавление элемента в БД";
            // 
            // DateBox
            // 
            this.DateBox.Location = new System.Drawing.Point(15, 125);
            this.DateBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DateBox.Name = "DateBox";
            this.DateBox.Size = new System.Drawing.Size(282, 27);
            this.DateBox.TabIndex = 1;
            // 
            // RoomBox
            // 
            this.RoomBox.Location = new System.Drawing.Point(15, 244);
            this.RoomBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RoomBox.Name = "RoomBox";
            this.RoomBox.Size = new System.Drawing.Size(282, 27);
            this.RoomBox.TabIndex = 2;
            // 
            // DetectorBox
            // 
            this.DetectorBox.Location = new System.Drawing.Point(15, 377);
            this.DetectorBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DetectorBox.Name = "DetectorBox";
            this.DetectorBox.Size = new System.Drawing.Size(282, 27);
            this.DetectorBox.TabIndex = 3;
            // 
            // SignalBox
            // 
            this.SignalBox.Location = new System.Drawing.Point(14, 521);
            this.SignalBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SignalBox.Name = "SignalBox";
            this.SignalBox.Size = new System.Drawing.Size(282, 27);
            this.SignalBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(15, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(316, 31);
            this.label2.TabIndex = 5;
            this.label2.Text = "Дата(в формате дд.мм.гггг)";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(15, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(282, 31);
            this.label3.TabIndex = 6;
            this.label3.Text = "Комната";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(15, 329);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(282, 31);
            this.label4.TabIndex = 7;
            this.label4.Text = "Номер датчика";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(15, 473);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(283, 31);
            this.label5.TabIndex = 8;
            this.label5.Text = "Показатель";
            // 
            // SuccessButton
            // 
            this.SuccessButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SuccessButton.Location = new System.Drawing.Point(84, 579);
            this.SuccessButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SuccessButton.Name = "SuccessButton";
            this.SuccessButton.Size = new System.Drawing.Size(158, 50);
            this.SuccessButton.TabIndex = 9;
            this.SuccessButton.Text = "Принять";
            this.SuccessButton.UseVisualStyleBackColor = true;
            this.SuccessButton.Click += new System.EventHandler(this.SuccessButton_Click);
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Indigo;
            this.ClientSize = new System.Drawing.Size(343, 657);
            this.Controls.Add(this.SuccessButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SignalBox);
            this.Controls.Add(this.DetectorBox);
            this.Controls.Add(this.RoomBox);
            this.Controls.Add(this.DateBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AddForm";
            this.Text = "AddForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox DateBox;
        public System.Windows.Forms.TextBox RoomBox;
        public System.Windows.Forms.TextBox DetectorBox;
        public System.Windows.Forms.TextBox SignalBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button SuccessButton;
    }
}