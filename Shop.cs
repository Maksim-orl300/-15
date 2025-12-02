using System;


namespace ConsoleApp19
{
    interface setPrice
    {
        decimal Price();
    }
    interface garantyTerm
    {
        int Term();
    }

    class Phone : setPrice,garantyTerm
    {
        private readonly decimal price;
        private readonly int term;

        public Phone (decimal x, int y)
        {
            price = x;
            term = y;
        }

        public decimal Price()
        {
            Console.WriteLine($"Цена телефона {price} рублей");
            return price;
        }
        public int Term()
        {
            Console.WriteLine($"Гарантия для телефона: {term} месяцев");
            return term;
        }
    }

    public class Laptop : setPrice
    {
        private readonly decimal price;

        public Laptop(decimal x)
        {
            price = x;
        }

        public decimal Price()
        {
            Console.WriteLine($"Цена ноутбука {price} рублей");
            return price;   
        }
    }
}
