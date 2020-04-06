using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseBeginner1
{
    class Program
    {
        static void Main(string[] args)
        {
            Song song = new Song();

            song.Title = "Dark side of moon";
            song.Seconds = 500;
            song.Position = new ShelvePosition(0, 0);
            //song.Play();

            Song song2 = new Song();
            song2.Title = "Dark side of moon";
            song2.Seconds = 300;
            song2.Position = new ShelvePosition(1, 0);

            PlayList<Song> playListSong = new PlayList<Song>();

            List<int> list = new List<int>();
           

            playListSong.Add(song);
            playListSong.Add(song2);

            WriteLineSpecial(song, "Start with", "enjoy");

            Console.WriteLine(song2.ToString());

            Tuple<int, string, Song> tuple = new Tuple<int, string, Song>(0, "Hola", song);

            Console.ReadKey();
        }

        static void WriteLineSpecial<T>(T data, string prefix, string suffix)
        {
            Console.WriteLine("{0} {1} {2}",prefix,data,suffix);

        }
    }
}
