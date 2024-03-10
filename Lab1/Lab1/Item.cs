namespace Lab1;

public class Item
{
    private int value;
    private int weight;
    private double ratio;

    public Item(int value, int weight)
    {
        
        this.value = value;
        this.weight = weight;
        
        if (weight == 0)
        {
            throw new InvalidOperationException("Cannot divide by zero");
        }
        this.ratio = (double)value / weight;
    }

    public int Value
    {
        get => value;
        set => this.value = value;
    }

    public int Weight
    {
        get => weight;
        set => weight = value;
    }

    public double Ratio
    {
        get => ratio;
        set => ratio = (double) value/weight;
    }

    public override string ToString()
    {
        return "value: " + value + " | weight: " + weight;
    }
}