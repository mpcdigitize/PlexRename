using PlexRename.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlexRename
{
    public class Facade
    {


        public IEnumerable<string> GetFilesFromFolder(string path)
        {
            var repository = new Repository();
            var files = repository.ScanFolder(path,"*");
            var result = files.PathContains(@"\Season");

            return result;
        }


        

    }
}
