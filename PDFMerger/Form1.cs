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
using System.Xml;
using PdfSharp;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using PdfSharp.Pdf.IO;

namespace PDFMerger
{

    public partial class Form1 : Form
    {

        public Dictionary<string, string> fileList = new Dictionary<string, string>();

        public Form1()
        {
            InitializeComponent();
            this.Text = "PDF Merger";
        }

        private void MergeBtn_Click_1(object sender, EventArgs e)
        {
            if (fileList.Count >= 2)
            {
                //if (textBox1.Text != "")
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string outPath = saveFileDialog1.FileName;

                    var files = fileList.Values.ToArray();

                    PdfDocument outputDocument = new PdfDocument();

                    foreach (string file in files)
                    {
                        PdfDocument inputDocument = PdfReader.Open(file, PdfDocumentOpenMode.Import);

                        int length = inputDocument.PageCount;
                        for (int index = 0; index < length; index++)
                        {
                            PdfPage page = inputDocument.Pages[index];
                            outputDocument.AddPage(page);
                        }
                    }

                    //outputDocument.Save(textBox1.Text + ".pdf");
                    outputDocument.Save(outPath);

                    _ = MessageBox.Show("Merged PDF file saved at '" + outPath + "' !", "Success!");

                } 

                else
                {
                    _ = MessageBox.Show("Merge Cancelled!", "Cancelled!");
                }
            }
            else
            {
                _ = MessageBox.Show("Add at least two PDF documents first!", "Add PDFs");
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
                fileList.Remove(listBox1.GetItemText(listBox1.SelectedItem));
                listBox1.Items.Remove(listBox1.SelectedItem);
            } 
            else
            {
                _ = MessageBox.Show("Select an item from the list!", "Select Item");
            }
        }

        private void ClearListBTN_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            fileList.Clear();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
