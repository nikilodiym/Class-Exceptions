namespace Class_Exceptions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int product = getProductInRange(1, 5);
            Console.WriteLine("Product: " + product);
        }
        static int getProductInRange(int start, int end)
        {
            int product = 1;
            for (int i = start; i <= end; i++)
            {
                product *= i;
            }
            return product;
        }
    }
}
