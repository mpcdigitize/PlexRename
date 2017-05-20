using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlexRename.BL
{
    public class MediaItem
    {
        public string FilePath { get; set; }
        public string FileName { get; set; }
        public string FileExtension { get; set; }
        public string FileNameWithoutExtension { get; set; }
        public string SeriesName { get; set; }
        public string EpisodeIndex { get; set; }
        public string FileWithoutIndex { get; set; }
        public string ReplaceWithIndex { get; set; }
        public string EpisodeNumber { get; set; }
        public string SeasonNumber { get; set; }
        public string FileNameWithoutIndex { get; set; }
        public string ParentPath { get; set; }




    }
}
