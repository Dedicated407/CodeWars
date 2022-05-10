using NUnit.Framework;
namespace CodeWars._4kyu.CountingChangeCombinations;

[TestFixture]
public class Tests
{
    [Test]
    public static void SimpleCase()
    {
        Assert.AreEqual(3, Kata.CountCombinations(4, new[] { 1, 2 }));
    }
        
    [Test]
    public static void AnotherSimpleCase()
    {
        Assert.AreEqual(4, Kata.CountCombinations(10, new[] { 5, 2, 3 }));
    }
        
    [Test]
    public static void NoChange()
    {
        Assert.AreEqual(0, Kata.CountCombinations(11, new[] { 5, 7 }));
    }
}