using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Requirementt3
{
    class Song
    {
        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        private string _artist;
        public string Artist
        {
            get { return _artist; }
            set { _artist = value; }
        }
        private string _songType;
        public string SongType
        {
            get { return _songType; }
            set { _songType = value; }
        }
        private double _rating;
        public double Rating
        {
            get { return _rating; }
            set { _rating = value; }
        }
        private int _numberOfDownloads;
        public int NumberOfDownloads
        {
            get { return _numberOfDownloads; }
            set { _numberOfDownloads = value; }
        }
        private DateTime _dateDownloaded;
        public DateTime DateDownloaded
        {
            get { return _dateDownloaded; }
            set { _dateDownloaded = value; }
        }
        public Song()
        {

        }
        public Song(string _name, string _artist, string _songType, double _rating, int _numberOfDownloads, DateTime _dateDownloaded)
        {
            Name = _name;
            Artist = _artist;
            SongType = _songType;
            Rating = _rating;
            NumberOfDownloads = _numberOfDownloads;
            DateDownloaded = _dateDownloaded;
        }
        public static Dictionary<string, int> CalculateTypeCount(List<Song> list)
        {
            Dictionary<string, int> c = new Dictionary<string, int>();
            foreach (Song songs in list)
            {
                if (c.ContainsKey(songs.SongType))
                    c[songs.SongType]++;
                else
                    c[songs.SongType] = 1;
            }
            Console.WriteLine("SongType \tCount");
            foreach (KeyValuePair<string, int> kvp in c)
            {
                Console.WriteLine("{0}\t {1}", kvp.Key, kvp.Value);
            }
            return c;
        }
        public static string PredictState(Dictionary<string, int> perTypeCount)
        {
            int celebrationCount = perTypeCount.ContainsKey("Celebration") ? perTypeCount["Celebration"] : 0;
            int emotionalCount = perTypeCount.ContainsKey("Emotional") ? perTypeCount["Emotional"] : 0;
            int motivationalCount = perTypeCount.ContainsKey("Motivational") ? perTypeCount["Motivational"] : 0;
            if (celebrationCount > emotionalCount && celebrationCount > motivationalCount)
            {
                return ("user is feeling happy");
            }
            else if (emotionalCount > celebrationCount && emotionalCount > motivationalCount)
            {
                return ("user is feeling depressed");
            }
            else
            {
                return ("user is feeling energetic");
            }
        }
    }

}
