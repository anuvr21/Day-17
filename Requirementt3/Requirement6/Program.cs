using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Requirementt3
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Song> songs = SongRepo.GetSongs();
            Dictionary<string, int> c = Song.CalculateTypeCount(songs);
            string s = Song.PredictState(c);
            Console.WriteLine(s);
        }
    }
}