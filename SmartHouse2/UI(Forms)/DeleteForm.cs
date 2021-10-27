using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SmartHouseLibrary;

namespace UI_Forms_
{
    public partial class DeleteForm : Form
    {
        public DeleteForm()
        {
            InitializeComponent();
        }

        private void OK_button_Click(object sender, EventArgs e)
        {
            Form1 F1 = (Form1)this.Owner;
            int x = DeleteBox.Text.ParseInt(1);
            F1.PrintBox.Text = F1.bl.PrintLine(x)+"-был удален";
            F1.bl.Delete(x);
            this.Close();
        }
    }
}
