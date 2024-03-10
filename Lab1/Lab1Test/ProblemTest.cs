using Lab1;

namespace Lab1Test;

public class ProblemTest
{
    [Test]
    public void allItemsMetRequirementsShouldPass()
    {
        Item i1 = new Item(1,1);
        Item i2 = new Item(1,2);
        Item i3 = new Item(1,3);

        List<Item> testItems = new List<Item> { i1, i2, i3 };

        Problem testProblem = new Problem(testItems);

        int testItemTotalWeight = i1.Weight + i2.Weight + i3.Weight;
        int testItemTotalValue = i1.Value + i2.Value + i3.Value;

        Result result = testProblem.solve(testItemTotalWeight);
        
        Assert.That(result.getTotalWeight(), Is.EqualTo(testItemTotalWeight));
        Assert.That(result.getTotalValue(), Is.EqualTo(testItemTotalValue));
        Assert.That(result.getResultList(), Is.EqualTo(testItems));
    }

    [Test]
    public void oneItemMetRequirementsShouldPass()
    {
        Item valid = new Item(1, 3); //ratio 0.33
        Item invalid1 = new Item(2, 5); // ratio 0.4
        Item invalid2 = new Item(3, 6); // ratio 0.5
        
        //so sorted list, based on item ratio,  is {invalid2, invalid1, valid}

        List<Item> testItems = new List<Item> { valid, invalid1, invalid2 };

        Problem testProblem = new Problem(testItems);
        
        Result result = testProblem.solve(4);
        
        Assert.That(result.getTotalWeight(), Is.EqualTo(valid.Weight));
        Assert.That(result.getTotalValue(), Is.EqualTo(valid.Value));
        Assert.That(result.getResultList().Count, Is.EqualTo(1));
    }

    [Test]
    public void allItemsDoesntMetRequirementsShouldPass()
    {
        Item invalid1 = new Item(1, 2);
        Item invalid2 = new Item(2, 3);
        Item invalid3 = new Item(3, 4);

        List<Item> testItems = new List<Item> { invalid1, invalid2, invalid3 };

        Problem testProblem = new Problem(testItems);
        
        Result result = testProblem.solve(1);
        
        Assert.That(result.getResultList().Count, Is.EqualTo(0));
    }

    [Test]
    public void doesOrderMatterShouldPass()
    {
        Item valid1 = new Item(4, 2); // ratio 2.0
        Item valid2 = new Item(2, 2); //ratio 1.0
        Item invalid = new Item(4, 3); //ratio 1.33

        List<Item> testItemsVariantOne = new List<Item> { valid1, valid2, invalid };
        List<Item> testItemsVariantTwo = new List<Item> { valid2, valid1, invalid };
        
        //sorted list based on ratio will looks like {valid1, valid2, invalid}
        //so result should return list {valid1}, no matter the order of items

        Problem testProblemOne = new Problem(testItemsVariantOne);
        Problem testProblemTwo = new Problem(testItemsVariantTwo);

        Result resultOne = testProblemOne.solve(2);
        Result resultTwo = testProblemTwo.solve(2);
        
        Assert.That(resultOne.getResultList(), Is.EqualTo(resultTwo.getResultList()));
        Assert.That(resultOne.getResultList(), Is.EqualTo(new List<Item>(){valid1}));
        Assert.That(resultTwo.getResultList(), Is.EqualTo(new List<Item>(){valid1}));
    }

    [Test]
    public void solveEmptyListShouldThrowError()
    {
        List<Item> empty = new List<Item>();

        Problem testProblem = new Problem(empty);

        Assert.Throws<Exception>(() => testProblem.solve(1));

    }
}