using System;
using System.Collections.Generic;
using System.Linq;

namespace VeryBigSum
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var arr = Console.ReadLine().Trim().Split(' ').Select(long.Parse).ToList();
                
            Console.WriteLine(AVeryBigSum(arr));
        }

        public static long AVeryBigSum(List<long> ar)
        {
            return ar.Sum();
        }
    }
}
