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
        private List<string> _list;
        private IEnumerable<KeyValuePair<string, string>> _kvp;

        public Renamer(IEnumerable<string> list)
        {
            this._list = list.ToList();

        }


        public IEnumerable<string> DisplayPaths()
        {
            return this._list;

        }


        //public IEnumerable<KeyValuePair<string, string>> PreviewChanges(List<IndexItem> indexList)
        //{
        //    _kvp = this._list.PathIncludes(@"\Season")
        //                .PathExcludes(@"\metadata")
        //                .PathContainsIndex(indexList)
        //                .WithNewIndexPattern();

        //    return _kvp;
        //}


        public IEnumerable<KeyValuePair<string, string>> PreviewChanges(List<IndexItem> indexList)
        {
            _kvp = this._list.PathIncludes(@"\Season")
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


    }
}
