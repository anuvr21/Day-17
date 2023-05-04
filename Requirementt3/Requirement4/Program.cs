using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Requirement4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Song> ls = SongRepo.GetAllSongs();
            foreach (Song s in ls)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine();
            ls.Sort();
            Console.WriteLine("Sorted Song List on Name");
            foreach (Song s in ls)
                Console.WriteLine(s);
            Console.WriteLine();
            ls.Sort(new RatingComparer());
            Console.WriteLine("Sorted Song List on Rating");
            foreach (Song s in ls)
                Console.WriteLine(s);
        }
    }
}