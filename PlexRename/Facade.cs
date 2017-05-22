using PlexRename.BL.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlexRename.BL
{
    public class Facade
    {


        public IEnumerable<string> GetFilePaths(string path, Dictionary<string, IndexItem> dict)
        {
            var repository = new Repository();
            var files = repository.ScanFolder(@""+ path,"*");
            var result = files.PathContains(@"\Season").PathExclude(@"\metadata\").GetFilesWithIndex(dict);

            return result;
        }



        public IEnumerable<string> PreviewChanges(string path, Dictionary<string, IndexItem> dict)
        {
            var repository = new Repository();
            var files = repository.ScanFolder(@"" + path, "*");
            var listOfPaths = files.PathContains(@"\Season").PathExclude(@"\metadata\").GetFilesWithIndex(dict);

            var listOfLocalFile = listOfPaths.GetIndexFromFile();
            var localFiles = new LocalFiles(listOfLocalFile);

            var listOfMediaItem = localFiles.PopulateMediaItem(dict);

         
            var result = listOfMediaItem.FilesToProcess().Preview();

            return result;
        }


        //public IEnumerable<UndoItem> CreateUndoItemList(string path, Dictionary<string, IndexItem> dict)
        //{
        //    var undoItem = new UndoItem();
        //    List<UndoItem> list = new List<UndoItem>();

        //    var repository = new Repository();
        //    var files = repository.ScanFolder(@"" + path, "*");
        //    var listOfPaths = files.PathContains(@"\Season").PathExclude(@"\metadata\").GetFilesWithIndex(dict);

        //    var listOfLocalFile = listOfPaths.GetIndexFromFile();
        //    var localFiles = new LocalFiles(listOfLocalFile);

        //    var listOfMediaItem = localFiles.PopulateMediaItem(dict);

        //    //var r2 = res.Preview ();
        //    var result = listOfMediaItem.FilesToProcess().Preview();


        //    undoItem.ChangedFrom = listOfPaths;
        //    return result;



        //}


    }
}
