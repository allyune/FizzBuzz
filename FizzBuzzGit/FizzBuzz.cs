using System;
namespace FizzBuzzGit
{
	public class FizzBuzz
	{

        private static Dictionary<int, string> conditions = new Dictionary<int, string>()
        {
            {3, "Fizz"},
            {5, "Buzz"},
            {7, "Whizz"},
            {11, "Bang"}
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

