using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz6
{
    public class MusicalInstrument
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string History { get; set; }

        public MusicalInstrument(string name, string description, string history)
        {
            Name = name;
            Description = description;
            History = history;
        }

        public virtual void Sound()
        {
            Console.WriteLine("This is the sound of a musical instrument.");
        }

        public void Show()
        {
            Console.WriteLine("Назва музикального інструменту: " + Name);
        }

        public void Desc()
        {
            Console.WriteLine("Опис музикального інструменту: " + Description);
        }

        public void HistoryInfo()
        {
            Console.WriteLine("Історія музикального інструменту: " + History);
        }
    }

    public class Violin : MusicalInstrument
    {
        public Violin(string name, string description, string history)
            : base(name, description, history)
        {
        }

        public override void Sound()
        {
            Console.WriteLine("Це звук скрипки");
        }
    }

    public class Trombone : MusicalInstrument
    {
        public Trombone(string name, string description, string history)
            : base(name, description, history)
        {
        }

        public override void Sound()
        {
            Console.WriteLine("Це звук тромбона");
        }
    }

    public class Ukulele : MusicalInstrument
    {
        public Ukulele(string name, string description, string history)
            : base(name, description, history)
        {
        }

        public override void Sound()
        {
            Console.WriteLine("Це звук укулеле");
        }
    }

    public class Cello : MusicalInstrument
    {
        public Cello(string name, string description, string history)
            : base(name, description, history)
        {
        }

        public override void Sound()
        {
            Console.WriteLine("Це звук віолончелі");
        }
    }
    internal class cs3
    {
        public static void task_3()
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Violin violin = new("Скрипка", "Струнно-смичковий інструмент", "Сучасна скрипка з’явилася на початку 16 століття в північній Італії.");
            Trombone trombone = new("Тромбон", "Мідний духовий інструмент", "Тромбон існує вже багато століть.");
            Ukulele ukulele = new("Укулеле", "Невеликий інструмент, схожий на гітару", "Укулеле виникла в 19 столітті як гавайська адаптація португальського мачете.");
            Cello cello = new ("Віолончель", "Великий смичковий струнний інструмент", "Віолончель належить до групи скрипок.");

            violin.Show();
            violin.Desc();
            violin.HistoryInfo();
            violin.Sound();

            Console.WriteLine();

            trombone.Show();
            trombone.Desc();
            trombone.HistoryInfo();
            trombone.Sound();

            Console.WriteLine();

            ukulele.Show();
            ukulele.Desc();
            ukulele.HistoryInfo();
            ukulele.Sound();

            Console.WriteLine();

            cello.Show();
            cello.Desc();
            cello.HistoryInfo();
            cello.Sound();
        }
    }
}
