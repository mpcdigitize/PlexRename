using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PlexRename.Extensions;


namespace PlexRename
{
    class Program
    {
        static void Main(string[] args)
        {

            string path =@"\\TOWER\Media\Video\TV\Colony";




            var repository = new Repository();
            var files = repository.ScanFolder(path,"*");

            //  var tt = path.ContainsEpisodeIndex();
            var dict = new IndexDictionary().GenerateKeyValuePairs(1980, 2016, 0, 50);
            var facade = new Facade();
            var list = files.PathContains(@"\Season").GetFilesWithIndex(dict);
            var list2 = list.GetIndexFromFile();

            var localFiles = new LocalFiles(list2);

            var res = localFiles.PopulateMediaItem(dict);

            //var r2 = res.Preview ();
            var r3 = res.FilesToProcess().Preview();
            res.FilesToProcess().RenameFiles();

            foreach (var file in r3)
            {

                Console.WriteLine(file);

                /*	
                Console.WriteLine(file.FilePath + " "
                                  + file.SeasonNumber + " "
                                  + file.EpisodeNumber + " "
                                  + file.SeriesName); */
            }


            // string path = @"\\TOWER\Media\Video\TV\Colony";
            //string path = @"C:\Colony\Season 02";

            // var repository = new Repository();
            // var files = repository.ScanFolder(path, "*");

            // //  var tt = path.ContainsEpisodeIndex();
            // var dict = new IndexDictionary().GenerateKeyValuePairs(1980, 2016, 0, 50);
            // var facade = new Facade();
            //var list = files.PathContains(@"\Season").GetFilesWithIndex(dict);
            // var list2 = list.GetIndexFromFile();

            // // var list = files.PathContains(@"\Season").GetFilesWithIndex(dict);


            //// var localFiles = new LocalFiles(list);

            // //var matched = localFiles.PopulateMediaItem(list, dict);

            //// var result = facade.GetFilesWithIndex(list, dict);

            // foreach (var item in list2)
            // {
            //    // Console.WriteLine(item.FilePath + " " + item.SeasonNumber + " " + item.EpisodeNumber);
            //     Console.WriteLine(item.FilePath + " " + item.Key);
            // }

            //var localFiles = new LocalFiles(filtered);
            //var dict = new IndexDictionary().GenerateKeyValuePairs(1970,2016,0,50);
            //localFiles.PupulateMediaItem(dict);

            //int num;

            //num = 2;

            //  Console.WriteLine(num.ToString("D2"));

            // var files = repository.ScanFolder(path, "*");

            //var localList = new LocalFileList(files);

            //localList.FindInDictionary(dict);


            //foreach (var item in filtered)
            //{
            //    Console.WriteLine("{0}", item);

            //}

            //var fileList = new LocalFileList(files);

            //fileList.FindMatch();

            //var ext = fileList.GetExtensions();
            //fileList.GetSeriesName();
            //fileList.PopulateMediaItem();

            //var a = repository.Get(result);

            //foreach (var item in ext)
            //{
            //    var dc = fileList.FindEpisodeIndexer(item);
            //    repository.GetSeriesName(dc);
            //}




            //  var media = new MediaItemList(result);


            //foreach (var item in dc)
            //{
            //   Console.WriteLine("{0} {1} {2} {3}", item.FileName, item.FileNameWithoutExtension, item.FileExtension, item.FilePath);

            //}

            //  var dict = new IndexDictionary();
            //dict.GenerateIndexPairs();
            // dict.GetPairs ();


            Console.WriteLine("Done");
            Console.Read();
        }
    }
}
