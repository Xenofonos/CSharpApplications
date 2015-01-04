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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
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
            button2.Enabled = false;
            button3.Enabled = false;
            groupBox1.Visible = false;
        }
        TextBox[] tex = new TextBox[12];
        public String[] f = new String[12];
        string[] files;
        public int i;
        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            if (openFileDialog1.FileName != null)
            {
                tex[i].Text = Path.GetFullPath(openFileDialog1.FileName);
                f[i] = tex[i].Text;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (i = 0; i < 12; i++) openFileDialog1.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            try
            {
                f1.f = this.f;
                f1.ShowDialog();
            }
            finally
            {
                f1.Dispose();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult result = this.folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                files = Directory.GetFiles(folderBrowserDialog1.SelectedPath);
            }
            for (i = 0; i < 12; i++)
            {
                f[i] = files[i];
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            button2.Enabled = true;
            groupBox1.Visible = true;
            button3.Enabled = false;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            button3.Enabled = true;
            groupBox1.Visible = false;
            button2.Enabled = false;
        }


    }
}
