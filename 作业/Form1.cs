using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 作业
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        bool bn = true;
        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (bn == true)
            {
                label1.Visible = true;
                label2.Visible = false;
                this.BackColor = Color.Black;
                bn = false;
            }
            else if (bn == false)
            {
                label1.Visible = false;
                label2.Visible = true;
                this.BackColor = Color.White;
                bn = true;
            }


        }
    }
}
