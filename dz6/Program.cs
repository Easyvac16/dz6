namespace dz6
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Виберіть завдання яке хочете попробувати: 1 - Продукт . 2 - Класс девайс . 3 - Класс музикальний інструмент . 4 - Абстрактний класс працівник:");
            int a = int.Parse(Console.ReadLine());
            switch (a)
            {
                case 1:
                    cs1.task_1();
                    break;
                case 2:
                    cs2.task_2();
                    break;
                case 3:
                    cs3.task_3();
                    break;
                case 4:
                    cs4.task_4();
                    break;
            }
        }
    }
}