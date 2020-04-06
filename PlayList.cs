using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseBeginner1
{
    public class PlayList <T>
    {
        //T[] mediaList = new T[] { };

        //ArrayList list = new ArrayList();

        List<T> listMedia = new List<T>();

        public void Add(T media)
        {
            listMedia.Add(media);

        }

        public void PlayAll()
        {
            foreach(T media in listMedia)
            {
                Console.WriteLine(media);
            }
        }
    }
}
