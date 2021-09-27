using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_Task5
{
    public class User
    {
        public string Login
        {
            get;
            set;
        }
        public string First_Name
        {
            get;
            set;
        }
        public string Second_Name
        {
            get;
            set;
        }
        public int Age
        {
            get;
            set;
        }

        public DateTime Date
        {
            get;
        }

        public User( string login, string first_name, string second_name, int age )
        {
            Login = login;
            First_Name = first_name;
            Second_Name = second_name;
            Age = age;
            Date = DateTime.Now;
        }

        public void Show()
        {
            Console.WriteLine($"Логін: {Login}");
            Console.WriteLine($"Ім'я: {First_Name}");
            Console.WriteLine($"Прізвище: {Second_Name}");
            Console.WriteLine($"Вік: {Age}");
            Console.WriteLine($"Дата заповнення анкети: {Date}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Console.OutputEncoding = System.Text.Encoding.Unicode;

            Console.Write("Логін: ");
            string login = Console.ReadLine();

            Console.Write("Ім'я: ");
            string first_name = Console.ReadLine();

            Console.Write("Прізвище: ");
            string second_name = Console.ReadLine();

            Console.Write("Вік: ");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine();

            var user = new User( login, first_name, second_name, age );

            Console.WriteLine("Кінцева анкета:");

            user.Show();

            Console.ReadLine();
        }
    }
}
