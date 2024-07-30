public static class TwistedFizzBuzz
{
	public static (int firstNumber, int secondNumber) getRange(string numberRange)
	{
		if (numberRange.Split("-").Length == 2)
		{
			firstNumber = int.Parse(numberRange.Split("-")[0]) < int.Parse(numberRange.Split("-")[1]) ? int.Parse(numberRange.Split("-")[0]) : int.Parse(numberRange.Split("-")[1]);
			secondNumber = int.Parse(numberRange.Split("-")[0]) > int.Parse(numberRange.Split("-")[1]) ? int.Parse(numberRange.Split("-")[0]) : int.Parse(numberRange.Split("-")[1]);
			return (firstNumber, secondNumber);
		}
		Regex regex = new Regex("-?\\d+", RegexOptions.IgnoreCase);
		if (regex.IsMatch(numberRange))
		{
			firstNumber = int.Parse(regex.Matches(numberRange)[0].Value) < int.Parse(regex.Matches(numberRange)[1].Value) ? int.Parse(regex.Matches(numberRange)[0].Value) : int.Parse(regex.Matches(numberRange)[1].Value);
			secondNumber = int.Parse(regex.Matches(numberRange)[0].Value) > int.Parse(regex.Matches(numberRange)[1].Value) ? int.Parse(regex.Matches(numberRange)[0].Value) : int.Parse(regex.Matches(numberRange)[1].Value);
			return (firstNumber, secondNumber);
		}
		else
		{
			Console.WriteLine("input is invalid");
			Environment.Exit(0);
			return (0, 0);
		}

	}
	public static string testDivisors(int number, Dictionary<string, int> dict)
	{
		string resStr = "";
		foreach (KeyValuePair<string, int> entry in dict)
		{
			if (number % entry.Value == 0)
			{
				resStr += entry.Key;
			}
		}
		if (string.IsNullOrEmpty(resStr))
		{
			return number.ToString();
		}
		return resStr;
	}
	void createFizzBuzz(int initial, int final, Dictionary<string, int> dict = null)
	{
		if (dict == null)
		{
			dict = new Dictionary<string, int>() { { "Fizz", 3 }, { "Buzz", 5 } };
		}
		Console.WriteLine($"Range : {initial} - {final}");
		for (int i = initial; i <= final; i++)
		{
			Console.WriteLine(testDivisors(i, dict));
		}

	}
	public static Dictionary<string, int> GetUserDivisorsAndStrs()
	{
		Dictionary<string, int> dict = new();
		Console.WriteLine("Input the divisors separeted by space");
		string divisors = Console.ReadLine();
		Console.WriteLine("Input the strings separeted by space");
		string strings = Console.ReadLine();
		if (divisors.Split(" ").Length != strings.Split(" ").Length)
		{
			Console.WriteLine("different number of divisors and strings");
			Environment.Exit(0);
		}
		else
		{
			for (int i = 0; i < divisors.Split(" ").Length; i++)
			{
				dict.Add(strings.Split(" ")[i], int.Parse(divisors.Split(" ")[i]));
			}
		}
		return dict;
	}
}