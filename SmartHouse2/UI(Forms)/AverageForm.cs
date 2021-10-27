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
    public partial class AverageForm : Form
    {
        public AverageForm()
        {
            InitializeComponent();
        }

        private void YAcceptButton_Click(object sender, EventArgs e)
        {
            Form1 F1 = (Form1)this.Owner;
            string year = YyearBox.Text;
            string room = RoomBox.Text;
            DateTime date = Convert.ToDateTime($"01.01.{year}");
            F1.PrintBox.Text = F1.bl.AverageYear(date, room);
            this.Close();
        }

        private void MAccept_Button_Click(object sender, EventArgs e)
        {
            Form1 F1 = (Form1)this.Owner;
            string month = MmonthBox.Text;
            string year = MYearBox.Text;
            string room = RoomBox.Text;
            DateTime date = Convert.ToDateTime($"01.{month}.{year}");
            F1.PrintBox.Text = F1.bl.AverageMonth(date, room);
            this.Close();
        }

        private void DAccept_Button_Click(object sender, EventArgs e)
        {
            Form1 F1 = (Form1)this.Owner;
            string date = DdateBox.Text;
            string room = RoomBox.Text;
            F1.PrintBox.Text = F1.bl.AverageDays(date, room);
            this.Close();
        }
    }
}
