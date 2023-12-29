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
        static int values;
        static List<string> name = new List<string>();
        static List<string> adres = new List<string>();
        static List<string> via = new List<string>();
        static List<string> mypngadres = new List<string>();
        int index = 0;

        string myFile = "file", path;

        public Form1()
        {
            InitializeComponent();
        }

        private void SaveData()
        {
            StreamWriter writer = new StreamWriter(myFile);
            values = adres.ToArray().Length;
            writer.WriteLine(values);
            for (int i = 0; i < values; i++)
            {
                writer.WriteLine($"#### SLOT {i+1} #####");
                writer.WriteLine(name[i]);
                writer.WriteLine(adres[i]);
                writer.WriteLine(via[i]);
                writer.WriteLine(mypngadres[i]);
            }
            writer.Close();
        }

        private void LoadData()
        {
            if(!Directory.Exists(path))
                Directory.CreateDirectory(path);
            if(!File.Exists(myFile))
                File.WriteAllText(myFile, "0");

            StreamReader reader = new StreamReader(myFile);
            values = Convert.ToInt32(reader.ReadLine());
            for(int i = 0; i < values; i++)
            {
                reader.ReadLine();
                name.Add(reader.ReadLine());
                adres.Add(reader.ReadLine());
                via.Add(reader.ReadLine());
                mypngadres.Add(reader.ReadLine());
            }
            reader.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            path = @"C:/ShortcutsData/";
            string programname = Path.GetFileName(System.Reflection.Assembly.GetEntryAssembly().Location);
            myFile = path + (programname.Substring(0, programname.Length-4)) + ".sdf";

            LoadData();

            if (values == 0)
                NewItem_Click(null, null);

            RefreshList();
            RefreshFields();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(index < values)
                listView1.Items[index].ForeColor = Color.White;

            index = listView1.FocusedItem.Index;

            RefreshFields();

            listView1.SelectedItems.Clear();
            listView1.Items[index].ForeColor = Color.Cyan;
        }

        private void nameOfApp_TextChanged(object sender, EventArgs e)
        {
            if(index >= 0)
                name[index] = nameOfApp.Text;
            RefreshList();
        }

        private void Adress_TextChanged(object sender, EventArgs e)
        {
            if (index >= 0)
                adres[index] = Adress.Text;
            RefreshList();
        }

        private void RunVia_TextChanged(object sender, EventArgs e)
        {
            if (index >= 0)
                mypngadres[index] = CustomIMG.Text;
            RefreshList();
        }

        private void CustomIMG_TextChanged(object sender, EventArgs e)
        {
            if (index >= 0)
                mypngadres[index] = CustomIMG.Text;
            RefreshList();
        }



        private void NewItem_Click(object sender, EventArgs e)
        {
            name.Add("NEW SHORTCUT");
            adres.Add("<Put path here>");
            mypngadres.Add("-default");
            via.Add("-systemSettings");

            values++;

            if (values == 1)
                RefreshFields();

            RefreshList();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (values <= 0 || index >= values)
                return;

            DialogResult result = MessageBox.Show($"Would you like to delete record?" +
                $"\nName: {name[index]}" +
                $"\nAdress: {adres[index]}", "Shortcut folder", MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question);

            if (result == DialogResult.Cancel)
                return;

            name.RemoveAt(index);
            adres.RemoveAt(index);
            via.RemoveAt(index);
            mypngadres.RemoveAt(index);
            values--;

            RefreshList();
            RefreshFields();
        }



        private void RefreshList()
        {
            listView1.Items.Clear();
            for (int i = 0; i < values; i++)
            {
                ListViewItem item = new ListViewItem(name[i]);
                listView1.Items.Add(item);
            }

            if(index >= 0 && index < values)
            listView1.Items[index].ForeColor = Color.Cyan;



            nameOfApp.Enabled = index >= values ?  false : true;
            Adress.Enabled = index >= values ? false : true;
            RunVia.Enabled = index >= values ? false : true;
            CustomIMG.Enabled = index >= values ? false : true;

            SaveData();
        }

        void RefreshFields()
        {
            if (index < 0 || index >= values)
                return;

            CustomIMG.Text = mypngadres[index];
            nameOfApp.Text = name[index];
            Adress.Text = adres[index];
            RunVia.Text = via[index];
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            Adress.Text = openFileDialog1.FileName;
            adres[index] = openFileDialog1.FileName;
        }

        private void run_Click(object sender, EventArgs e)
        {
            try
            {
                Process process = new Process();
                process.StartInfo = new ProcessStartInfo
                {
                    FileName = adres[index],
                    Arguments = via[index] == "-systemSettings" ? null : via[index]
                };
                process.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR HANDLER", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void adressLabel_Click(object sender, EventArgs e)
        { openFileDialog1.ShowDialog(); }
    }
}
