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
    public partial class ChangeForm : Form
    {
        public ChangeForm()
        {
            InitializeComponent();
        }

        private void AcceptButton_Click(object sender, EventArgs e)
        {
            Form1 F1 = (Form1)this.Owner;
            int lineNumber = LineNumberBox.Text.ParseInt(1);
            string date = DateBox.Text;
            string room = RoomBox.Text;
            int detector = DetectorBox.Text.ParseInt(-1);
            int signal = SignalBox.Text.ParseInt(-1);
            
            if (room != null)
                F1.bl.ChangeRoom(lineNumber, room);
            if (detector != -1)
                F1.bl.ChangeDetector(lineNumber, detector);
            if (signal != -1)
                F1.bl.ChangeSignal(lineNumber, signal);
            if (date != null)
                F1.bl.ChangeDate(lineNumber, date);
            F1.PrintBox.Text = "Запись была отредактирована!";
            F1.bl.Update();
            this.Close();

        }
    }
}
