using System.Text;

namespace Lab1;

public class Problem
{
    private int n;
    private int seed;
    private List<Item> items;
    private StringBuilder text;

    public Problem(int n, int seed)
    {
        this.n = n;
        this.seed = seed;
        items = new List<Item>();
        generateItems();
        text= new StringBuilder();
    }

    public Problem(List<Item> items)
    {
        this.n = items.Count;
        this.items = items;
        this.seed = 0;
        text = new StringBuilder();
    }

    private void generateItems()
    {
        Random rand = new Random(seed);

        for (int i = 0; i < n; i++)
        {
            items.Add(new Item(rand.Next(10)+1, rand.Next(10)+1));
        }
    }

    public void listItems()
    {
        foreach (var item in items)
        {
            Console.WriteLine(item + " | ratio: "+item.Ratio);
        }
    }

    public string listItemsText()
    {
        text = new StringBuilder();
        foreach (var item in items)
        {
            text.AppendLine(item + " | ratio: "+item.Ratio);
        }
        return text.ToString();
    }   

    public Result solve(int capacity)
    {
        Result result = new Result();

        if (items.Count == 0)
        {
            throw new Exception("Items list shouldn't be empty");
        }
        List<Item> sortedItems = items;
        sortedItems.Sort((a,b) => b.Ratio.CompareTo(a.Ratio));
        
        Console.WriteLine("===========Sorted list===========");
        
        foreach (var item in sortedItems)
        {
            Console.WriteLine(item + " | ratio: "+ item.Ratio);
        }

        int i = 0;

        while (result.getTotalWeight() <= capacity && i < sortedItems.Count)
        {
            if (result.getTotalWeight() + sortedItems[i].Weight <= capacity)
            {
                result.insertIntoList(sortedItems[i]);
            }

            i++;
        }

        return result;
    }
}