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
            this.FileList = new System.Windows.Forms.ListBox();
            this.PreviewList = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SelectFolder = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.Preview = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FileList
            // 
            this.FileList.FormattingEnabled = true;
            this.FileList.Location = new System.Drawing.Point(70, 89);
            this.FileList.Name = "FileList";
            this.FileList.Size = new System.Drawing.Size(624, 329);
            this.FileList.TabIndex = 0;
            // 
            // PreviewList
            // 
            this.PreviewList.FormattingEnabled = true;
            this.PreviewList.Location = new System.Drawing.Point(732, 89);
            this.PreviewList.Name = "PreviewList";
            this.PreviewList.Size = new System.Drawing.Size(297, 329);
            this.PreviewList.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(70, 29);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(859, 20);
            this.textBox1.TabIndex = 2;
            // 
            // SelectFolder
            // 
            this.SelectFolder.Location = new System.Drawing.Point(954, 29);
            this.SelectFolder.Name = "SelectFolder";
            this.SelectFolder.Size = new System.Drawing.Size(75, 23);
            this.SelectFolder.TabIndex = 3;
            this.SelectFolder.Text = "Select";
            this.SelectFolder.UseVisualStyleBackColor = true;
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(856, 439);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(75, 23);
            this.Save.TabIndex = 5;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            // 
            // Preview
            // 
            this.Preview.Location = new System.Drawing.Point(312, 439);
            this.Preview.Name = "Preview";
            this.Preview.Size = new System.Drawing.Size(75, 23);
            this.Preview.TabIndex = 6;
            this.Preview.Text = "Preview";
            this.Preview.UseVisualStyleBackColor = true;
            this.Preview.Click += new System.EventHandler(this.Preview_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 486);
            this.Controls.Add(this.Preview);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.SelectFolder);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.PreviewList);
            this.Controls.Add(this.FileList);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox FileList;
        private System.Windows.Forms.ListBox PreviewList;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button SelectFolder;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button Preview;
    }
}

