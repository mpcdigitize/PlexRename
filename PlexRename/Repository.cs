using System;
using System.Collections.Generic;
using System.IO;

using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PlexRename.Extensions;

namespace PlexRename
{
    public class Repository
    {
        private List<FileInfo> filess = new List<FileInfo>();
        private List<DirectoryInfo> folders = new List<DirectoryInfo>();



        /// <summary>
        /// Gets string file paths 
        /// </summary>
        /// <param name="path"></param>
        /// <param name="searchPattern"></param>
        /// <returns></returns>
        public IEnumerable<string> ScanFolder(string path, string searchPattern)
        {
   
            List<string> files = new List<string>();


            try
            {
                files =  Directory.GetFiles(path, "*", SearchOption.AllDirectories).ToList();

        
            }

            catch (Exception e)
            {
                Console.WriteLine("An error occurred: '{0}'", e.Message);
            }

            return files;
           

            }






    }
}
