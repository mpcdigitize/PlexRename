namespace PlexRename.Win
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
            this.fileList = new System.Windows.Forms.ListBox();
            this.previewList = new System.Windows.Forms.ListBox();
            this.inputPath = new System.Windows.Forms.TextBox();
            this.selectFolder = new System.Windows.Forms.Button();
            this.saveChanges = new System.Windows.Forms.Button();
            this.previewChanges = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // fileList
            // 
            this.fileList.FormattingEnabled = true;
            this.fileList.Location = new System.Drawing.Point(70, 89);
            this.fileList.Name = "fileList";
            this.fileList.Size = new System.Drawing.Size(959, 199);
            this.fileList.TabIndex = 0;
            // 
            // previewList
            // 
            this.previewList.FormattingEnabled = true;
            this.previewList.Location = new System.Drawing.Point(70, 359);
            this.previewList.Name = "previewList";
            this.previewList.Size = new System.Drawing.Size(959, 199);
            this.previewList.TabIndex = 1;
            // 
            // inputPath
            // 
            this.inputPath.Location = new System.Drawing.Point(70, 29);
            this.inputPath.Name = "inputPath";
            this.inputPath.Size = new System.Drawing.Size(859, 20);
            this.inputPath.TabIndex = 2;
            // 
            // selectFolder
            // 
            this.selectFolder.Location = new System.Drawing.Point(954, 29);
            this.selectFolder.Name = "selectFolder";
            this.selectFolder.Size = new System.Drawing.Size(75, 23);
            this.selectFolder.TabIndex = 3;
            this.selectFolder.Text = "Select";
            this.selectFolder.UseVisualStyleBackColor = true;
            this.selectFolder.Click += new System.EventHandler(this.selectFolder_Click);
            // 
            // saveChanges
            // 
            this.saveChanges.Location = new System.Drawing.Point(484, 581);
            this.saveChanges.Name = "saveChanges";
            this.saveChanges.Size = new System.Drawing.Size(75, 23);
            this.saveChanges.TabIndex = 5;
            this.saveChanges.Text = "Save";
            this.saveChanges.UseVisualStyleBackColor = true;
            // 
            // previewChanges
            // 
            this.previewChanges.Location = new System.Drawing.Point(484, 308);
            this.previewChanges.Name = "previewChanges";
            this.previewChanges.Size = new System.Drawing.Size(75, 23);
            this.previewChanges.TabIndex = 6;
            this.previewChanges.Text = "Preview";
            this.previewChanges.UseVisualStyleBackColor = true;
            this.previewChanges.Click += new System.EventHandler(this.Preview_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 616);
            this.Controls.Add(this.previewChanges);
            this.Controls.Add(this.saveChanges);
            this.Controls.Add(this.selectFolder);
            this.Controls.Add(this.inputPath);
            this.Controls.Add(this.previewList);
            this.Controls.Add(this.fileList);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox fileList;
        private System.Windows.Forms.ListBox previewList;
        private System.Windows.Forms.TextBox inputPath;
        private System.Windows.Forms.Button selectFolder;
      //  private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button saveChanges;
        private System.Windows.Forms.Button previewChanges;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}

