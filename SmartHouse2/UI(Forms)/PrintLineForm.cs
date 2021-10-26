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
    public partial class PrintLineForm : Form
    {
        BuisnessLogic bl = new BuisnessLogic();
        public PrintLineForm()
        {

            InitializeComponent();
        }

        private void ok_button_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            PrintLineForm plf = new PrintLineForm();
            int lineNumber = LineNumberBox.Text.ParseInt(1);
            /*if (int.TryParse(LineNumberBox.Text, out lineNumber))
            {
                f1.PrintBox.Text = bl.PrintLine(lineNumber).ToString();
            }*/
            f1.PrintBox.Text = bl.PrintLine(lineNumber);
            
            plf.Close();
        }
    }
}
