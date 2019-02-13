using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OCR_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Capture_Click(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = inputBox.Text;
        }

        private void Load_Click(object sender, EventArgs e)
        {
            Reader read = new Reader();

            var text = read.Read((Bitmap)pictureBox1.Image);
            outputText.Text = text;
        }
    }
}
