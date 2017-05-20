using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PlexRename;
using System.IO;

namespace PlexRename.BL.Extensions
{
    public static class StringExtensions
    {


        public static string RenamePattern(this MediaItem m)
        {
            return m.SeriesName + " - S" +
                                           m.SeasonNumber + "E" +
                                           m.EpisodeNumber + " - " +
                                           m.FileNameWithoutIndex;

        }


        public static bool PathContainsIndex(this string filePath, Dictionary<string, IndexItem> dict)
        {

            var _path = filePath;

            foreach (var key in dict.Keys)
            {
                if (_path.Contains(key))
                {
                    return true;
                }
                else
                {

                }
            }


            return false;


        }


        public static string GetSeriesNameFromFilePath(this string filePath)
        {


            return Path.GetFileName(
                    Path.GetDirectoryName(
                    Path.GetDirectoryName(filePath)));

        }


    }
}