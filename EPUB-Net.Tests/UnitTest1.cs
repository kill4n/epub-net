namespace EPUB_Net.Tests;

public class Tests
{
  bool testValue = false;
    [SetUp]
    public void Setup()
    {
      testValue = true;
    }

    [Test]
    public void Test1()
    {
      Assert.isTrue(testValue);
        Assert.Pass();
    }
}
