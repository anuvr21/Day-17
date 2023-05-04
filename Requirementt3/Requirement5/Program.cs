using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Requirement5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Song> list=new List<Song>();
            Console.WriteLine("Enter no of songs:");
            int n=int.Parse(Console.ReadLine());
            for(int i=0;i<n;i++)
            {
                string[] s = Console.ReadLine().Split(',');
                double r = double.Parse(s[3]);
                int nd = int.Parse(s[4]);
                DateTime dt= new DateTime();
                dt = DateTime.ParseExact(s[5], "dd-MM-yyyy", null);
                Song s1 = new Song(s[0], s[1], s[2],r,nd,dt);
                list.Add(s1);
            }
            SortedDictionary<string,int>sd = new SortedDictionary<string,int>();
            sd=Song.CalculateTypeCount(list);
            Console.WriteLine("{0} {1,15}","Song type","Count");
            foreach(var item in sd)
            {
                Console.WriteLine("{0} {1,15}", item.Key,item.Value);
            }

        }
    }
}
