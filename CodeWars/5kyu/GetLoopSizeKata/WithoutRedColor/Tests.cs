using NUnit.Framework;

namespace CodeWars._5kyu.GetLoopSizeKata.WithoutRedColor;

[TestFixture]
public class Tests
{
    [Test]
    public void FourNodesWithLoopSize3(){
        var n1 = new LoopDetector.Node();
        var n2 = new LoopDetector.Node();
        var n3 = new LoopDetector.Node();
        var n4 = new LoopDetector.Node();
        n1.Next = n2;
        n2.Next = n3;
        n3.Next = n4;
        n4.Next = n2;
        Assert.AreEqual(3,Kata.GetLoopSize(n1));
    }
  
    [Test]
    public void RandomChainNodesWithLoopSize30(){
        var n1 = LoopDetector.CreateChain(3,30);
        Assert.AreEqual(30,Kata.GetLoopSize(n1));
    }
  
    [Test]
    public void RandomLongChainNodesWithLoopSize1087(){
        var n1 = LoopDetector.CreateChain(3904,1087);
        Assert.AreEqual(1087,Kata.GetLoopSize(n1));
    }
}