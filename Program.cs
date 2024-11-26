namespace Class_Exceptions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of elements in the array: ");
            int size = int.Parse(Console.ReadLine());

            int[] array = new int[size];
            Console.WriteLine("Enter the elements of the array: ");
            for (int i = 0; i < size; i++)
            {
                Console.Write("Element {0}: ", i + 1);
                array[i] = int.Parse(Console.ReadLine());
            }
            Console.Write("Sort the array in ascending order? (y/n): ");
            int choice = Console.ReadLine().ToLower() == "y" ? 1 : 0;

            bool ascending = choice == 1;

            sortArray(array, ascending);

            Console.WriteLine("The sorted array is: ");
            foreach (int element in array)
            {
                Console.Write(element + " ");
            }
        }
        static void sortArray(int[] array, bool ascending = true)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (ascending ? array[i] > array[j] : array[i] < array[j])
                    {
                        int temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }
        }
    }
}
