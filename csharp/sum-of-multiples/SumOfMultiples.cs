using System;
using System.Collections.Generic;
using System.Linq;

public static class SumOfMultiples
{
    public static int Sum(IEnumerable<int> multiples, int max)
    {		
		IEnumerable<int> list = multiples.Where(x => x > 0);
		if (list.Count() == 0)
		{
			return 0;
		}

		List<int> numbers = new List<int>();
		int start = multiples.Min();

		for (var i = start; i < max; i++)
        {
            bool isMatch = false;
			isMatch = list.Any(x => x > 0 && i % x == 0);

			if (isMatch)
			{
				numbers.Add(i);
			}
        }

		return numbers.Sum();
    }
}