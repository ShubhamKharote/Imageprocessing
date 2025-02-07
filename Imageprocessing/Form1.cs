using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Imageprocessing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            fd.Filter = "jpg|*.jpg|png|*.png|jpeg|*.jpeg|bmp|*.bmp|all files|*.*";
            DialogResult dr = fd.ShowDialog();
            if (dr == DialogResult.OK) 
            {
                try {
                    pictureBox1.Image = Bitmap.FromFile(fd.FileName);
                }catch(Exception ex) { MessageBox.Show("Image Size Too much"+ex); }
                  }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Cursor.Current= Cursors.WaitCursor;
            Bitmap bt = new Bitmap(pictureBox1.Image);
            for (int y=0; y < bt.Height; y++) 
            {
                for (int x =0; x < bt.Width; x++) 
                {
                    Color c =bt.GetPixel(x, y);
                    int r = c.R;
                    int g =c.G;
                    int b =c.B;
                    
                    int avg = (r + g + b) / 3;
                    Color tempcolor = Color.FromArgb(avg, avg, avg);
                    bt.SetPixel(x, y, tempcolor);

                }
            }
            pictureBox2. Image = bt;
            Cursor.Current = Cursors.Default;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            Bitmap bt = new Bitmap(pictureBox1.Image);
            for (int y = 0; y < bt.Height; y++)
            {
                for (int x = 0; x < bt.Width; x++)
                {
                    Color c = bt.GetPixel(x, y);
                    int r = c.R;
                    int g = c.G;
                    int b = c.B;

                    int avg = (r + g + b) / 3;
                  
                        Color tempcolor = Color.FromArgb(avg, avg, avg);

                    if (radioButton1.Checked) 
                    {
                         tempcolor = Color.FromArgb(255, avg, avg);
                    }
                    if (radioButton2.Checked)
                    {
                       tempcolor = Color.FromArgb(avg, 255, avg);
                    }
                    if (radioButton3.Checked)
                    {
                        tempcolor = Color.FromArgb(avg, avg, 255);
                    }
                    bt.SetPixel(x, y, tempcolor);

                }
            }
            pictureBox2.Image = bt;
            Cursor.Current = Cursors.Default;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            Bitmap bt = new Bitmap(pictureBox1.Image);
            Bitmap bt2 = new Bitmap(bt.Width,bt.Height);
            int w = bt.Width;
            int h = bt.Height;
            for (int y = 0; y < bt.Height; y++)
            {
                for (int x = 0; x < bt.Width; x++)
                {
                    Color c = bt.GetPixel(x, y);
                    int r = c.R;
                    int g = c.G;
                    int b = c.B;

                    bt2.SetPixel(w-1-x, y, c);

                }
            }
            pictureBox2.Image = bt2;
            Cursor.Current = Cursors.Default;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            Bitmap bt = new Bitmap(pictureBox1.Image);
            int w = bt.Width;
            int h = bt.Height;
            for (int y = 0; y < bt.Height; y++)
            {
                for (int x = 0; x < bt.Width; x++)
                {
                    Color c = bt.GetPixel(x, y);
                    int r = c.R;
                    int g = c.G;
                    int b = c.B;

                    bt.SetPixel(w - 1 - x, y, c);

                }
            }
            pictureBox2.Image = bt;
            Cursor.Current = Cursors.Default;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            Bitmap bt = new Bitmap(pictureBox1.Image);
            int th = int.Parse(textBox1.Text);
            for (int y = 0; y < bt.Height; y++)
            {
                for (int x = 0; x < bt.Width; x++)
                {
                    Color c = bt.GetPixel(x, y);
                    int r = c.R;
                    int g = c.G;
                    int b = c.B;

                    int avg = (r + g + b) / 3;
                    if (avg < th)
                    {
                        bt.SetPixel(x, y, Color.Black);
                    }
                    else
                    {
                        bt.SetPixel(x, y, Color.White);
                    }

                }
            }
            pictureBox2.Image = bt;
            Cursor.Current = Cursors.Default;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            Bitmap bt = new Bitmap(pictureBox1.Image);
            int th = int.Parse(textBox1.Text);
            for (int y = 0; y < bt.Height; y++)
            {
                for (int x = 0; x < bt.Width; x++)
                {
                    Color c = bt.GetPixel(x, y);
                    int r = c.R;
                    int g = c.G;
                    int b = c.B;

                    int avg = (r + g + b) / 3;
                    if (avg < th)
                    {
                        bt.SetPixel(x, y, Color.Red);
                    }
                    else
                    {
                        bt.SetPixel(x, y, Color.White);
                    }

                }
            }
            pictureBox2.Image = bt;
            Cursor.Current = Cursors.Default;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            Bitmap bt = new Bitmap(pictureBox1.Image);
            int th = int.Parse(textBox1.Text);
            for (int y = 0; y < bt.Height; y++)
            {
                for (int x = 0; x < bt.Width; x++)
                {
                    Color c = bt.GetPixel(x, y);
                    int r = c.R;
                    int g = c.G;
                    int b = c.B;

                    int avg = (r + g + b) / 3;
                    if (avg < th)
                    {
                        bt.SetPixel(x, y, Color.Blue);
                    }
                    else
                    {
                        bt.SetPixel(x, y, Color.White);
                    }

                }
            }
            pictureBox2.Image = bt;
            Cursor.Current = Cursors.Default;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            Bitmap bt = new Bitmap(pictureBox1.Image);
            int th = int.Parse(textBox1.Text);
            for (int y = 0; y < bt.Height; y++)
            {
                for (int x = 0; x < bt.Width; x++)
                {
                    Color c = bt.GetPixel(x, y);
                    int r = c.R;
                    int g = c.G;
                    int b = c.B;

                    int avg = (r + g + b) / 3;
                    if (avg < th)
                    {
                        bt.SetPixel(x, y, Color.Yellow);
                    }
                    else
                    {
                    //    bt.SetPixel(x, y, Color.White);
                    }

                }
            }
            pictureBox2.Image = bt;
            Cursor.Current = Cursors.Default;
        }
    }
}
