using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseBeginner1
{
    public class PlayList <T>
    {
        T[] mediaList = new T[] { };
        public void Add(T media)
        {

        }

        public void PlayAll()
        {
            foreach(T media in mediaList)
            {
                Console.WriteLine(T);
            }
        }
    }
}
