using System.Text;

namespace Lab1;

public class Result
{
    private int totalValue;
    private int totalWeight;
    private List<Item> result;

    public Result()
    {
        this.totalValue = 0;
        this.totalWeight = 0;
        result = new List<Item>();
    }

    public void insertIntoList(Item i)
    {
        result.Add(i);
        totalValue += i.Value;
        totalWeight += i.Weight;
    }

    public int getTotalValue()
    {
        return totalValue;
    }

    public int getTotalWeight()
    {
        return totalWeight;
    }

    public List<Item> getResultList()
    {
        return result;
    }

    public string printResult()
    {
        StringBuilder text = new StringBuilder();

        Console.WriteLine("===========Result===========");

        text.AppendLine("Total value: " + totalValue);
        text.AppendLine("Total weight: " + totalWeight);
        text.AppendLine("======Selected items======");

        foreach (var item in result)
        {
            Console.WriteLine(item + " | ratio: "+item.Ratio);
            text.AppendLine(item + " | ratio: " + item.Ratio);
        }
        Console.WriteLine("Total value: {0} | Total weight: {1}",totalValue,totalWeight);

        return text.ToString();
    }
}