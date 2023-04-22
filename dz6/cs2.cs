using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz6
{

    class Device
    {

        public string Name { get; set; }
        public string Description { get; set; }

        public Device(string name, string description)
        {
            Name = name;
            Description = description;
        }

        public virtual void Sound()
        {
            Console.WriteLine("Device sound");
        }

        public void Show()
        {
            Console.WriteLine("Device: " + Name);
        }

        public void Desc()
        {
            Console.WriteLine("Device description: " + Description);
        }
    }

    class Kettle : Device
    {
        
        public int Volume { get; set; }
        

        public Kettle(string name, string description, int volume) : base(name, description)
        {
            Volume = volume;
            
        }

        public override void Sound()
        {
            Console.WriteLine("Чайник робить звук кипіння води");
        }
    }

    class Microwave : Device
    {
        public int Power { get; set; }
        

        public Microwave(string name, string description, int power) : base(name, description)
        {
            Power = power;
            
        }

        public override void Sound()
        {
            Console.WriteLine("Мікрохвильовка робить дзинь!");
        }
    }

    class Car : Device
    {
        public int EnginePower { get; set; }
        public int MaxSpeed { get; set; }

        public Car(string name, string description, int enginePower, int maxSpeed) : base(name, description)
        {
            EnginePower = enginePower;
            MaxSpeed = maxSpeed;
        }

        public override void Sound()
        {
            Console.WriteLine("В машини звук мотора");
        }
    }

    class Steamship : Device
    {
        public int Length { get; set; }
        public int MaxPassengers { get; set; }

        public Steamship(string name, string description, int length, int maxPassengers) : base(name, description)
        {
            Length = length;
            MaxPassengers = maxPassengers;
        }

        public override void Sound()
        {
            Console.WriteLine("Пароплав видає свист");
        }
    }
    internal class cs2
    {
        public static void task_2()
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Kettle kettle = new Kettle("Samsung", "MS-512352", 2200);
            Microwave microwave = new Microwave("LG MH-6389", "LG", 1200);
            Car car = new Car("BMW M5", "Elite Class", 500 , 280);
            Steamship steamboat = new Steamship("Queen Mary 2", "Cunard Line", 500,1000);

            kettle.Show();
            kettle.Sound();
            kettle.Desc();
            Console.WriteLine();

            microwave.Show();
            microwave.Sound();
            microwave.Desc();
            Console.WriteLine();

            car.Show();
            car.Sound();
            car.Desc();
            Console.WriteLine();

            steamboat.Show();
            steamboat.Sound();
            steamboat.Desc();
            Console.WriteLine();
        }
    }
    
}
