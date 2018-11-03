using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using Text_File_Builder.Properties;

namespace Text_File_Builder
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
            pathText.Text = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            tabber.Click += (obj, e) => 
            tabber.SelectedTab.ImageIndex = -1;

            ImageList images = new ImageList();
            images.Images.Add(Resources.stars);
            tabber.ImageList = images;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                pathText.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists(pathText.Text))
            {
                MessageBox.Show("Please select a folder to save in.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(titleTextBox.Text))
            {
                MessageBox.Show("Please give the document a title.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string path = pathText.Text + Path.DirectorySeparatorChar + titleTextBox.Text + ".txt";
            if (File.Exists(path))
            {
                if (MessageBox.Show("A file with this name already exists.\nDo you wish to overwrite the existing file?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                    == DialogResult.No) return;
            }

            File.WriteAllText(path, contentTextBox.Text);
            contentTextBox.Clear();
            contentTextBox.ClearUndo();
            titleTextBox.Clear();
            titleTextBox.ClearUndo();

            logs.Items.Add(new ListViewItem(new string[] { DateTime.Now.ToString(), $"File {path} saved\n\n" }));
            logsPage.ImageIndex = 0;
        }
    }
}