namespace BookStore.Tests;

public class Tests
{
    private Store _bookStore;

    [Test]
    public void buy_zero_book()
    {
        var actual = _bookStore.Buy(new List<int> {0, 0, 0});
        Assert.AreEqual(0, actual);
    }

    [SetUp]
    public void Setup()
    {
        _bookStore = new Store();
    }
}