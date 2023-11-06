using FizzBuzzGit;

namespace FizzBuzzGitTest;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [TestCase(3, "Fizz")]
    [TestCase(5, "Buzz")]
    [TestCase(15, "FizzBuzz")]
    [TestCase(83, "83")]
    [TestCase(7, "Whizz")]
    [TestCase(11, "Bang")]
    public void FizzBuzzTest(int num, string expectedResult)
    {
        FizzBuzzParameters parameters = new FizzBuzzParameters();
        FizzBuzz fizzBuzz = new FizzBuzz(parameters);
        string realResult = fizzBuzz.GenerateFizzBuzz(num);
        Assert.That(realResult, Is.EqualTo(expectedResult));
    }
}