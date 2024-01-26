
namespace ShortcutFolder
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.listView1 = new System.Windows.Forms.ListView();
            this.nameOfApp = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.adressLabel = new System.Windows.Forms.Label();
            this.Adress = new System.Windows.Forms.TextBox();
            this.customIMGlabel = new System.Windows.Forms.Label();
            this.CustomIMG = new System.Windows.Forms.TextBox();
            this.NewItem = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.run = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.RunViaLabel = new System.Windows.Forms.Label();
            this.RunVia = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.SystemColors.InfoText;
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listView1.ForeColor = System.Drawing.SystemColors.Menu;
            this.listView1.HideSelection = false;
            this.listView1.LabelWrap = false;
            this.listView1.Location = new System.Drawing.Point(12, 12);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(372, 403);
            this.listView1.TabIndex = 29;
            this.listView1.TileSize = new System.Drawing.Size(255, 30);
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Tile;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // nameOfApp
            // 
            this.nameOfApp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nameOfApp.Location = new System.Drawing.Point(548, 36);
            this.nameOfApp.Name = "nameOfApp";
            this.nameOfApp.Size = new System.Drawing.Size(453, 27);
            this.nameOfApp.TabIndex = 30;
            this.nameOfApp.TextChanged += new System.EventHandler(this.nameOfApp_TextChanged);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nameLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.nameLabel.Location = new System.Drawing.Point(390, 39);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(139, 20);
            this.nameLabel.TabIndex = 31;
            this.nameLabel.Text = "Name of program";
            // 
            // adressLabel
            // 
            this.adressLabel.AutoSize = true;
            this.adressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.adressLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.adressLabel.Location = new System.Drawing.Point(421, 92);
            this.adressLabel.Name = "adressLabel";
            this.adressLabel.Size = new System.Drawing.Size(108, 20);
            this.adressLabel.TabIndex = 33;
            this.adressLabel.Text = "Adress to file";
            this.adressLabel.Click += new System.EventHandler(this.adressLabel_Click);
            // 
            // Adress
            // 
            this.Adress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Adress.Location = new System.Drawing.Point(548, 89);
            this.Adress.Name = "Adress";
            this.Adress.Size = new System.Drawing.Size(453, 24);
            this.Adress.TabIndex = 32;
            this.Adress.TextChanged += new System.EventHandler(this.Adress_TextChanged);
            // 
            // customIMGlabel
            // 
            this.customIMGlabel.AutoSize = true;
            this.customIMGlabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.customIMGlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.customIMGlabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.customIMGlabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.customIMGlabel.Location = new System.Drawing.Point(412, 156);
            this.customIMGlabel.Name = "customIMGlabel";
            this.customIMGlabel.Size = new System.Drawing.Size(117, 20);
            this.customIMGlabel.TabIndex = 35;
            this.customIMGlabel.Text = "Custom image";
            // 
            // CustomIMG
            // 
            this.CustomIMG.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CustomIMG.Location = new System.Drawing.Point(548, 153);
            this.CustomIMG.Name = "CustomIMG";
            this.CustomIMG.Size = new System.Drawing.Size(453, 27);
            this.CustomIMG.TabIndex = 34;
            this.CustomIMG.TextChanged += new System.EventHandler(this.CustomIMG_TextChanged);
            // 
            // NewItem
            // 
            this.NewItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.NewItem.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NewItem.Location = new System.Drawing.Point(611, 186);
            this.NewItem.Name = "NewItem";
            this.NewItem.Size = new System.Drawing.Size(192, 30);
            this.NewItem.TabIndex = 36;
            this.NewItem.Text = "New shortcut";
            this.NewItem.UseVisualStyleBackColor = false;
            this.NewItem.Click += new System.EventHandler(this.NewItem_Click);
            // 
            // Delete
            // 
            this.Delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Delete.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Delete.Location = new System.Drawing.Point(809, 186);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(192, 30);
            this.Delete.TabIndex = 37;
            this.Delete.Text = "Delete shortcut";
            this.Delete.UseVisualStyleBackColor = false;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // run
            // 
            this.run.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.run.Cursor = System.Windows.Forms.Cursors.Hand;
            this.run.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.run.Location = new System.Drawing.Point(394, 186);
            this.run.Name = "run";
            this.run.Size = new System.Drawing.Size(211, 30);
            this.run.TabIndex = 38;
            this.run.Text = "Run application";
            this.run.UseVisualStyleBackColor = false;
            this.run.Click += new System.EventHandler(this.run_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "adress";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(394, 225);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(190, 190);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 39;
            this.pictureBox1.TabStop = false;
            // 
            // RunViaLabel
            // 
            this.RunViaLabel.AutoSize = true;
            this.RunViaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.RunViaLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.RunViaLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.RunViaLabel.Location = new System.Drawing.Point(464, 122);
            this.RunViaLabel.Name = "RunViaLabel";
            this.RunViaLabel.Size = new System.Drawing.Size(65, 20);
            this.RunViaLabel.TabIndex = 41;
            this.RunViaLabel.Text = "Run via";
            // 
            // RunVia
            // 
            this.RunVia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.RunVia.Location = new System.Drawing.Point(548, 119);
            this.RunVia.Name = "RunVia";
            this.RunVia.Size = new System.Drawing.Size(453, 27);
            this.RunVia.TabIndex = 40;
            this.RunVia.TextChanged += new System.EventHandler(this.RunVia_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1010, 426);
            this.Controls.Add(this.RunViaLabel);
            this.Controls.Add(this.RunVia);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.run);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.NewItem);
            this.Controls.Add(this.customIMGlabel);
            this.Controls.Add(this.CustomIMG);
            this.Controls.Add(this.adressLabel);
            this.Controls.Add(this.Adress);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.nameOfApp);
            this.Controls.Add(this.listView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Shortcut menu";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.TextBox nameOfApp;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label adressLabel;
        private System.Windows.Forms.TextBox Adress;
        private System.Windows.Forms.Label customIMGlabel;
        private System.Windows.Forms.TextBox CustomIMG;
        private System.Windows.Forms.Button NewItem;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button run;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label RunViaLabel;
        private System.Windows.Forms.TextBox RunVia;
    }
}

