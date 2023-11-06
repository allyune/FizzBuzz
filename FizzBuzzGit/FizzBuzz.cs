using System;
namespace FizzBuzzGit
{
	public class FizzBuzz
	{
        private static readonly string _divisibleByThreeStr = "Fizz";
        private static readonly string _divisibleByFiveStr = "Buzz";
        private static readonly string _divisibleBySevenStr = "Whizz";
        private static readonly string _divisibleByElevenStr = "Bang";

        private static Dictionary<int, string> conditions = new Dictionary<int, string>()
        {
            {3, _divisibleByThreeStr},
            {5, _divisibleByFiveStr},
            {7, _divisibleBySevenStr},
            {11, _divisibleByElevenStr}
        };

        public static string GenerateFizzBuzz(int num)
        {
            var result = conditions
                .Where(cond => num % cond.Key == 0)
                .Select(cond => cond.Value)
                .ToArray();
            if (result.Length == 0)
                return num.ToString();
            return String.Join("", result);
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

