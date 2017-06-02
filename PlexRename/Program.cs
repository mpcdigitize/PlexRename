using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PlexRename.BL.Extensions;


namespace PlexRename.BL
{
    class Program
    {
        static void Main(string[] args)
        {

            string path =@"\\TOWER\Media\Video\TV\Colony";


            ApplicationServiceLayer service = new ApplicationServiceLayer();

            var files = service.PopulateList(path);

            //var indexList =  new IndexList().GenerateIndexList(0, 0, 0, 50);

            //var repository = new Repository().GetFiles(path,"*");
            
            //var renamer = new Renamer(repository);

            //var files = renamer.PreviewChanges(indexList);

            //var caretaker = new MementoCaretaker();
            //caretaker.Memento = renamer.SaveMemento();
            //var result = renamer.RestoreMemento(caretaker.Memento);


            //var allfiles = renamer.DisplayPaths();

            //files.WithNewIndexPattern();




            // var facade = new Facade();
            //    var list = files.PathContains(@"\Season").PathExclude(@"\metadata\").GetFilesWithIndex(dict);
            //    var list2 = list.GetIndexFromFile();

            //    var localFiles = new LocalFiles(list2);

            //    var res = localFiles.PopulateMediaItem(dict);

            //    var r3 = res.FilesToProcess().Preview();
            ////    res.FilesToProcess().RenameFiles();

            //foreach (var file in files)
            //{

            //    Console.WriteLine(file.Value);


            //}

            //foreach (var file in result)
            //{

            //    Console.WriteLine(file.Value);


            //}

            //foreach (var file in allfiles)
            //{

            //    Console.WriteLine(file);


            //}




            Console.WriteLine("Done");
            Console.Read();
        }
    }
}
