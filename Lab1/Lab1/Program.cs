namespace Lab1;

class Program
{
        static void Main()
        {
                Problem problem = new Problem(4, 123);
                problem.listItems();
                Result r = problem.solve(5);
                r.printResult();
        }
}