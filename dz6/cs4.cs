using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz6
{
    abstract class Worker
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public abstract void Print();
    }

    class President : Worker
    {
        public override void Print()
        {
            Console.WriteLine("Я президент.");
            Console.WriteLine($"Мене звати {Name} і мені {Age} років.");
        }
    }

    class Security : Worker
    {
        public override void Print()
        {
            Console.WriteLine("Я охоронець.");
            Console.WriteLine($"Мене звати {Name} і мені {Age} років.");
        }
    }

    class Manager : Worker
    {
        public override void Print()
        {
            Console.WriteLine("Я менеджер.");
            Console.WriteLine($"Мене звати  {Name}  і мені  {Age}  років.");
        }
    }

    class Engineer : Worker
    {
        public override void Print()
        {
            Console.WriteLine("Я інженер.");
            Console.WriteLine($"Мене звати  {Name}  і мені  {Age}  років.");
        }
    }
    internal class cs4
    {
        public static void task_4()
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            President president = new President() { Name = "Дональд Байден", Age = 50 };
            Security security = new Security() { Name = "Вілл Сміт", Age = 25 };
            Manager manager = new Manager() { Name = "Хідео Кодзіма", Age = 40 };
            Engineer engineer = new Engineer() { Name = "Роберт Младший", Age = 30 };

            president.Print();
            Console.WriteLine();
            security.Print();
            Console.WriteLine();
            manager.Print();
            Console.WriteLine();
            engineer.Print();
        }
    }
}
