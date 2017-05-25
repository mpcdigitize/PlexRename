using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlexRename.BL
{
    public class MementoCaretaker
    {

        private Memento _memento;

        public Memento Memento
        {
            get { return _memento; }
            set { _memento = value; }

        }
    }
}
