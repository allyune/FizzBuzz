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
    public void FizzBuzzTest(int num, string expectedResult)
    {
        string realResult = FizzBuzz.GenerateFizzBuzz(num);
        Assert.That(realResult, Is.EqualTo(expectedResult));
    }
}