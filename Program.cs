using System;

namespace Class_Exceptions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Employee employee = new Employee();

            employee.SetFullName("John Doe");
            employee.SetDateOfBirth(new DateTime(1990, 1, 1));
            employee.SetContactNumber("1234567890");
            employee.SetEmail("john.doe@example.com");
            employee.SetPosition("Software Developer");
            employee.SetJobDescription("Developing software applications");

            Console.WriteLine("Employee Information:");
            Console.WriteLine("Full Name: " + employee.GetFullName());
            Console.WriteLine("Date of Birth: " + employee.GetDateOfBirth().ToString("yyyy-MM-dd"));
            Console.WriteLine("Contact Number: " + employee.GetContactNumber());
            Console.WriteLine("Email: " + employee.GetEmail());
            Console.WriteLine("Position: " + employee.GetPosition());
            Console.WriteLine("Job Description: " + employee.GetJobDescription());
        }
    }

    public class Employee
    {
        private string fullName;
        private DateTime dateOfBirth;
        private string contactNumber;
        private string email;
        private string position;
        private string jobDescription;

        public void SetFullName(string fullName)
        {
            this.fullName = fullName;
        }

        public string GetFullName()
        {
            return fullName;
        }

        public void SetDateOfBirth(DateTime dateOfBirth)
        {
            this.dateOfBirth = dateOfBirth;
        }

        public DateTime GetDateOfBirth()
        {
            return dateOfBirth;
        }

        public void SetContactNumber(string contactNumber)
        {
            this.contactNumber = contactNumber;
        }

        public string GetContactNumber()
        {
            return contactNumber;
        }

        public void SetEmail(string email)
        {
            this.email = email;
        }

        public string GetEmail()
        {
            return email;
        }

        public void SetPosition(string position)
        {
            this.position = position;
        }

        public string GetPosition()
        {
            return position;
        }

        public void SetJobDescription(string jobDescription)
        {
            this.jobDescription = jobDescription;
        }

        public string GetJobDescription()
        {
            return jobDescription;
        }
    }
}
