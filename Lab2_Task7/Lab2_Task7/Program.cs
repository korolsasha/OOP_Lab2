using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_Task7
{
    public class Employee
    {
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string Position { get; set; }
        public int Experience { get; set; }

        public Employee(string firstName, string secondName)
        {
            FirstName = firstName;
            SecondName = secondName;
        }

        public void CalculateSalaryAndTax(out double salary, out double tax)
        {
            double baseSalary = 0d;

            if (Position == "Розробник") { baseSalary = 18000d; }
            if (Position == "Менеджер") { baseSalary = 16000d; }
            if (Position == "Директор") { baseSalary = 22000d; }

            salary = baseSalary * Experience / 2d;
            tax = salary * 0.2d;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Console.OutputEncoding = System.Text.Encoding.Unicode;

            var employee = new Employee("Іван", "Мазур")
            {
                Position = "Директор",
                Experience = 8
            };

            employee.CalculateSalaryAndTax( out double salary, out double tax );

            Console.WriteLine($"Ім'я: {employee.FirstName} {employee.SecondName}");
            Console.WriteLine($"Посада: {employee.Position}");
            Console.WriteLine($"Заробітня плата: {salary}");
            Console.WriteLine($"Податок: {tax}");

            Console.ReadLine();
        }
    }
}
