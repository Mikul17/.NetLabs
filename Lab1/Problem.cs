namespace DefaultNamespace;

public class Solution
{
    private int n;
    private int seed;
    private List<Item> items;

    public Solution(int _n, int _seed)
    {
        this n = _n;
        this seed = _seed;
        Random random = new Random();
    }
}