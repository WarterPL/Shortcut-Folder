using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShortcutFolder
{
    public partial class Form2 : Form
    {
        public string adr { get; set; }
        public string nm { get; set; }
        public int index;
        public bool mypng;
        public string mpadres;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            adr = textBox1.Text;
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            textBox1.Text = openFileDialog1.FileName;
            adr = textBox1.Text;
            pictureBox1.BackgroundImage = Icon.ExtractAssociatedIcon(adr).ToBitmap();
        }

        private void openFileDialog2_FileOk(object sender, CancelEventArgs e)
        {
            mpadres = openFileDialog2.FileName;
            pictureBox1.BackgroundImage = Image.FromFile(openFileDialog2.FileName);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            nm = textBox2.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1.Confirm(adr, nm, index, mypng, mpadres);
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            openFileDialog2.ShowDialog();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
            {
                mypng = true;
                button3.Visible = true;
            }
            else
            {
                mypng = false;
                button3.Visible = false;
            }
        }
    }
}
