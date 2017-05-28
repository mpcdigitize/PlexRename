using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlexRename.BL
{
    public static class IndexList
    {


        public static List<IndexItem> Indexes = new List<IndexItem>();


        

        public static void Display()
        {

            foreach (var item in Indexes)
            {
                Console.WriteLine("{0} {1} {2} {3}",
                    item.OriginalIndex,
                    item.SeasonNumber,
                    item.ReplaceWithIndex);

            }



        }

        /*	
                public IEnumerable<string> GetKeys()
                {
                    return pair.Keys;



                }
        */


        public static List<IndexItem> GenerateIndexList(int startYear, int endYear, int startInteger, int endInteger)
        {

            GenerateIndexesForIntegers(startInteger, endInteger);
            GenerateIndexesForYears(startYear, endYear, startInteger, endInteger);


            return Indexes;
        }




        private static void GenerateIndexesForIntegers(int startInteger, int endInteger)
        {

            for (int x = startInteger; x < endInteger; x++)
            {
                for (int y = startInteger; y < endInteger; y++)
                {
                    IndexItem indexItem = new IndexItem();

                    indexItem.SeasonNumber = y.ToString("D2");
                    indexItem.OriginalIndex = y.ToString("D2") + "x" + x.ToString("D2");
                    indexItem.ReplaceWithIndex = "S" + y.ToString("D2") + "E" + x.ToString("D2");

                    Indexes.Add(indexItem);
                }



            }


        }





        private static void GenerateIndexesForYears(int startYear, int endYear, int startInteger, int endInteger)
        {

            for (int x = startInteger; x < endInteger; x++)
            {
                for (int y = startYear; y <= endYear; y++)
                {
                    IndexItem indexItem = new IndexItem();

                    indexItem.SeasonNumber = y.ToString("D2");
                    indexItem.OriginalIndex = y.ToString("D2") + "x" + x.ToString("D2");
                    indexItem.ReplaceWithIndex = "S" + y.ToString("D2") + "E" + x.ToString("D2");

                    Indexes.Add(indexItem);
                }




            }


        }

        public static List<IndexItem> GetList()
        {
            return Indexes;

        }


        

    }
}
