using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_Task8
{
    class Program
    {
        public class Invoice
        {
            public int Account { get; }
            public string Customer { get; }
            public string Provider { get; }

            private string article;
            private int quantity;

            public Invoice(
                int account,
                string customer,
                string provider,
                string article,
                int quantity
            )
            {
                Account = account;
                Customer = customer;
                Provider = provider;
                this.article = article;
                this.quantity = quantity;
            }

            public double CalculateCost(bool includeVat)
            {
                double price = 0d;

                if (article == "9683648") { price = 20d; }
                if (article == "2865983") { price = 55d; }
                if (article == "1785654") { price = 145d; }

                return price * quantity / (includeVat ? 0.8d : 1d);
            }
        }
        static void Main(string[] args)
        {
            Console.InputEncoding = Console.OutputEncoding = System.Text.Encoding.Unicode;

            var invoice = new Invoice( account: 1445748, customer: "Василь Степко", provider: "Dell", article: "1785654", quantity: 15 );

            Console.WriteLine( $"Сума до сплати без ПДВ: {invoice.CalculateCost(false)} грн." );

            Console.WriteLine( $"Сума до сплати з ПДВ: {invoice.CalculateCost(true)} грн." );

            Console.ReadLine();
        }
    }
}
