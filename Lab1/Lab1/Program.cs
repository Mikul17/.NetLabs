namespace Lab1;

class Program
{
    static void Main(string[] args)
    {
        Problem problem = new Problem(4, 123);
        problem.listItems();
        Result r = problem.solve(5);
        r.printResult();
    }
}