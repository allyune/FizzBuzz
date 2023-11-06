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
    [TestCase(81, "81")]
    [TestCase(7, "Whizz")]
    [TestCase(11, "Bang")]
    public void FizzBuzzTest(int num, string expectedResult)
    {
        string realResult = FizzBuzz.GenerateFizzBuzz(num);
        Assert.That(realResult, Is.EqualTo(expectedResult));
    }
}