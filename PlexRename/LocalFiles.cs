using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PlexRename.BL.Extensions;
using System.IO;

namespace PlexRename.BL
{
    public class LocalFiles
    {
        private List<LocalFile> _list;

        public LocalFiles(IEnumerable<LocalFile> list)
        {
            this._list = list.ToList();

        }


        public IEnumerable<MediaItem> PopulateMediaItem(Dictionary<string, IndexItem> dict)
        {

            var mediaItems = this._list.Join(dict,
                                   l => l.Key,
                                   d => d.Key,
                                         (l, d) => new MediaItem()
                                         {
                                             FilePath = l.FilePath,
                                             EpisodeNumber = d.Value.EpisodeNumber,
                                             SeasonNumber = d.Value.SeasonNumber,
                                             FileNameWithoutIndex = l.FileNameWithoutIndex,
                                             SeriesName = l.SeriesName,
                                             SeriesPath = l.SeriesPath

                                         });


            return mediaItems;

        }




    }
}
