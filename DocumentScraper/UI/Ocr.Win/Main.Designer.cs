namespace Ocr.Win
{
    partial class main_frm
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
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.btn_QueFiles = new System.Windows.Forms.Button();
            this.fileDataGridView = new System.Windows.Forms.DataGridView();
            this.btn_SearchWord = new System.Windows.Forms.Button();
            this.btn_process = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.FilePathName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.keyWordFound = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pagNumToDisplay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.fileDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // openFile
            // 
            this.openFile.FileName = "*.pdf";
            this.openFile.InitialDirectory = "c:\\";
            // 
            // btn_QueFiles
            // 
            this.btn_QueFiles.Location = new System.Drawing.Point(12, 189);
            this.btn_QueFiles.Name = "btn_QueFiles";
            this.btn_QueFiles.Size = new System.Drawing.Size(112, 42);
            this.btn_QueFiles.TabIndex = 0;
            this.btn_QueFiles.Text = "Queue File(s)";
            this.btn_QueFiles.UseVisualStyleBackColor = true;
            this.btn_QueFiles.Click += new System.EventHandler(this.btn_QueFiles_Click);
            // 
            // fileDataGridView
            // 
            this.fileDataGridView.AllowUserToAddRows = false;
            this.fileDataGridView.AllowUserToDeleteRows = false;
            this.fileDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.fileDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.fileDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FilePathName,
            this.keyWordFound,
            this.pagNumToDisplay});
            this.fileDataGridView.Location = new System.Drawing.Point(12, 246);
            this.fileDataGridView.Name = "fileDataGridView";
            this.fileDataGridView.ReadOnly = true;
            this.fileDataGridView.Size = new System.Drawing.Size(621, 177);
            this.fileDataGridView.TabIndex = 1;
            // 
            // btn_SearchWord
            // 
            this.btn_SearchWord.Location = new System.Drawing.Point(13, 24);
            this.btn_SearchWord.Name = "btn_SearchWord";
            this.btn_SearchWord.Size = new System.Drawing.Size(112, 38);
            this.btn_SearchWord.TabIndex = 2;
            this.btn_SearchWord.Text = "Search Word(s)";
            this.btn_SearchWord.UseVisualStyleBackColor = true;
            // 
            // btn_process
            // 
            this.btn_process.Location = new System.Drawing.Point(139, 189);
            this.btn_process.Name = "btn_process";
            this.btn_process.Size = new System.Drawing.Size(112, 42);
            this.btn_process.TabIndex = 3;
            this.btn_process.Text = "Process";
            this.btn_process.UseVisualStyleBackColor = true;
            this.btn_process.Click += new System.EventHandler(this.btn_process_Click);
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(12, 68);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(621, 101);
            this.listView1.TabIndex = 4;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // FilePathName
            // 
            this.FilePathName.HeaderText = "File Path";
            this.FilePathName.Name = "FilePathName";
            this.FilePathName.ReadOnly = true;
            this.FilePathName.Width = 350;
            // 
            // keyWordFound
            // 
            this.keyWordFound.HeaderText = "Found";
            this.keyWordFound.Name = "keyWordFound";
            this.keyWordFound.ReadOnly = true;
            // 
            // pagNumToDisplay
            // 
            this.pagNumToDisplay.HeaderText = "Page number";
            this.pagNumToDisplay.Name = "pagNumToDisplay";
            this.pagNumToDisplay.ReadOnly = true;
            // 
            // main_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 456);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btn_process);
            this.Controls.Add(this.btn_SearchWord);
            this.Controls.Add(this.fileDataGridView);
            this.Controls.Add(this.btn_QueFiles);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "main_frm";
            this.Text = "OCR";
            ((System.ComponentModel.ISupportInitialize)(this.fileDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFile;
        private System.Windows.Forms.Button btn_QueFiles;
        private System.Windows.Forms.DataGridView fileDataGridView;
        private System.Windows.Forms.Button btn_SearchWord;
        private System.Windows.Forms.Button btn_process;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn FilePathName;
        private System.Windows.Forms.DataGridViewTextBoxColumn keyWordFound;
        private System.Windows.Forms.DataGridViewTextBoxColumn pagNumToDisplay;
    }
}

