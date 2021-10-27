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
    public partial class AddForm : Form
    {
        public AddForm()
        {
            InitializeComponent();
        }

        private void SuccessButton_Click(object sender, EventArgs e)
        {
            Form1 F1 = (Form1)this.Owner;
            string date = DateBox.Text;
            string room = RoomBox.Text;
            int detector = DetectorBox.Text.ParseInt(1);
            int signal = SignalBox.Text.ParseInt(1);
            F1.bl.Add(date, room, detector, signal);
            F1.PrintBox.Text = "Запись добавлена!";
            this.Close();
        }
    }
}
