
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
            this.label1.Location = new System.Drawing.Point(15, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите номер строчки";
            // 
            // LineNumberBox
            // 
            this.LineNumberBox.Location = new System.Drawing.Point(15, 75);
            this.LineNumberBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.LineNumberBox.Name = "LineNumberBox";
            this.LineNumberBox.Size = new System.Drawing.Size(242, 27);
            this.LineNumberBox.TabIndex = 1;
            this.LineNumberBox.TextChanged += new System.EventHandler(this.LineNumberBox_TextChanged);
            // 
            // ok_button
            // 
            this.ok_button.Location = new System.Drawing.Point(281, 75);
            this.ok_button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ok_button.Name = "ok_button";
            this.ok_button.Size = new System.Drawing.Size(62, 31);
            this.ok_button.TabIndex = 2;
            this.ok_button.Text = "OK";
            this.ok_button.UseVisualStyleBackColor = true;
            this.ok_button.Click += new System.EventHandler(this.ok_button_Click);
            // 
            // PrintLineForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 131);
            this.Controls.Add(this.ok_button);
            this.Controls.Add(this.LineNumberBox);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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