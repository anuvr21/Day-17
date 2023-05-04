using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Requirementt3
{
    public class SongBO
    {
        public static List<Songs>FindSong(List<Songs> songList, string type)
        {
            return songList.Where(song => song.SongType == type).ToList();
        }
        public List<Songs>FindSong(List<Songs> SongList, DateTime dateCreated)
        {
            return SongList.Where(song => song.DateDownloaded == dateCreated).ToList();
        }
        public List<Songs>FindSong(List<Songs> SongList, double rating)
        {
            return SongList.Where(song => song.Rating == rating).ToList();
        }
    }
}

