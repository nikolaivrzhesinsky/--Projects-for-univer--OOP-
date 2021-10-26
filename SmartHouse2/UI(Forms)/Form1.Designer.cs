
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "DetectorWatch";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::UI_Forms_.Properties.Resources._1814102_eye_sight_view_icon;
            this.pictureBox1.Location = new System.Drawing.Point(190, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(36, 34);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // exit
            // 
            this.exit.Cursor = System.Windows.Forms.Cursors.Default;
            this.exit.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.exit.Location = new System.Drawing.Point(761, 7);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(27, 36);
            this.exit.TabIndex = 2;
            this.exit.Text = "x";
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // Print
            // 
            this.Print.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Print.ForeColor = System.Drawing.Color.Black;
            this.Print.Location = new System.Drawing.Point(12, 66);
            this.Print.Name = "Print";
            this.Print.Size = new System.Drawing.Size(221, 31);
            this.Print.TabIndex = 3;
            this.Print.Text = "Вывод БД на экран";
            this.Print.UseVisualStyleBackColor = true;
            this.Print.Click += new System.EventHandler(this.Print_Click);
            // 
            // PrintBox
            // 
            this.PrintBox.Location = new System.Drawing.Point(472, 46);
            this.PrintBox.Multiline = true;
            this.PrintBox.Name = "PrintBox";
            this.PrintBox.Size = new System.Drawing.Size(316, 392);
            this.PrintBox.TabIndex = 4;
            this.PrintBox.TextChanged += new System.EventHandler(this.PrintBox_TextChanged);
            // 
            // PrintLine
            // 
            this.PrintLine.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PrintLine.ForeColor = System.Drawing.Color.Black;
            this.PrintLine.Location = new System.Drawing.Point(13, 104);
            this.PrintLine.Name = "PrintLine";
            this.PrintLine.Size = new System.Drawing.Size(220, 31);
            this.PrintLine.TabIndex = 5;
            this.PrintLine.Text = "Вывод строчки";
            this.PrintLine.UseVisualStyleBackColor = true;
            this.PrintLine.Click += new System.EventHandler(this.PrintLine_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DeleteButton.ForeColor = System.Drawing.Color.Black;
            this.DeleteButton.Location = new System.Drawing.Point(13, 148);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(220, 30);
            this.DeleteButton.TabIndex = 6;
            this.DeleteButton.Text = "Удалить элемент";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.PrintLine);
            this.Controls.Add(this.PrintBox);
            this.Controls.Add(this.Print);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.ForeColor = System.Drawing.Color.Red;
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
    }
}

