using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartHouse
{
    class Class1 : Button
    {
        public void CreateMyButton(Button btn, Form frm, string str, int x, int y, int w, int h, EventHandler evh)
        {
            btn = new Button();

            btn.Text = str;
            btn.Location = new Point(x, y);
            btn.Size = new Size(w, h);

            btn.Click += evh;
            frm.Controls.Add(btn);
        }
    }
}
