using System;

namespace Class_Exceptions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Matrix matrix = new Matrix(3, 3);
            matrix.InputData();
            matrix.DisplayData();

            int max = matrix.FindMax();
            Console.WriteLine("Max value: " + max);

            int min = matrix.FindMin();
            Console.WriteLine("Min value: " + min);
        }
    }

    public class Matrix
    {
        private int[,] data;
        private int rows;
        private int columns;

        public Matrix(int rows, int columns)
        {
            this.rows = rows;
            this.columns = columns;
            data = new int[rows, columns];
        }

        public void InputData()
        {
            Console.WriteLine("Enter matrix elements:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write("Element [{0},{1}]: ", i, j);
                    data[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
        }

        public void DisplayData()
        {
            Console.WriteLine("Matrix elements:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write(data[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        public int FindMax()
        {
            int max = data[0, 0];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (data[i, j] > max)
                    {
                        max = data[i, j];
                    }
                }
            }
            return max;
        }

        public int FindMin()
        {
            int min = data[0, 0];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (data[i, j] < min)
                    {
                        min = data[i, j];
                    }
                }
            }
            return min;
        }
    }
}
