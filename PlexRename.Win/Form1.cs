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
      //  Dictionary<string, IndexItem> dict = new IndexDictionary().GenerateKeyValuePairs(1980, 2016, 0, 50);

        public Form1()
        {
            
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // string path = @"\\TOWER\Media\Video\TV\Colony";
           // IndexList.GenerateIndexList(0, 0, 0, 50);



            // var repository = new Repository();
            // var files = repository.ScanFolder(path, "*");

            // //  var tt = path.ContainsEpisodeIndex();


            // var list = files.PathContains(@"\Season").GetFilesWithIndex(dict);
            //var list2 = list.GetIndexFromFile();

            // var localFiles = new LocalFiles(list2);

            // var res = localFiles.PopulateMediaItem(dict);

            // //var r2 = res.Preview ();
            // var r3 = res.FilesToProcess().Preview();
            // res.FilesToProcess().RenameFiles();

            // fileList.DataSource = list.ToList();


            //foreach (var file in r3)
            //{

            //    Console.WriteLine(file);


            //}


        }

        private void Preview_Click(object sender, EventArgs e)
        {

        //    var indexList = new IndexList().GetList();
        //var repository = new Repository().GetFiles(inputPath.Text, "*");

        //    var renamer = new Renamer(repository);

        //    //  var files = renamer.PreviewChanges(indexList);
        //    var files = renamer.PreviewChanges(indexList);

        //    previewList.DisplayMember = "Value";
        //    previewList.DataSource = files.ToList();
        }

        private void selectFolder_Click(object sender, EventArgs e)
        {
            //var facade = new Facade();

           

         //   if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
         //   {
         //       inputPath.Text = folderBrowserDialog1.SelectedPath;
         //   }

         //   //var result = facade.GetFilePaths(inputPath.Text, dict);
         //   // fileList.DataSource = result.ToList();


         //   var repository = new Repository().GetFiles(inputPath.Text, "*");
         //   LocalFiles.LocalFileList = repository;
         //   var files = LocalFiles.LocalFileList;

         ////  var renamer = new Renamer(repository);

         // //  var files = renamer.PreviewChanges(indexList);
         //  // var files = repository.Display();
         //   // .WithNewIndexPattern();


         //   fileList.DisplayMember = "FilePath";
         //   fileList.DataSource = files.ToList();


        }
    }
}
