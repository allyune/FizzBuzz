using System;
namespace FizzBuzzGit

    public class FizzBuzz
    {
        private readonly FizzBuzzParameters _parameters;
        private readonly Dictionary<int, string> _conditions;

        public FizzBuzz(FizzBuzzParameters parameters)
        {
            _parameters = parameters;
            _conditions = new Dictionary<int, string>()
            {
                { 3, _parameters.divisibleByThreeStr },
                { 5, _parameters.divisibleByFiveStr },
                { 7, _parameters.divisibleBySevenStr },
                { 11, _parameters.divisibleByElevenStr }
            };
        }
      
        public string GenerateFizzBuzz(int num)
        {
            var result = _conditions
                .Where(cond => num % cond.Key == 0)
                .Select(cond => cond.Value)
                .ToArray();
            if (result.Length == 0)
                return num.ToString();
            return String.Join("", result);
        }

        public void PrintFizzBuzz()
		{
			for (int i = 1; i <= 100; i++)
			{
				Console.WriteLine(GenerateFizzBuzz(i));
			}
		}
	}
}

