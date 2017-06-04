using PlexRename.BL;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlexRename
{
    public class ApplicationServiceLayer
    {
        private MementoCaretaker mementoCaretaker = new MementoCaretaker();
        private IndexList indexList = new IndexList(2016, 2016, 0, 50);
        private Repository repository = new Repository();
        private Renamer renamer = new Renamer();

        public IEnumerable<string> PopulateList(string path)
        {

           repository.GetFiles(path, "*");
           var dbList = repository.GetPathList();

            return dbList;

            


        }


        public IEnumerable<KeyValuePair<string, string>> ShowPreview()
        {
            var dbList = repository.GetPathList();
            var indexes = indexList.GetIndexes();
            var list = renamer.PreviewChanges(dbList, indexes);


            return list;

        

        }

        public void SaveChanges()
        {
           var list = renamer.GetKeyValuePair();

            foreach (var item in list)
            {
                if (File.Exists(item.Key))
                    {

                        File.Move(item.Key, item.Value);
                    };
                
    
            }

        }


        public void SaveOriginalPaths()
        {
            var dbList = repository.GetPathList();
            mementoCaretaker.Memento = renamer.SaveMemento();

            var list = mementoCaretaker.Memento;

            //foreach (var item in list.KVP)
            //{
            //    Console.WriteLine("Memento :" + item.Key + " = " + item.Value);

            //}

        }


        public void RestoreOriginalPath()
        {

            var list = renamer.RestoreMemento(mementoCaretaker.Memento);


            foreach (var item in list)
            {
                if (File.Exists(item.Key))
                {

                    File.Move(item.Key, item.Value);
                };

            }
            //foreach (var item in list)
            //{
            //    Console.WriteLine("Restore: " + item.Key + " = " + item.Value);

            //}
        }






    }
}
