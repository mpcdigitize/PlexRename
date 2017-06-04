using PlexRename.BL.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlexRename.BL
{
    public class Renamer
    {
      
        private IEnumerable<KeyValuePair<string, string>> _kvp;

        public IEnumerable<KeyValuePair<string, string>> PreviewChanges(IEnumerable<string> list,List<IndexItem> indexList)
        {

           
            _kvp = list.PathIncludes(@"\Season")
                        .PathExclude(@"\metadata")
                        .PathContainsIndex(indexList)
                        .WithNewIndexPattern();

            return _kvp;
        }


        public Memento SaveMemento()
        {

            return new Memento(this._kvp);
        }


        public IEnumerable<KeyValuePair<string, string>> RestoreMemento(Memento memento)
        {

            return this._kvp = memento.KVP.Select(p => new KeyValuePair<string, string>(p.Value, p.Key));

        }


        public IEnumerable<KeyValuePair<string, string>> GetKeyValuePair()
        {

            return this._kvp;
        }


    }
}
