using PlexRename.BL.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlexRename
{
    public class CleanUp
    {

        private IEnumerable<string> _list;

        public IEnumerable<string> PreviewCleanUp(IEnumerable<string> list)
        {


            this._list = list.PathIncludes(@"\metadata");

            return this._list;
          
        }


        public IEnumerable<string> GetList()
        {
            return this._list;

        }
    }
}
