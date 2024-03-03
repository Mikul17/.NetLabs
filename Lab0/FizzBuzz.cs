namespace Lab0;

public class FizzBuzz
{
    private int _max;

    //default constructor
    public FizzBuzz()
    {
        this._max = 0;
    }

    //constructor with max parameter
    public FizzBuzz(int max)
    {
        this._max = max;
    }

    public void print()
    {
        for (int i = 1; i <= _max; i++)
        {
            if (i % 3 == 0 && i % 5 == 0)
            {
                Console.WriteLine("FizzBuzz");
            }else if (i % 3 == 0)
            {
                Console.WriteLine("Fizz");
            }else if (i % 5 == 0)
            {
                Console.WriteLine("Buzz");
            }
            else
            {
                Console.WriteLine(i);
            }
        }
    }
    
    
}