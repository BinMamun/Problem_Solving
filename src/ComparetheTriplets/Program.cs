using System;
using System.Collections.Generic;
using System.Linq;

namespace compareTheTriplets
{
	class Program
	{
		static void Main(string[] args)
		{
			var a = Console.ReadLine().Split(' ')
				.Select(int.Parse).ToList();
			var b = Console.ReadLine().Split(' ')
				.Select(int.Parse).ToList();

			var result = compareTriplets(a, b);

			foreach (var r in result)
			{
				Console.Write(r);
				Console.Write(" ");
			}

			Console.ReadKey();
		}

		public static List<int> compareTriplets(List<int> a, List<int> b)
		{
			var result = new List<int>() { 0, 0 };
			var count = a.Count;

			for (int i = 0; i < count; i++)
			{
				if (a[i] > b[i])
				{
					result[0] += 1;
				}
				else if (a[i] < b[i])
				{
					result[1] += 1;
				}
			}

			return result;
		}
	}
}
