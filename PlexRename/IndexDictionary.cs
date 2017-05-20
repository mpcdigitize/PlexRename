using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PlexRename.Extensions;

namespace PlexRename
{
    public class IndexDictionary
    {
        private Dictionary<string, IndexItem> pair { get; set; }



        public IndexDictionary()
        {
            pair = new Dictionary<string, IndexItem>();

        }


        public void Display()
        {

            foreach (var item in pair)
            {
                Console.WriteLine("{0} {1} {2} {3}", item.Key, item.Value.SeasonNumber, item.Value.EpisodeNumber);

            }



        }


        public IEnumerable<string> GetKeys()
        {
            return pair.Keys;



        }



        public Dictionary<string, IndexItem> GenerateKeyValuePairs(int startYear, int endYear, int startInteger, int endInteger)
        {

            this.GenerateIndexesForIntegers(startInteger, endInteger);
            this.GenerateIndexesForYears(startYear, endYear, startInteger, endInteger);


            return pair;
        }




        private void GenerateIndexesForIntegers(int startInteger, int endInteger)
        {

            for (int x = startInteger; x < endInteger; x++)
            {
                for (int y = startInteger; y < endInteger; y++)
                {
                    IndexItem indexItem = new IndexItem();

                    indexItem.EpisodeNumber = x.ToString("D2");
                    indexItem.SeasonNumber = y.ToString("D2");
                    string key = y.ToString("D2") + "x" + x.ToString("D2");
                    pair.Add(key, indexItem);
                }



            }


        }





        private void GenerateIndexesForYears(int startYear, int endYear, int startInteger, int endInteger)
        {

            for (int x = startInteger; x < endInteger; x++)
            {
                for (int y = startYear; y <= endYear; y++)
                {
                    IndexItem indexItem = new IndexItem();



                    indexItem.EpisodeNumber = x.ToString("D2");
                    indexItem.SeasonNumber = y.ToString("D2");
                    string key = y.ToString("D2") + "x" + x.ToString("D2");
                    pair.Add(key, indexItem);
                }




            }


        }



    }
}
