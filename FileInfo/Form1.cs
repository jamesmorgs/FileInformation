using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileInformation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtFilePath.Text = openFileDialog1.FileName;

                FileInfo fileInfo = new FileInfo(txtFilePath.Text);

                if (fileInfo.Exists)
                {
                    // local times
                    DateTime creationTime = fileInfo.CreationTime;
                    DateTime lastWriteTime = fileInfo.LastWriteTime;
                    DateTime lastAccessTime = fileInfo.LastAccessTime;
                    
                    txtCreated.Text = creationTime.ToString();
                    txtModified.Text = lastWriteTime.ToString();
                    txtAccessed.Text = lastAccessTime.ToString();
                }
                else
                {
                    MessageBox.Show("File does not exist. Please try again!");
                }               
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtFilePath.Clear();
            txtCreated.Clear();
            txtModified.Clear();
            txtAccessed.Clear();
        }
    }
}
