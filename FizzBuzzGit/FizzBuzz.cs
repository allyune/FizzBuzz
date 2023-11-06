using System;
namespace FizzBuzzGit
{
	public class FizzBuzz
	{
		public static string GenerateFizzBuzz(int num)
		{
			string res = String.Empty;
			if (num % 3 == 0)
				res += "Fizz";
			if (num % 5 == 0)
				res += "Buzz";
			if (res.Length == 0)
			{
				return num.ToString();
			}
			return res;
		}

		public static void PrintFizzBuzz()
		{
			for (int i = 1; i <= 100; i++)
			{
				Console.WriteLine(FizzBuzz.GenerateFizzBuzz(i));
			}
		}
	}
}

