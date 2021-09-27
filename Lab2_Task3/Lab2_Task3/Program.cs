using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_Task3
{
    class Book
    {
        private Title title = null;
        private Author author = null;
        private Content content = null;

        public void Add_Tit(string title)
        {
            this.title = new Title(title);
        }

        public void Add_Au(string author)
        {
            this.author = new Author(author);
        }

        public void Add_Co(string content)
        {
            this.content = new Content(content);
        }

        public void Show()
        {
            Console.WriteLine("Ваша книга:");

            ConsoleColor initialColor = Console.ForegroundColor;

            Console.ForegroundColor = ConsoleColor.Red;
            title?.Show();

            Console.ForegroundColor = ConsoleColor.Green;
            author?.Show();

            Console.ForegroundColor = ConsoleColor.Blue;
            content?.Show();

            Console.ForegroundColor = initialColor;
        }
    }

    class Title
    {
        public string title;

        public Title(string title)
        {
            this.title = title;
        }
        public void Show()
        {
            Console.WriteLine($"Назва: {title}");
        }
    }

    class Author
    {
        public string author;

        public Author(string author)
        {
            this.author = author;
        }
        public void Show()
        {
            Console.WriteLine($"Автор: {author}");
        }
    }

    class Content
    {
        public string content;

        public Content(string content)
        {
            this.content = content;
        }
        public void Show()
        {
            Console.WriteLine($"Зміст: {content}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            var book = new Book();

            while (true)
            {
                Console.WriteLine("Що саме ви хочете зробити?");
                Console.WriteLine("1. Змінити назву книги");
                Console.WriteLine("2. Змінити автора книги");
                Console.WriteLine("3. Змінити зміст книги");
                Console.WriteLine("4. Показати книгу, що вийшла");
                Console.WriteLine("5. Зачинити програму");
                Console.WriteLine();
                Console.Write("Ваш вибір: ");
                int ch = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();

                if (ch == 1)
                {
                    Console.Write("Введіть назву книги: ");
                    book.Add_Tit(Console.ReadLine());
                    Console.WriteLine();
                }
                if (ch == 2)
                {
                    Console.Write("Введіть автора книги: ");
                    book.Add_Au(Console.ReadLine());
                    Console.WriteLine();
                }
                if (ch == 3)
                {
                    Console.Write("Введіть зміст книги: ");
                    book.Add_Co(Console.ReadLine());
                    Console.WriteLine();
                }
                if (ch == 4)
                {
                    book.Show();
                    Console.WriteLine();
                }
                if (ch == 5)
                {
                    break;
                }
                if (ch < 1 || ch > 5)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Неправильний вибір. Введіть ще раз");
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
        }
    }
}
