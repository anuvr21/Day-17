using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Requirementt3
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Songs> songs = SongRepo.GetSongs();
            Songs s = new Songs();
            SongBO sbo = new SongBO();
            // Print the details of each song to the console
            Console.WriteLine("Name\t\tArtist\t SongType\t Rating\t NumberofDownloads\t DateDownloaded");
            foreach (Songs song in songs)
            {
                Console.WriteLine(song);
            }
            //search
            int ch;
            do
            {
                Console.WriteLine();
                Console.WriteLine("Enter your choice :");
                Console.WriteLine("1: Song Type\n 2: Date of download \n 3: Rating \n 4: Exit");
                ch = int.Parse(Console.ReadLine());
                switch (ch)
                {
                    case 1:
                        Console.WriteLine();
                        Console.WriteLine("Enter Song Type");
                        Console.WriteLine();
                        s.SongType = Console.ReadLine();
                        Console.WriteLine("-----------------------");
                        List<Songs> _songs = SongBO.FindSong(songs, s.SongType);
                        foreach (Songs song in _songs)
                        {
                            Console.WriteLine(song);
                        }
                        Console.WriteLine("-----------------------");
                        Console.WriteLine();
                        break;
                    case 2:
                        Console.WriteLine("Enter date");
                        Console.WriteLine();
                        s.DateDownloaded = DateTime.Parse(Console.ReadLine());
                        List<Songs> _songs2 = sbo.FindSong(songs, s.DateDownloaded);
                        Console.WriteLine("-----------------------");
                        foreach (Songs song in _songs2)
                        {
                            Console.WriteLine(song);
                        }
                        Console.WriteLine("-----------------------");
                        Console.WriteLine();
                        break;
                    case 3:
                        Console.WriteLine();
                        Console.WriteLine("Enter rating");
                        s.Rating = double.Parse(Console.ReadLine());
                        List<Songs> _songs3 = sbo.FindSong(songs, s.Rating);
                        Console.WriteLine("-----------------------");
                        foreach (Songs song in _songs3)
                        {
                            Console.WriteLine(song);
                        }
                        Console.WriteLine("-----------------------");
                        Console.WriteLine();
                        break;
                }
            }
            while (ch != 0);
            Console.ReadKey();
        }
    }
}