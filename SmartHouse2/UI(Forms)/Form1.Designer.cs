
namespace UI_Forms_
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.exit = new System.Windows.Forms.Label();
            this.Print = new System.Windows.Forms.Button();
            this.PrintBox = new System.Windows.Forms.TextBox();
            this.PrintLine = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.Add_button = new System.Windows.Forms.Button();
            this.ChangeButton = new System.Windows.Forms.Button();
            this.AverageButton = new System.Windows.Forms.Button();
            this.PeakButton = new System.Windows.Forms.Button();
            this.AvInSteps = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(14, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "DetectorWatch";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(217, 12);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(41, 45);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // exit
            // 
            this.exit.Cursor = System.Windows.Forms.Cursors.Default;
            this.exit.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.exit.Location = new System.Drawing.Point(681, 12);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(31, 48);
            this.exit.TabIndex = 2;
            this.exit.Text = "x";
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // Print
            // 
            this.Print.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Print.ForeColor = System.Drawing.Color.Black;
            this.Print.Location = new System.Drawing.Point(14, 88);
            this.Print.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Print.Name = "Print";
            this.Print.Size = new System.Drawing.Size(330, 41);
            this.Print.TabIndex = 3;
            this.Print.Text = "Вывод БД на экран";
            this.Print.UseVisualStyleBackColor = true;
            this.Print.Click += new System.EventHandler(this.Print_Click);
            // 
            // PrintBox
            // 
            this.PrintBox.Location = new System.Drawing.Point(351, 88);
            this.PrintBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PrintBox.Multiline = true;
            this.PrintBox.Name = "PrintBox";
            this.PrintBox.Size = new System.Drawing.Size(361, 521);
            this.PrintBox.TabIndex = 4;
            this.PrintBox.TextChanged += new System.EventHandler(this.PrintBox_TextChanged);
            // 
            // PrintLine
            // 
            this.PrintLine.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PrintLine.ForeColor = System.Drawing.Color.Black;
            this.PrintLine.Location = new System.Drawing.Point(13, 149);
            this.PrintLine.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PrintLine.Name = "PrintLine";
            this.PrintLine.Size = new System.Drawing.Size(330, 41);
            this.PrintLine.TabIndex = 5;
            this.PrintLine.Text = "Вывод строчки";
            this.PrintLine.UseVisualStyleBackColor = true;
            this.PrintLine.Click += new System.EventHandler(this.PrintLine_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DeleteButton.ForeColor = System.Drawing.Color.Black;
            this.DeleteButton.Location = new System.Drawing.Point(14, 219);
            this.DeleteButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(330, 40);
            this.DeleteButton.TabIndex = 6;
            this.DeleteButton.Text = "Удалить элемент";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // Add_button
            // 
            this.Add_button.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Add_button.ForeColor = System.Drawing.Color.Black;
            this.Add_button.Location = new System.Drawing.Point(15, 291);
            this.Add_button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Add_button.Name = "Add_button";
            this.Add_button.Size = new System.Drawing.Size(330, 40);
            this.Add_button.TabIndex = 7;
            this.Add_button.Text = "Добавить элемент";
            this.Add_button.UseVisualStyleBackColor = true;
            this.Add_button.Click += new System.EventHandler(this.Add_button_Click);
            // 
            // ChangeButton
            // 
            this.ChangeButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ChangeButton.ForeColor = System.Drawing.Color.Black;
            this.ChangeButton.Location = new System.Drawing.Point(14, 360);
            this.ChangeButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ChangeButton.Name = "ChangeButton";
            this.ChangeButton.Size = new System.Drawing.Size(329, 40);
            this.ChangeButton.TabIndex = 8;
            this.ChangeButton.Text = "Редактировать элемент";
            this.ChangeButton.UseVisualStyleBackColor = true;
            this.ChangeButton.Click += new System.EventHandler(this.ChangeButton_Click);
            // 
            // AverageButton
            // 
            this.AverageButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AverageButton.ForeColor = System.Drawing.Color.Black;
            this.AverageButton.Location = new System.Drawing.Point(15, 421);
            this.AverageButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AverageButton.Name = "AverageButton";
            this.AverageButton.Size = new System.Drawing.Size(329, 40);
            this.AverageButton.TabIndex = 9;
            this.AverageButton.Text = "Вычислить среднее за период";
            this.AverageButton.UseVisualStyleBackColor = true;
            this.AverageButton.Click += new System.EventHandler(this.AverageButton_Click);
            // 
            // PeakButton
            // 
            this.PeakButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PeakButton.ForeColor = System.Drawing.Color.Black;
            this.PeakButton.Location = new System.Drawing.Point(16, 489);
            this.PeakButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PeakButton.Name = "PeakButton";
            this.PeakButton.Size = new System.Drawing.Size(329, 45);
            this.PeakButton.TabIndex = 10;
            this.PeakButton.Text = "Пики за указанный период";
            this.PeakButton.UseVisualStyleBackColor = true;
            this.PeakButton.Click += new System.EventHandler(this.PeakButton_Click);
            // 
            // AvInSteps
            // 
            this.AvInSteps.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AvInSteps.ForeColor = System.Drawing.Color.Black;
            this.AvInSteps.Location = new System.Drawing.Point(15, 565);
            this.AvInSteps.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AvInSteps.Name = "AvInSteps";
            this.AvInSteps.Size = new System.Drawing.Size(329, 45);
            this.AvInSteps.TabIndex = 11;
            this.AvInSteps.Text = "Пики за период с шагом";
            this.AvInSteps.UseVisualStyleBackColor = true;
            this.AvInSteps.Click += new System.EventHandler(this.AvInSteps_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 636);
            this.Controls.Add(this.AvInSteps);
            this.Controls.Add(this.PeakButton);
            this.Controls.Add(this.AverageButton);
            this.Controls.Add(this.ChangeButton);
            this.Controls.Add(this.Add_button);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.PrintLine);
            this.Controls.Add(this.PrintBox);
            this.Controls.Add(this.Print);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.ForeColor = System.Drawing.Color.Red;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label exit;
        private System.Windows.Forms.Button Print;
        private System.Windows.Forms.Button PrintLine;
        public System.Windows.Forms.TextBox PrintBox;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button Add_button;
        private System.Windows.Forms.Button ChangeButton;
        private System.Windows.Forms.Button AverageButton;
        private System.Windows.Forms.Button PeakButton;
        private System.Windows.Forms.Button AvInSteps;
    }
}

