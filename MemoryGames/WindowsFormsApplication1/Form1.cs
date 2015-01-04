using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            pictureBoxs[0] = pictureBox1;
            pictureBoxs[1] = pictureBox2;
            pictureBoxs[2] = pictureBox3;
            pictureBoxs[3] = pictureBox4;
            pictureBoxs[4] = pictureBox5;
            pictureBoxs[5] = pictureBox6;
            pictureBoxs[6] = pictureBox7;
            pictureBoxs[7] = pictureBox8;
            pictureBoxs[8] = pictureBox9;
            pictureBoxs[9] = pictureBox10;
            pictureBoxs[10] = pictureBox11;
            pictureBoxs[11] = pictureBox12;
            pictureBoxs[12] = pictureBox13;
            pictureBoxs[13] = pictureBox14;
            pictureBoxs[14] = pictureBox15;
            pictureBoxs[15] = pictureBox16;
            pictureBoxs[16] = pictureBox17;
            pictureBoxs[17] = pictureBox18;
            pictureBoxs[18] = pictureBox19;
            pictureBoxs[19] = pictureBox20;
            pictureBoxs[20] = pictureBox21;
            pictureBoxs[21] = pictureBox22;
            pictureBoxs[22] = pictureBox23;
            pictureBoxs[23] = pictureBox24;
            for (int i = 0; i < 24; i++) { pictureBoxs[i].Enabled = false; }
            for (int i = 0; i < 24; i++) { pictureBoxs[i].ImageLocation = "uu.jpg"; }
            f[0] = "u1.jpg";
            f[1] = "u2.jpg";
            f[2] = "u3.jpg";
            f[3] = "u4.jpg";
            f[4] = "u5.jpg";
            f[5] = "u6.jpg";
            f[6] = "u1.jpg";
            f[7] = "u2.jpg";
            f[8] = "u3.jpg";
            f[9] = "u4.jpg";
            f[10] = "u5.jpg";
            f[11] = "u6.jpg";
            tex[0] = textBox1;
            tex[1] = textBox2;
            tex[2] = textBox3;
            tex[3] = textBox4;
            tex[4] = textBox5;
            tex[5] = textBox6;
            tex[6] = textBox7;
            tex[7] = textBox8;
            tex[8] = textBox9;
            tex[9] = textBox10;
            tex[10] = textBox11;
            tex[11] = textBox12;
            groupBox1.Visible = false;
        }
        PictureBox[] pictureBoxs = new PictureBox[24];
        TextBox[] tex = new TextBox[12];
        public int[] p = new int[24];
        public int w = 0;
        public int b;
        public int c;
        public int counter;
        public int time;
        String[] f = new String[12];
        public int i;
        public bool game=true;
            
        private void button1_Click(object sender, EventArgs e)
        {
            if (game)
            {
                game = false;
                button2.Enabled = false;
                button1.Text = "Stop Game";
                for (int i = 0; i < 24; i++) { pictureBoxs[i].Enabled = true; }
                for (int i = 0; i < 24; i++) { pictureBoxs[i].ImageLocation = "uu.jpg"; }
                for (int i = 0; i < 24; i++) { p[i] = 0; }
                int x;
                int y = 1;
                Random r = new Random();
                for (int i = 0; i < 12; i++)
                {
                    for (int j = 0; j < 2; j++)
                    {
                        do
                        {
                            x = r.Next(0, 24);
                        }
                        while (p[x] != 0);
                        p[x] = y;
                    }
                    y++;
                }
                timer2.Enabled = true;
                time = 0;
                counter = 0;
            }
            else
            {
                game = true;
                button1.Text = "New Game"; 
                button2.Enabled = true;
            }
        }

        #region PICTUREBOXES
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Piclick(1);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Piclick(2);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Piclick(3);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Piclick(4);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Piclick(5);
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Piclick(6);
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Piclick(7);
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            Piclick(8);
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            Piclick(9);
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            Piclick(10);
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            Piclick(11);
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            Piclick(12);
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            Piclick(13);
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            Piclick(14);
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            Piclick(15);
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            Piclick(16);
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            Piclick(17);
        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            Piclick(18);
        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            Piclick(19);
        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {
            Piclick(20);
        }

        private void pictureBox21_Click(object sender, EventArgs e)
        {
            Piclick(21);
        }

        private void pictureBox22_Click(object sender, EventArgs e)
        {
            Piclick(22);
        }

        private void pictureBox23_Click(object sender, EventArgs e)
        {
            Piclick(23);
        }

        private void pictureBox24_Click(object sender, EventArgs e)
        {
            Piclick(24);
        }
        #endregion

        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBoxs[c - 1].ImageLocation = "uu.jpg";
            pictureBoxs[b - 1].ImageLocation = "uu.jpg";
            timer1.Enabled = false;
            for (int i = 0; i < 24; i++)
            {
                if (pictureBoxs[i].ImageLocation == "uu.jpg") { pictureBoxs[i].Enabled = true; }
            }
        }

        public void Piclick(int a)
        {
            pictureBoxs[a - 1].ImageLocation = f[p[a-1]-1];
            if (w == 0)
            {
                w = p[a - 1];
                b = a;
            }
            else
            {
                if (w == p[a - 1]) {pictureBoxs[b - 1].Enabled = false;}
                else
                {
                    timer1.Enabled = true;
                    for (int i = 0; i < 24; i++) { pictureBoxs[i].Enabled = false; }
                }
                w = 0;
            }
            pictureBoxs[a - 1].Enabled = false;
            c = a;
            counter++;
            int j=0;
            while (pictureBoxs[j].ImageLocation != "uu.jpg" && j<23)
            {
                j++;
            }
            if (pictureBox24.Enabled == false) { j++; }
            if (j == 24) 
            { 
                timer2.Enabled = false;
                MessageBox.Show("Filaraki ekanes "+(counter/2)+" prospatheies kai "+time+" defterolepta! Ton pairneis file...");
            }
            
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            time++;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            for (i=0;i<12;i++) openFileDialog1.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            if (openFileDialog1.FileName != null)
            {
                tex[i].Text = Path.GetFullPath(openFileDialog1.FileName);
                f[i]=tex[i].Text;
            }
        }
    }
}
