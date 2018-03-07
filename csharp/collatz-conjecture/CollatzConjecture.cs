using System;

public static class CollatzConjecture
{
    public static int Steps(int number)
    {
		if (number < 1)
		{
			throw new ArgumentException();
		}

		int steps = 0;
		int value = number;

		while (value > 1)
		{
			if (value % 2 == 0)
			{
				value = value / 2;
			}
			else
			{
				value = value * 3 + 1;
			}
			steps++;
		}

		return steps;
    }
}