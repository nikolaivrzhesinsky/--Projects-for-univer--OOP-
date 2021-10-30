
namespace UI_Forms_
{
    partial class DeleteForm
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
            this.delete = new System.Windows.Forms.Label();
            this.DeleteBox = new System.Windows.Forms.TextBox();
            this.OK_button = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // delete
            // 
            this.delete.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.delete.ForeColor = System.Drawing.SystemColors.Control;
            this.delete.Location = new System.Drawing.Point(7, 12);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(391, 31);
            this.delete.TabIndex = 0;
            this.delete.Text = "Введите номер строчки для удаления";
            // 
            // DeleteBox
            // 
            this.DeleteBox.Location = new System.Drawing.Point(7, 57);
            this.DeleteBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DeleteBox.Name = "DeleteBox";
            this.DeleteBox.Size = new System.Drawing.Size(268, 27);
            this.DeleteBox.TabIndex = 1;
            // 
            // OK_button
            // 
            this.OK_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OK_button.Location = new System.Drawing.Point(306, 57);
            this.OK_button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.OK_button.Name = "OK_button";
            this.OK_button.Size = new System.Drawing.Size(86, 31);
            this.OK_button.TabIndex = 2;
            this.OK_button.Text = "OK";
            this.OK_button.UseVisualStyleBackColor = true;
            this.OK_button.Click += new System.EventHandler(this.OK_button_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Indigo;
            this.panel1.Controls.Add(this.OK_button);
            this.panel1.Controls.Add(this.DeleteBox);
            this.panel1.Controls.Add(this.delete);
            this.panel1.Location = new System.Drawing.Point(3, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(422, 125);
            this.panel1.TabIndex = 3;
            // 
            // DeleteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 149);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "DeleteForm";
            this.Text = "DeleteForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label delete;
        public System.Windows.Forms.TextBox DeleteBox;
        private System.Windows.Forms.Button OK_button;
        private System.Windows.Forms.Panel panel1;
    }
}