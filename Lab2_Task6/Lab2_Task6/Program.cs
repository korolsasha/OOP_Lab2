using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_Task6
{
    class Program
    {
        public class Converter
        {
            public double UsdToUah { get; set; }
            public double EurToUah { get; set; }
            public double RubToUah { get; set; }
            public Converter(double usd, double eur, double rub)
            {
                UsdToUah = usd;
                EurToUah = eur;
                RubToUah = rub;
            }
            public double FromUsd(double usd) { return usd / UsdToUah; }
            public double FromEur(double eur) { return eur / EurToUah; }
            public double FromRub(double rub) { return rub / RubToUah; }
            public double ToUsd(double uah) { return uah * UsdToUah; }
            public double ToEur(double uah) { return uah * EurToUah; }
            public double ToRub(double uah) { return uah * RubToUah; }
        }
        static void Main(string[] args)
        {
            Console.InputEncoding = Console.OutputEncoding = System.Text.Encoding.Unicode;

            var converter = new Converter( usd: 1d / 26.62d, eur: 1d / 31.15d, rub: 1d / 0.37d );

            Console.WriteLine("Варіанти дій:");
            Console.WriteLine();
            Console.WriteLine("1. USD у UAH");
            Console.WriteLine("2. EUR у UAH");
            Console.WriteLine("3. RUB у UAH");
            Console.WriteLine("4. UAH у USD");
            Console.WriteLine("5. UAH у EUR");
            Console.WriteLine("6. UAH у RUB");
            Console.WriteLine();

            Console.Write("Ваш вибір №: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            if (choice < 1 || choice > 6)
            {
                Console.WriteLine("Така операція не є можливою");
            }

            else { Console.Write("Кількість валюти: "); }
            double value = Convert.ToDouble(Console.ReadLine());

            if (value <= 0)
            {
                Console.WriteLine("Значення не є припустими");
                Console.ReadLine();
            }

            Console.Write("Результат: ");
            Console.WriteLine();

            if (choice == 1) { Console.WriteLine(converter.FromUsd(value)); }

            if (choice == 2) { Console.WriteLine(converter.FromEur(value)); }

            if (choice == 3) { Console.WriteLine(converter.FromRub(value)); }

            if (choice == 4) { Console.WriteLine(converter.ToUsd(value)); }

            if (choice == 5) { Console.WriteLine(converter.ToEur(value)); }

            if (choice == 6) { Console.WriteLine(converter.ToRub(value)); }

            Console.ReadLine();
        }
    }
}
