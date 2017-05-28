using System;
using System.Collections.Generic;
using System.IO;

using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PlexRename.BL.Extensions;

namespace PlexRename.BL
{
    public class Repository
    {
        private List<string> _files; 
      //  private static List<DirectoryInfo> folders = new List<DirectoryInfo>();



        /// <summary>
        /// Gets string file path 
        /// </summary>
        /// <param name="path"></param>
        /// <param name="searchPattern"></param>
        /// <returns></returns>
        public IEnumerable<string> GetFiles(string path, string searchPattern)
        {
   
            this._files = new List<string>();


            try
            {
                _files =  Directory.GetFiles(path, "*", SearchOption.AllDirectories).ToList();

        
            }

            catch (Exception e)
            {
                Console.WriteLine("An error occurred: '{0}'", e.Message);
            }

            return _files;
           

            }



        public IEnumerable<string> Display()
        {

            return this._files;
        }





    }
}
