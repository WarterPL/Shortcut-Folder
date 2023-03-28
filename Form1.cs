using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Diagnostics;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShortcutFolder
{
    public partial class Form1 : Form
    {
        static string[] name = new string[10];
        static string[] adres = new string[10];
        static string[] mypngadres = new string[10];
        int index;
        static bool[] mypng = new bool[10];

        public Form1()
        {
            InitializeComponent();
        }

        #region Run program button
        private void pictureBox1_Click(object sender, EventArgs e)
        { Start(0); index = 0; }
        private void pictureBox2_Click(object sender, EventArgs e)
        { Start(1); index = 1; }
        private void pictureBox3_Click(object sender, EventArgs e)
        { Start(2); index = 2; }
        private void pictureBox4_Click(object sender, EventArgs e)
        { Start(3); index = 3; }
        private void pictureBox5_Click(object sender, EventArgs e)
        { Start(4); index = 4; }
        private void pictureBox6_Click(object sender, EventArgs e)
        { Start(5); index = 5; }
        private void pictureBox7_Click(object sender, EventArgs e)
        { Start(6); index = 6; }
        private void pictureBox8_Click(object sender, EventArgs e)
        { Start(7); index = 7; }
        private void pictureBox9_Click(object sender, EventArgs e)
        { Start(8); index = 8; }
        private void pictureBox10_Click(object sender, EventArgs e)
        { Start(9); index = 9; }
        #endregion
        private void Start(int indx)
        {
            try
            {
                Process.Start(adres[indx]);
            }
            catch (Exception e)
            {
                MessageBox.Show($"{e.Message}", "Shortcut folder", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public static void Confirm(string path, string text, int indx, bool myImg, string mpa)
        {
            Form1.adres[indx] = path;
            Form1.name[indx] = text;
            mypng[indx] = myImg;
            mypngadres[indx] = mpa;
        }

        #region Slot Editor Run
        private void slot1ToolStripMenuItem_Click(object sender, EventArgs e)
        { index = 0; SlotEditor(); }
        private void slot2ToolStripMenuItem_Click_1(object sender, EventArgs e)
        { index = 1; SlotEditor(); }
        private void slot3ToolStripMenuItem_Click(object sender, EventArgs e)
        { index = 2; SlotEditor(); }
        private void slot4ToolStripMenuItem_Click(object sender, EventArgs e)
        { index = 3; SlotEditor(); }
        private void slot5ToolStripMenuItem_Click(object sender, EventArgs e)
        { index = 4; SlotEditor(); }
        private void slot6ToolStripMenuItem_Click(object sender, EventArgs e)
        { index = 5; SlotEditor(); }
        private void slot7ToolStripMenuItem_Click(object sender, EventArgs e)
        { index = 6; SlotEditor(); }
        private void slot8ToolStripMenuItem_Click(object sender, EventArgs e)
        { index = 7; SlotEditor(); }
        private void slot9ToolStripMenuItem_Click(object sender, EventArgs e)
        { index = 8; SlotEditor(); }
        private void slot10ToolStripMenuItem_Click(object sender, EventArgs e)
        { index = 9; SlotEditor(); }
        #endregion
        void SlotEditor()
        {
            Form2 f2 = new Form2();
            f2.Show();
            f2.index = index;
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PictureBox[] box =
    {
                pictureBox1,
                pictureBox2,
                pictureBox3,
                pictureBox4,
                pictureBox5,
                pictureBox6,
                pictureBox7,
                pictureBox8,
                pictureBox9,
                pictureBox10
            };
            Label[] lab =
            {
                label1,
                label2,
                label3,
                label4,
                label5,
                label6,
                label7,
                label8,
                label9,
                label10
            };
            try
            {
                for(int i = 0; i < 10; i++)
                {
                    if (mypng[i])
                    {
                        if(mypngadres[i] != "") box[i].BackgroundImage = Image.FromFile(mypngadres[i]);
                    }
                    else
                    {
                        if (adres[i] != "") box[i].BackgroundImage = Icon.ExtractAssociatedIcon(adres[i]).ToBitmap();
                    }
                    lab[i].Text = name[i];
                }
            }
            catch (Exception f)
            {
                MessageBox.Show($"{f.Message}", "Shortcut folder", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            string path = @"C:/ShortcutsData";
            string programname = Path.GetFileName(System.Reflection.Assembly.GetEntryAssembly().Location);
            string file = @"C:/ShortcutsData/" + programname + ".sdf";

            if (!Directory.Exists(path))
            { Directory.CreateDirectory(path); }
            if (!File.Exists(file))
            { File.Create(file).Close(); }
            StreamWriter writer = new StreamWriter(file);
            for (int i = 0; i < 10; i++)
            {
                writer.WriteLine(name[i]);
                writer.WriteLine(adres[i]);
                writer.WriteLine(mypng[i]);
                writer.WriteLine(mypngadres[i]);
            }
            writer.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string path = @"C:/ShortcutsData";
            string programname = Path.GetFileName(System.Reflection.Assembly.GetEntryAssembly().Location);
            string file = @"C:/ShortcutsData/" + programname + ".sdf";
            if (Directory.Exists(path))
                if (File.Exists(file))
                {
                    StreamReader reader = new StreamReader(file);
                    for (int i = 0; i < 10; i++)
                    {
                        name[i] = reader.ReadLine();
                        adres[i] = reader.ReadLine();
                        mypng[i] = Convert.ToBoolean(reader.ReadLine());
                        mypngadres[i] = reader.ReadLine();
                    }
                    reader.Close();

                    PictureBox[] box =
            {
                pictureBox1,
                pictureBox2,
                pictureBox3,
                pictureBox4,
                pictureBox5,
                pictureBox6,
                pictureBox7,
                pictureBox8,
                pictureBox9,
                pictureBox10
            };
                    Label[] lab =
                    {
                label1,
                label2,
                label3,
                label4,
                label5,
                label6,
                label7,
                label8,
                label9,
                label10
            };
                    for (int i = 0; i < 10; i++)
                    {
                        if (mypng[i])
                        {
                            if (mypngadres[i] != "")
                            box[i].BackgroundImage = Image.FromFile(mypngadres[i]);
                        }
                        else
                        {
                            if(adres[i] != "")
                            box[i].BackgroundImage = Icon.ExtractAssociatedIcon(adres[i]).ToBitmap();
                        }
                        lab[i].Text = name[i];
                    }
                }
        }
    }
}
