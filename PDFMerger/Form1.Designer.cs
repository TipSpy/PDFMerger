namespace PDFMerger
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.MergeBtn = new System.Windows.Forms.Button();
            this.AddFileBtn = new System.Windows.Forms.Button();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.RemoveBTN = new System.Windows.Forms.Button();
            this.ClearListBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MergeBtn
            // 
            this.MergeBtn.Location = new System.Drawing.Point(517, 366);
            this.MergeBtn.Name = "MergeBtn";
            this.MergeBtn.Size = new System.Drawing.Size(276, 79);
            this.MergeBtn.TabIndex = 0;
            this.MergeBtn.Text = "Merge";
            this.MergeBtn.UseVisualStyleBackColor = true;
            this.MergeBtn.Click += new System.EventHandler(this.MergeBtn_Click_1);
            // 
            // AddFileBtn
            // 
            this.AddFileBtn.Location = new System.Drawing.Point(517, 12);
            this.AddFileBtn.Name = "AddFileBtn";
            this.AddFileBtn.Size = new System.Drawing.Size(276, 121);
            this.AddFileBtn.TabIndex = 1;
            this.AddFileBtn.Text = "Add PDF(s)";
            this.AddFileBtn.UseVisualStyleBackColor = true;
            this.AddFileBtn.Click += new System.EventHandler(this.AddFileBtn_Click);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 450);
            this.splitter1.TabIndex = 2;
            this.splitter1.TabStop = false;
            // 
            // listBox1
            // 
            this.listBox1.AllowDrop = true;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(499, 433);
            this.listBox1.TabIndex = 3;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(517, 340);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(276, 20);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(514, 324);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Name for Merged PDF:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "pdf";
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "PDF Documents (.pdf) | *.pdf";
            this.openFileDialog1.Multiselect = true;
            this.openFileDialog1.ShowReadOnly = true;
            this.openFileDialog1.SupportMultiDottedExtensions = true;
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // RemoveBTN
            // 
            this.RemoveBTN.Location = new System.Drawing.Point(518, 139);
            this.RemoveBTN.Name = "RemoveBTN";
            this.RemoveBTN.Size = new System.Drawing.Size(275, 50);
            this.RemoveBTN.TabIndex = 6;
            this.RemoveBTN.Text = "Remove Selected File";
            this.RemoveBTN.UseVisualStyleBackColor = true;
            this.RemoveBTN.Click += new System.EventHandler(this.RemoveBTN_Click);
            // 
            // ClearListBTN
            // 
            this.ClearListBTN.Location = new System.Drawing.Point(518, 195);
            this.ClearListBTN.Name = "ClearListBTN";
            this.ClearListBTN.Size = new System.Drawing.Size(275, 50);
            this.ClearListBTN.TabIndex = 7;
            this.ClearListBTN.Text = "Clear Selection";
            this.ClearListBTN.UseVisualStyleBackColor = true;
            this.ClearListBTN.Click += new System.EventHandler(this.ClearListBTN_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ClearListBTN);
            this.Controls.Add(this.RemoveBTN);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.AddFileBtn);
            this.Controls.Add(this.MergeBtn);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ß";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button MergeBtn;
        private System.Windows.Forms.Button AddFileBtn;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button RemoveBTN;
        private System.Windows.Forms.Button ClearListBTN;
    }
}

