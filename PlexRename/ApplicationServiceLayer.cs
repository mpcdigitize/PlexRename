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
        private IndexList indexList = new IndexList(2015, 2016, 1, 50);
        private Repository repository = new Repository();
        private Renamer renamer = new Renamer();
        private CleanUp cleanUp = new CleanUp(); 

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




        public IEnumerable<string> ShowCleanMeta()
        {
            var dbList = repository.GetPathList();
            var list = cleanUp.PreviewCleanUp(dbList);

            return list;
        }


        public void RunCleanUp ()
        {
            var list = cleanUp.GetList();

            foreach (var file in list)
            {
                if (File.Exists(file))
                {

                    File.Delete(file);
                }
            }

        }


        public void SaveChanges()
        {
           var list = renamer.GetKeyValuePair();

            foreach (var item in list)
            {
                if (File.Exists(item.Key))
                    {

                        File.Move(@""+ item.Key, @""+ item.Value);
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
