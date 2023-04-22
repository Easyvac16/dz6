using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz6
{
    public class Money
    {
        private int dollars;
        private int cents;

        public Money(int dollars, int cents)
        {
            this.dollars = dollars;
            this.cents = cents;
        }

        public int Dollars
        {
            get { return this.dollars; }
            set { this.dollars = value; }
        }

        public int Cents
        {
            get { return this.cents; }
            set { this.cents = value; }
        }

        public void Display()
        {
            Console.WriteLine($"{this.dollars}.{this.cents}$");
        }
    }
    public class Product
    {
        private string name;
        private Money price;

        public Product(string name, Money price)
        {
            this.name = name;
            this.price = price;
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public Money Price
        {
            get { return this.price; }
            set { this.price = value; }
        }

        public void Display()
        {
            Console.WriteLine($"{this.name} - ");
            this.price.Display();
        }

        public void ReducePrice(int amount)
        {
            int totalCents = this.price.Dollars * 100 + this.price.Cents;
            totalCents -= amount;
            if (totalCents < 0)
            {
                totalCents = 0;
            }
            int dollars = totalCents / 100;
            int cents = totalCents % 100;
            this.price.Dollars = dollars;
            this.price.Cents = cents;
        }
    }
    internal class cs1
    {
        public static void task_1()
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Money money = new(5,55);
            Product product = new("Chocolate", money);
            Console.WriteLine("Товар -");
            product.Display();
            Console.WriteLine("Нова ціна на товар");
            product.ReducePrice(155);
            product.Display();
        }
        
        
    }
}
