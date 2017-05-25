using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PlexRename.BL.Extensions;

namespace PlexRename.BL
{
    /// <summary>
    /// Information for Dictionary Value
    /// </summary>
    public class IndexItem
    {
        public string OriginalIndex { get; set; }
        public string SeasonNumber { get; set; }
        public string ReplaceWithIndex { get; set; }

    }
}
