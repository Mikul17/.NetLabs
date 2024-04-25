namespace Lab4;

public static class Solver
{
    private static bool compareSizes(Matrix a, Matrix b)
    {
        if (a.column != b.row)
        {
            throw new Exception("Invalid matrix sizes for multiplication");
        }

        return true;
    }
    public static Matrix multiplyMatrix(Matrix a, Matrix b)
    {
        compareSizes(a, b);

        Matrix result = new Matrix(a.row, b.column);

        for (int i = 0; i < a.row; i++)
        {
            for (int j = 0; j < b.column; j++)
            {
                for (int k = 0; k < a.column; k++)
                {
                    result.matrix[i,j] += a.matrix[i, k] * b.matrix[k, j];
                }
            }
        }

        return result;
    }

    public static Matrix multiplyMatrixThreads(Matrix a, Matrix b, int threads)
    {
        compareSizes(a, b);

        Matrix result = new Matrix(a.row, b.column);
        int rowsPerThread = (int)Math.Ceiling((double)a.row / threads);

        List<Thread> threadList = new List<Thread>();
        for (int threadIndex = 0; threadIndex < threads; threadIndex++)
        {
            int startRow = threadIndex * rowsPerThread;
            int endRow = Math.Min(startRow + rowsPerThread, a.row);

            Thread thread = new Thread(() => 
            {
                Console.WriteLine($"Thread {Thread.CurrentThread.ManagedThreadId} started | rows from {startRow} to {endRow}");
                for (int i = startRow; i < endRow; i++)
                {
                    for (int j = 0; j < b.column; j++)
                    {
                        for (int k = 0; k < a.column; k++)
                        {
                            result.matrix[i, j] += a.matrix[i, k] * b.matrix[k, j];
                        }
                    }
                }
            });
            threadList.Add(thread);
            thread.Start();
        }
        foreach (var thread in threadList)
        {
            thread.Join();
        }
        
        return result;
    }

    public static Matrix multiplyMatrixParallel(Matrix a, Matrix b, int threads)
    {
        compareSizes(a, b);

        Matrix result = new Matrix(a.row, b.column);
        int rowsPerThread = (int)Math.Ceiling((double)a.row / threads);
        
        Parallel.For(0, threads, i =>
        {
            int startRow = i * rowsPerThread;
            int endRow = Math.Min(startRow + rowsPerThread, a.row);

            Console.WriteLine($"Parallel thread {Task.CurrentId} started | rows from {startRow} to {endRow}");

            for (int row = startRow; row < endRow; row++)
            {
                for (int col = 0; col < b.column; col++)
                {
                    int sum = 0;
                    for (int k = 0; k < a.column; k++)
                    {
                        sum += a.matrix[row, k] * b.matrix[k, col];
                    }
                    result.matrix[row, col] = sum;
                }
            }
        });

        return result;
    }

}