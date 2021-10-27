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
    public partial class PeakForm : Form
    {
        public PeakForm()
        {
            InitializeComponent();
        }

        private void AcceptButton_Click(object sender, EventArgs e)
        {
            Form1 F1 = (Form1)this.Owner;
            DateTime startDate = Convert.ToDateTime(TimeStartBox.Text);
            DateTime endDate = Convert.ToDateTime(EndTimeVox.Text);
            string room = RoomBox.Text;
            F1.PrintBox.Text = F1.bl.Peaks(startDate, endDate, room);
            this.Close();
        }
    }
}
