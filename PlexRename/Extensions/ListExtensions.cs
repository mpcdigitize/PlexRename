﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlexRename.BL.Extensions
{
    public static class ListExtensions
    {

        public static IEnumerable<string> PathContains(this IEnumerable<string> list, string value)
        {

            return list.Where(p => p.Contains(value)).Select(p => p);



        }

        public static IEnumerable<string> PathExclude(this IEnumerable<string> list, string value)
        {

            return list.Where(p => !p.Contains(value)).Select(p => p);



        }



        public static IEnumerable<string> GetFilesWithIndex(this IEnumerable<string> list, Dictionary<string, IndexItem> dict)
        {

            return list.Where(p => p.PathContainsIndex(dict));


        }


        public static IEnumerable<LocalFile> GetIndexFromFile(this IEnumerable<string> list)
        {

            var fileList = new List<LocalFile>();

            foreach (var item in list)
            {

                var file = new FileInfo(item);
                var fileName = file.Name;
                var filePath = file.FullName;

                int pos = fileName.IndexOf(" ");
                string _key = fileName.Substring(0, pos).Trim();

                fileList.Add(new LocalFile()
                {
                    FilePath = filePath,
                    Key = _key,
                    SeriesName = filePath.GetSeriesNameFromFilePath(),
                    FileNameWithoutIndex = fileName.Replace(_key, "").Trim(),
                    SeriesPath = filePath.GetSeriesPath()
                });


            }

            return fileList;
        }





        public static IEnumerable<string> Preview(this IEnumerable<KeyValuePair<string, string>> kvp)
        {
            return kvp.Select(m => m.Value);




        }


        public static void RenameFiles(this IEnumerable<KeyValuePair<string, string>> kvp)
        {

            foreach (var item in kvp)
            {
                Console.WriteLine(item.Key + " " + item.Value);

            }

        }


        public static IEnumerable<KeyValuePair<string, string>> FilesToProcess(this IEnumerable<MediaItem> mediaItems)
        {
            return mediaItems.Select(m => new KeyValuePair<string, string>
                                        (m.FilePath,m.SeriesPath + @"\Season " + m.SeasonNumber + @"\" + m.SeriesName + " - S" +
                                               m.SeasonNumber + "E" +
                                               m.EpisodeNumber + " - " +
                                               m.FileNameWithoutIndex));

        }




        //public static IEnumerable<string> PreviewChanges(this IEnumerable<string> files, Dictionary<string, IndexItem> dict)
        //{
        //   // var repository = new Repository();
        //    //var files = repository.ScanFolder(@"" + path, "*");
        //    //var listOfPaths = files.PathContains(@"\Season").PathExclude(@"\metadata\").GetFilesWithIndex(dict);

        //    var listFiles = files.GetIndexFromFile();
        //    var localFiles = new LocalFiles(listFiles);

        //    var listOfMediaItem = localFiles.PopulateMediaItem(dict);

        //    //var r2 = res.Preview ();
        //    var result = listOfMediaItem.FilesToProcess().Preview();

        //    return result;
        //}



    }


}

