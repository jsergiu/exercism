using System;
using System.Collections.Generic;

public class NucleotideCount
{
	private Dictionary<char, int> nucleotideCounts = new Dictionary<char, int>
	{
		['A'] = 0,
		['C'] = 0,
		['G'] = 0,
		['T'] = 0
	};

	public NucleotideCount(string sequence)
    {
		foreach (char c in sequence)
		{
			if (!nucleotideCounts.ContainsKey(c))
			{
				throw new InvalidNucleotideException();
			}

			nucleotideCounts[c]++;
		}
    }

    public IDictionary<char, int> NucleotideCounts
    {
        get
        {
			return nucleotideCounts;
		}
    }
}

public class InvalidNucleotideException : Exception { }
