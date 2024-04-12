using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exersise
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void rbBoy_CheckedChanged(object sender, EventArgs e)
        {
            pb.Image = Image.FromFile(@"G:\Boy.png");
            lblTitle.Text = "Boy";
        }

        private void rbGirl_CheckedChanged(object sender, EventArgs e)
        {
            pb.Image = Image.FromFile(@"G:\Girl.png");
            lblTitle.Text = "Girl";
        }

        private void rbBook_CheckedChanged(object sender, EventArgs e)
        {
            pb.Image = Image.FromFile(@"G:\Book.png");
            lblTitle.Text = "Book";
        }

        private void rbPen_CheckedChanged(object sender, EventArgs e)
        {
            pb.Image = Image.FromFile(@"G:\Pen.png");
            lblTitle.Text = "Pen";
        }
    }
}
