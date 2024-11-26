namespace Class_Exceptions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isFibonacci = fibonacci_numb(8);
            Console.WriteLine(isFibonacci);
        }
        static bool fibonacci_numb(int number)
        {
            if (number == 0 || number == 1)
            {
                return true;
            }

            int a = 0;
            int b = 1;
            int c = a + b;

            while (c <= number)
            {
                if (c == number)
                {
                    return true;
                }

                a = b;
                b = c;
                c = a + b;
            }
            return false;
        }
    }
}
