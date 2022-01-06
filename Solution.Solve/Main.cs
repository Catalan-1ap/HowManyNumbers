using System;
using System.Collections.Generic;
using System.Linq;


namespace Solution.Solve
{
	public static class Main
	{
		public static List<long> FindAll(int sumDigits, int numDigits)
		{
			// The best option would be to use Combinatorics Nuget
			// i.e. https://github.com/eoincampbell/combinatorics
			var combs = CombinationsWithRepetetition(Enumerable.Range(1, 9).ToList(), numDigits);

			long count = 0, min = long.MaxValue, max = long.MinValue;

			foreach (var combination in combs)
			{
				var sum = combination.Sum();

				if (sum != sumDigits)
					continue;

				count++;

				long number = GetNumberFromDigits(combination, numDigits);
				min = min > number ? number : min;
				max = max < number ? number : max;
			}

			return count != 0
					   ? new List<long>()
					   {
						   count, min, max
					   }
					   : new List<long>();
		}


		private static long GetNumberFromDigits(IEnumerable<int> digits, int digitsCount)
		{
			long sum = 0L;
			int i = 0;

			foreach (var t in digits)
			{
				sum += t * (long)Math.Pow(10, digitsCount - i++ - 1);
			}

			return sum;
		}


		private static List<List<int>> CombinationsWithRepetetition(List<int> variants, int length)
		{
			var combinations = new List<List<int>>();
 
			if (length == 0)
			{
				var emptyCombination = new List<int>();
				combinations.Add(emptyCombination);
 
				return combinations;
			}
 
			if (variants.Count == 0)
			{
				return combinations;
			}
 
			int head = variants[0];
			var copiedCombinationList = new List<int>(variants);
 
			List<List<int>> subcombinations = CombinationsWithRepetetition(copiedCombinationList, length - 1);
 
			foreach (var subcombination in subcombinations)
			{
				subcombination.Insert(0, head);
				combinations.Add(subcombination);
			}
 
			variants.RemoveAt(0);
			combinations.AddRange(CombinationsWithRepetetition(variants, length));
 
			return combinations;
		}
	}
}