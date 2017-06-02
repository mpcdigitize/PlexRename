using PlexRename.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlexRename
{
    public class ApplicationServiceLayer
    {
        public MementoCaretaker mementoCaretaker = new MementoCaretaker();
        public IndexList indexList = new IndexList(0, 0, 0, 50);
        public Repository repository = new Repository();
        public Renamer renamer = new Renamer();

        public IEnumerable<string> PopulateList(string path)
        {

           repository.GetFiles(path, "*");
           var dbList = repository.GetPathList();

            return dbList;

            //foreach (var item in dbList)
            //{
            //    Console.WriteLine("Populate: " + item);

            //}


        }


        public IEnumerable<KeyValuePair<string, string>> ShowPreview()
        {
            var dbList = repository.GetPathList();
            var indexes = indexList.GetIndexes();
            var list = renamer.PreviewChanges(dbList, indexes);


            return list;

            //foreach (var item in list)
            //{
            //    //Console.WriteLine(list.Count());
            //    Console.WriteLine("PreviewChanges :" + item.Key + " = " + item.Value);

            //}

        }


        public void SaveOriginalPaths()
        {
            var dbList = repository.GetPathList();
            mementoCaretaker.Memento = renamer.SaveMemento();

            var list = mementoCaretaker.Memento;

            foreach (var item in list.KVP)
            {
                Console.WriteLine("Memento :" + item.Key + " = " + item.Value);

            }

        }


        public void RestoreOriginalPath()
        {

            var list = renamer.RestoreMemento(mementoCaretaker.Memento);


            foreach (var item in list)
            {
                Console.WriteLine("Restore: " + item.Key + " = " + item.Value);

            }
        }






    }
}
