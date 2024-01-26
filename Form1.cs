﻿using System;
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
using System.Reflection;

namespace ShortcutFolder
{
    public partial class Form1 : Form
    {
        static List<LabelLine> mylabels = new List<LabelLine>();
        int index = 0;

        string myFile = "file", path;

        public Form1()
        {
            InitializeComponent();
        }

        private void SaveData()
        {
            StreamWriter writer = new StreamWriter(myFile);
            foreach(LabelLine line in mylabels)
            {
                writer.WriteLine(line.ToString());
            }
            writer.Close();
        }

        private void LoadData()
        {
            if(!Directory.Exists(path))
                Directory.CreateDirectory(path);
            if(!File.Exists(myFile))
                File.WriteAllText(myFile, "");
            var rd = new StreamReader(myFile);
            MyFileReader myReader = new MyFileReader(rd.ReadToEnd());
            rd.Close();
            mylabels = myReader.GetLabelLines();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            path = @"C:/ShortcutsData/";
            string programname = Path.GetFileName(Assembly.GetEntryAssembly().Location);
            myFile = path + (programname.Substring(0, programname.Length-4)) + ".sdf";

            LoadData();

            if (mylabels.Count == 0)
                NewItem_Click(null, null);

            RefreshList();
            RefreshFields();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(index < mylabels.Count)
                listView1.Items[index].ForeColor = Color.White;

            index = listView1.FocusedItem.Index;

            RefreshFields();

            listView1.SelectedItems.Clear();
            listView1.Items[index].ForeColor = Color.Cyan;
        }

        private void nameOfApp_TextChanged(object sender, EventArgs e)
        {
            if (index >= 0)
                mylabels[index].reName(nameOfApp.Text); 
                //name[index] = nameOfApp.Text;
            RefreshList();
        }
        private void Adress_TextChanged(object sender, EventArgs e)
        {
            if (index >= 0)
                mylabels[index].reAdress(Adress.Text);
                //adres[index] = Adress.Text;
            RefreshList();
            RefreshFields();
        }
        private void RunVia_TextChanged(object sender, EventArgs e)
        {
            if (index >= 0)
                mylabels[index].reVia(RunVia.Text);
                //mypngadres[index] = CustomIMG.Text;
            RefreshList();
        }
        private void CustomIMG_TextChanged(object sender, EventArgs e)
        {
            if (index >= 0)
                mylabels[index].reImgAdress(CustomIMG.Text);
                //mypngadres[index] = CustomIMG.Text;
            RefreshList();
            RefreshFields();
        }

        private void NewItem_Click(object sender, EventArgs e)
        {
            mylabels.Add(new LabelLine());
            if (mylabels.Count == 1)
                RefreshFields();

            RefreshList();
        }
        private void Delete_Click(object sender, EventArgs e)
        {
            if (mylabels.Count <= 0 || index >= mylabels.Count)
                return;

            DialogResult result = MessageBox.Show($"Would you like to delete record?" +
                $"\nName: {mylabels[index].Name}" +
                $"\nAdress: {mylabels[index].Adress}", "Shortcut folder", MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question);

            if (result == DialogResult.Cancel)
                return;

            mylabels.RemoveAt(index);

            RefreshList();
            RefreshFields();
        }

        private void RefreshList()
        {
            listView1.Items.Clear();
            for (int i = 0; i < mylabels.Count; i++)
            {
                ListViewItem item = new ListViewItem(mylabels[i].Name);
                listView1.Items.Add(item);
            }

            if(index >= 0 && index < mylabels.Count)
            listView1.Items[index].ForeColor = Color.Cyan;

            nameOfApp.Enabled = index >= mylabels.Count ?  false : true;
            Adress.Enabled = index >= mylabels.Count ? false : true;
            RunVia.Enabled = index >= mylabels.Count ? false : true;
            CustomIMG.Enabled = index >= mylabels.Count ? false : true;

            SaveData();
        }

        void RefreshFields()
        {
            if (index < 0 || index >= mylabels.Count)
                return;

            CustomIMG.Text = mylabels[index].myPngAdress;
            nameOfApp.Text = mylabels[index].Name;
            Adress.Text = mylabels[index].Adress;
            RunVia.Text = mylabels[index].Via;

            try
            {
                if (mylabels[index].myPngAdress == "-default")
                {
                    Icon appIcon = Icon.ExtractAssociatedIcon(mylabels[index].Adress);
                    pictureBox1.Image = appIcon.ToBitmap();
                    pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;

                }
                else
                {
                    Bitmap bitmap = new Bitmap(mylabels[index].myPngAdress);
                    pictureBox1.Image = bitmap;
                    pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                }
            }
            catch (Exception e)
            {
                pictureBox1.Image = Properties.Resources.errorIcon;
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            Adress.Text = openFileDialog1.FileName;
            mylabels[index].reAdress(openFileDialog1.FileName);
        }

        private void run_Click(object sender, EventArgs e)
        {
            try
            {
                Process process = new Process();
                process.StartInfo = new ProcessStartInfo
                {
                    FileName = mylabels[index].Adress,
                    Arguments = mylabels[index].Via == "-systemSettings" ? null : mylabels[index].Via,
                };
                process.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "FILE NOT FOUND", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void adressLabel_Click(object sender, EventArgs e)
        { openFileDialog1.ShowDialog(); }
    }
}