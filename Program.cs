using System;

namespace Class_Exceptions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Airplane airplane = new Airplane();
            airplane.InputData();
            airplane.DisplayData();
        }
    }

    internal class Airplane
    {
        private string name;
        private string manufacturer;
        private int year;
        private string type;

        public void InputData()
        {
            Console.Write("Enter the name of the airplane: ");
            name = Console.ReadLine();

            Console.Write("Enter the manufacturer of the airplane: ");
            manufacturer = Console.ReadLine();

            Console.Write("Enter the year of manufacture: ");
            year = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the type of the airplane: ");
            type = Console.ReadLine();
        }

        public void DisplayData()
        {
            Console.WriteLine("Airplane Details:");
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Manufacturer: " + manufacturer);
            Console.WriteLine("Year of Manufacture: " + year);
            Console.WriteLine("Type: " + type);
        }
    }
}
