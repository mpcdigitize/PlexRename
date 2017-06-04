using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PlexRename.BL;
using PlexRename.BL.Extensions;

namespace PlexRename.Win
{
    public partial class Form1 : Form
    {

        ApplicationServiceLayer _service;

        public Form1()
        {
            
            InitializeComponent();
           _service = new ApplicationServiceLayer();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "PlexRename";

        }

        private void Preview_Click(object sender, EventArgs e)
        {


           var files = _service.ShowPreview();

           previewList.DisplayMember = "Value";
           previewList.DataSource = files.ToList();
        }


       



        private void selectFolder_Click(object sender, EventArgs e)
        {
           



            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                inputPath.Text = folderBrowserDialog1.SelectedPath;
            }

            var files = _service.PopulateList(inputPath.Text);

           

            fileList.DisplayMember = "FilePath";
            fileList.DataSource = files.ToList();


        }

       
        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _service.RestoreOriginalPath();

            MessageBox.Show("Job Completed");
        }

        private void saveChanges_Click(object sender, EventArgs e)
        {
            _service.SaveOriginalPaths();
            _service.SaveChanges();

            previewList.DataSource = null;

            MessageBox.Show("Job Completed");
        }
    }
}
