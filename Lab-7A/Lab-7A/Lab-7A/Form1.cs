using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Lab_7A
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DialogResult result;

        int[] intarr = { 1, 2, 3, 4, 5 };

        void display<T>(T[] source)
        {
            foreach (T element in source)
            {
                //l1.Items.Add(element.ToString());
                MessageBox.Show(element.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            display(intarr);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using(FolderBrowserDialog path = new FolderBrowserDialog())
            {
                path.SelectedPath = "D:";
                result = path.ShowDialog();
                if (result == DialogResult.OK)
                {
                    textBox1.Text = path.SelectedPath;
                    //string xyz = path.SelectedPath;
                    DirectoryInfo place = new DirectoryInfo(path.SelectedPath);
                    FileInfo[] Files = place.GetFiles();
                    foreach(FileInfo allFiles in Files)
                    {
                        listBox0.Items.Add(allFiles.Name);
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog path2 = new FolderBrowserDialog())
            {
                path2.SelectedPath = "D:";
                result = path2.ShowDialog();
                if (result == DialogResult.OK)
                {
                    textBox2.Text = path2.SelectedPath;

                    DirectoryInfo place = new DirectoryInfo(path2.SelectedPath);
                    FileInfo[] Files = place.GetFiles();
                    foreach (FileInfo allFiles in Files)
                    {
                        listBox1.Items.Add(allFiles.Name);
                    }
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //foreach (File same in )
        }
    }
}
