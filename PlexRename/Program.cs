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
            var dict = new IndexDictionary().GenerateKeyValuePairs(1980, 2016, 0, 50);



            var repository = new Repository();
            var files = repository.GetFiles(path, "*")
                        .PathIncludes(@"\Season")
                        .PathExclude(@"\metadata")
                        .PathContainsIndex(dict)
                        .WithNewIndexPattern();

            //files.WithNewIndexPattern();
                     


           
           // var facade = new Facade();
        //    var list = files.PathContains(@"\Season").PathExclude(@"\metadata\").GetFilesWithIndex(dict);
        //    var list2 = list.GetIndexFromFile();

        //    var localFiles = new LocalFiles(list2);

        //    var res = localFiles.PopulateMediaItem(dict);

        //    var r3 = res.FilesToProcess().Preview();
        ////    res.FilesToProcess().RenameFiles();

            foreach (var file in files)
            {

                Console.WriteLine(file.Value);


            }




            Console.WriteLine("Done");
            Console.Read();
        }
    }
}
