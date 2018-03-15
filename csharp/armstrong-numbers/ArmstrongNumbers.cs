using System;
using System.Linq;
using System.Collections.Generic;

public static class ArmstrongNumbers {

	static Stack<int> NumbersIn(int value)
	{
		if (value == 0) return new Stack<int>();

		var numbers = NumbersIn(value / 10);

		numbers.Push(value % 10);

		return numbers;
	}

    public static bool IsArmstrongNumber(int number)
    {
		string str = number.ToString();
		int len = str.Length;
		Stack<int> figures = NumbersIn(number);
		double sum = 0;

		foreach (int x in figures)
		{
			sum += Math.Pow(x, len);
		}

		return sum == number;
    }
}