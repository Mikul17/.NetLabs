using Lab1;

namespace Lab1Test;

public class Tests
{

    [Test]
    public void calculateRatioShouldPass()
    {
        Item item = new Item(2, 1);
        Assert.That(item.Ratio, Is.EqualTo(2));
    }

    [Test]
    public void calculateRatioShouldFail()
    {
        Item item = new Item(2, 1);
        Assert.That(item.Ratio,Is.Not.EqualTo(5));
    }

    [Test]
    public void calculateRatioShouldThrowError()
    {
        Assert.Throws<InvalidOperationException>(() => new Item(1, 0));
    }
}