namespace Lab0;

class Program
{
    static void Main(string[] args)
    {
        //Creating instance of FizzBuzz class with max parameter equal to 20
        FizzBuzz fizzBuzz = new FizzBuzz(20);
        //Calling method which displays answer
        fizzBuzz.print();
    }
}