using System;
using System.Text.RegularExpressions;

public static class Bob {

    private static bool IsShouting(string input)
    {
        bool hasCaps = false;

        for (int i = 0; i < input.Length; i++)
        {
            if (input[i] >= 'A' && input[i] <= 'Z')
            {
                hasCaps = true;                
            }

            if (input[i] >= 'a' && input[i] <= 'z')
            {
                return false;
            }
        }

        return hasCaps;
    }

    private static bool IsQuestion(string input)
    {
        return input[input.Length - 1] == '?';
    }

    public static string Response(string statement)
    {
        string prop = Regex.Replace(statement, @"\t|\n|\r", "");
        prop = prop.Trim();
        Console.WriteLine(prop);

        if (prop.Length == 0)
        {
            return "Fine. Be that way!";
        }

        bool isQuestion = Bob.IsQuestion(prop);
        bool isShouting = Bob.IsShouting(prop);

        if (isShouting && isQuestion)
        {
            return "Calm down, I know what I'm doing!";
        }

        if (isShouting)
        {
            return "Whoa, chill out!";
        }

        if (isQuestion)
        {
            return "Sure.";
        }

        return "Whatever.";
    }
}