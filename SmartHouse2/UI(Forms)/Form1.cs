using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SmartHouseLibrary;

namespace UI_Forms_
{
    public partial class Form1 : Form
    {
        public BuisnessLogic bl = new BuisnessLogic();
        
        public Form1()
        {
            bl.DataCreation();
            bl.Update();
            InitializeComponent();
        }

        
        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Print_Click(object sender, EventArgs e)
        {
            PrintBox.Clear();
            PrintBox.Text = bl.Print();
        }

        private void PrintBox_TextChanged(object sender, EventArgs e)
        {
            PrintBox.ScrollBars = ScrollBars.Vertical;
        }

        private void PrintLine_Click(object sender, EventArgs e)
        {
            PrintBox.Clear();
            PrintLineForm plf = new PrintLineForm();
            plf.Show(this);
            
            
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            PrintBox.Clear();
            
        }
    }
}
