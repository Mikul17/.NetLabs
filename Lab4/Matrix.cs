

    namespace Lab4;

    public class Matrix
    {
        public int row { get;}
        public int column { get;}
        
        public volatile int[,] matrix;

        public Matrix(int row, int column)
        {
            this.row = row;
            this.column = column;
            matrix = new int [row, column];
        }

        public void display()
        {
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    Console.Write(matrix[i,j]+" ");
                }
                Console.WriteLine();
            }
        }

        public void populate(int seed)
        {
            Random random = new Random(seed);
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    matrix[i, j] = random.Next(100);
                }
            }
        }
    }