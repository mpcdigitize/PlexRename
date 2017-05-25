using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlexRename.BL
{
    public class Memento
    {

        private IEnumerable<KeyValuePair<string, string>> _kvp;

        public Memento(IEnumerable<KeyValuePair<string, string>> kvp)
        {

            this._kvp = kvp;
        }


        public IEnumerable<KeyValuePair<string, string>> KVP
        {
            get { return _kvp; }
            set { _kvp = value; }

        }
    }
}
