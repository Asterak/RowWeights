using System;
using System.Linq;

namespace RowWeights
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(string.Join(" ", RowWeights(new int[] { 39, 84, 74, 18, 59, 72, 35, 61 }))); // "207 235"
        }

        public static int[] RowWeights(int[] a)
        {
            return new int[] { a.Where((x, i) => i % 2 == 0).Sum(), a.Where((x, i) => i % 2 != 0).Sum() };

            //int team1 = 0;
            //int team2 = 0;
            //for (int i = 0; i < a.Length; i++)
            //{
            //    if (i % 2 == 0) team1 += a[i];
            //    else team2 += a[i];
            //}
            //return new int[] { team1, team2 };


        }
        
        //return new int[] { a.Select((x, y) => y % 2 == 0 ? x : 0).Sum(), a.Select((x, y) => y % 2 == 0 ? 0 : x).Sum() };
    }
}
