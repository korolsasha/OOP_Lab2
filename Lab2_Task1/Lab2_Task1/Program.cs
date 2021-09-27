using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_Task1
{
    class Adress
    {
        public int index, house, apartment;
        public string country, city, street;

        private int Index
        {
            get { return index; }
            set { Index = value; }
        }

        private int House
        {
            get { return house; }
            set { House = value; }
        }

        private int Apartment
        {
            get { return apartment; }
            set { Apartment = value; }
        }

        private string Country
        {
            get { return country; }
            set { Country = value; }
        }

        private string City
        {
            get { return city; }
            set { City = value; }
        }

        private string Street
        {
            get { return street; }
            set { Street = value; }
        }

        public void GetInfo()
        {
            Console.WriteLine($"index: { Index } country: { Country } city: { City } street: { Street } house: { House } apartment: { Apartment }");
        }

    }


    class Program
    {
        static void Main(string[] args)
        {
            Adress a = new Adress();

            a.index = 04000;
            a.country = "Ukraine";
            a.city = "Kyiv";
            a.street = "Kioto";
            a.house = 19;
            a.apartment = 514;

            a.GetInfo();

            Console.ReadKey();
        }
    }
}
