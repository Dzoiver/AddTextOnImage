using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int Coorx
        {
            get
            {
                return Convert.ToInt32(textBox1.Text);
            }
        }
        int Coory
        {
            get
            {
                return Convert.ToInt32(textBox2.Text);
            }
        }

        Graphics g;
        Image image;
        string filename;
        private void AddImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = ("png files (*.png)|*.png");
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                image = Image.FromFile(dlg.FileName);
                pictureBox1.Image = image;
            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            g = Graphics.FromImage(image);
            var font = new Font("TimesNewRoman", 25, FontStyle.Regular, GraphicsUnit.Pixel);
            g.DrawString("Hello world", font, Brushes.Black, new Point(Coorx, Coory));
            pictureBox1.Image = image;
        }
    }
}
