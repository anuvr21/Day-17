using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Requirementt3
{
    public class SongRepo
    {
        public static List<Songs> songs = new List<Songs>
    {
      new Songs{Name="Shape of you",Artist="Ed Sheeran",SongType="Pop",Rating=4.8,NumberofDownloads=100000,DateDownloaded=DateTime.Parse("12-01-2018")},
      new Songs{Name="Perfect",Artist="Ed Sheeran",SongType="Pop",Rating=4.5,NumberofDownloads=12000,DateDownloaded=DateTime.Parse("04-05-2016")},
      new Songs{Name="Something ",Artist="Coldplay",SongType="Melody",Rating=4.5,NumberofDownloads=105421,DateDownloaded=DateTime.Parse("05-07-1997")},
      new Songs{Name="Mercy AAA",Artist="Shawn Mendes",SongType="Jazz",Rating=4.8,NumberofDownloads=214500,DateDownloaded=DateTime.Parse("04-05-2016")}
    };
        public static List<Songs> GetSongs()
        {
            return songs;
        }
    }
}