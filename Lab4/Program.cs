using System.Diagnostics;

namespace Lab4;

class Program
{
    static void Main(string[] args)
    {
        Matrix m = new Matrix(3,3);
        Matrix n = new Matrix(3, 3);
        
        m.populate(50);
        Console.WriteLine("Macierz A:");
        m.display();
        Console.WriteLine("Macierz B:" );
        n.populate(30);
        n.display();
        Stopwatch stopwatch = new Stopwatch();
        
        stopwatch.Start();
        Matrix r = Solver.multiplyMatrix(m, n);
        stopwatch.Stop();
        TimeSpan multTime = stopwatch.Elapsed;
        Console.WriteLine("Wynik dla klasycznego mnożenia");
        r.display();
        //Console.WriteLine($"Czas trwania zwyklego mnozenia: {multTime}");
        Console.WriteLine("_______________");
        
        
        stopwatch.Restart();
        Matrix r2 = Solver.multiplyMatrixThreads(m, n,4);
        stopwatch.Stop();
        TimeSpan threadTime = stopwatch.Elapsed;
        Console.WriteLine("Wynik dla mnożenia na threadach");
        r2.display();
        //Console.WriteLine($"\nCzas trwania mnozenia na threadach: {threadTime}");
        Console.WriteLine("_______________");
        
        stopwatch.Restart();
        Matrix r3 = Solver.multiplyMatrixParallel(m, n, 4);
        stopwatch.Stop();
        TimeSpan paralelTime = stopwatch.Elapsed;
        Console.WriteLine("Wynik dla mnożenia z funkcja parallel");
        r3.display();
        //Console.WriteLine($"\nCzas trwania mnozenia z parallel forem: {paralelTime}");
        Console.WriteLine("_______________");
    }
}