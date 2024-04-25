using System.Diagnostics;

namespace Lab4;

class Program
{
    static void Main(string[] args)
    {
        Matrix m = new Matrix(1000,1000);
        Matrix n = new Matrix(1000, 1000);
        
        m.populate(50);
        n.populate(30);
        Stopwatch stopwatch = new Stopwatch();
        
        stopwatch.Start();
        Matrix r = Solver.multiplyMatrix(m, n);
        stopwatch.Stop();
        TimeSpan multTime = stopwatch.Elapsed;
        //r.display();
        Console.WriteLine($"Czas trwania zwyklego mnozenia: {multTime}");
        Console.WriteLine("_______________");
        
        
        stopwatch.Restart();
        Matrix r2 = Solver.multiplyMatrixThreads(m, n,4);
        stopwatch.Stop();
        TimeSpan threadTime = stopwatch.Elapsed;
        //r2.display();
        Console.WriteLine($"Czas trwania mnozenia na threadach: {threadTime}");
        Console.WriteLine("_______________");
        
        stopwatch.Restart();
        Matrix r3 = Solver.multiplyMatrixParallel(m, n, 4);
        stopwatch.Stop();
        TimeSpan paralelTime = stopwatch.Elapsed;
        //r3.display();
        Console.WriteLine($"Czas trwania mnozenia z parallel forem: {paralelTime}");
        Console.WriteLine("_______________");
        
    }
}