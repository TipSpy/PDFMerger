using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PDFMerger
{

    public partial class Form1 : Form
    {
        public static int counter = 0;

        public Dictionary<string, string> fileList = new Dictionary<string, string>();

        public Form1()
        {
            InitializeComponent();
        }

        private void MergeBtn_Click_1(object sender, EventArgs e)
        {
            if (counter >= 2)
            {
                if (textBox1.Text != "")
                {
                    _ = MessageBox.Show("This is when it would merge! The filename would be " + textBox1.Text + ".pdf");
                } 
                else
                {
                    _ = MessageBox.Show("Enter a name for your merged PDF!");
                }
            }
            else
            {
                _ = MessageBox.Show("Add at least two PDF documents first!");
            }
        }

        private void AddFileBtn_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //Get the path of specified file
                var filePath = openFileDialog1.FileName;
                var fileName = openFileDialog1.SafeFileName;
                fileList.Add(fileName, filePath);
                listBox1.Items.Add(fileName);
                counter++;

            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void RemoveBTN_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
                counter--;
            } 
            else
            {
                MessageBox.Show("Select an item from the list!");
            }
        }

        private void ClearListBTN_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            counter = 0;
        }
    }
}
