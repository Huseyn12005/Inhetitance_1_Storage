using System;
using System.Xml.Linq;

namespace Inhetitance_1_Storage
{
    internal abstract class Storage
    {
        public string Name { get; set; }
        public string Model { get; set; }

        public Storage(string name, string model)
        {
            Name = name;
            Model = model;
        }

        public abstract double MediaTypeSize(int File_count);
        public abstract void Copy(double size);
        public abstract double FreeMemory();
        public abstract void PrintDeviceInfo();

    }

    internal class Flash : Storage
    {
        public double Speed { get; set; }
        public double Capacity { get; set; }

        public Flash(double speed, double capacity, string name, string model) : base(name, model)
        {
            Speed = speed;
            Capacity = capacity;

        }


        public override double MediaTypeSize(int File_count)
        {
            double size = File_count * 780;

            Console.WriteLine($"{size} MB");
            return size;
        }
        public override void Copy(double size)
        {
            int media = Convert.ToInt32(size / Capacity);
            int vaxt = Convert.ToInt32(media / Speed);

            Console.WriteLine($"Umumi media sayi: {media}");
            Console.WriteLine($"Vaxt: {vaxt} san");
        }

        public override double FreeMemory()
        {
            return Capacity;
        }
        public override void PrintDeviceInfo()
        {
            Console.WriteLine($"Media: {Name}");
            Console.WriteLine($"Model: {Model}");
            Console.WriteLine($"Speed: {Speed} GB");
            Console.WriteLine($"Capacity: {Capacity} GB");
            Console.WriteLine($"Free Memory: {FreeMemory()} GB");
        }
    }

    class DVD : Storage
    {
        public double Read_Write_Speed { get; }
        public bool IsSingle { get; }

        public double Capacity { get; set; }

        public DVD(double ReadWriteSpeed, bool issingle ,string name, string model,double capacity)
            : base(name, model)
        {
            Read_Write_Speed = ReadWriteSpeed;
            IsSingle = issingle;
            Capacity = capacity;
        }

        public override double MediaTypeSize(int File_count)
        {
            double size = File_count * 780;

            Console.WriteLine($"{size} MB");
            return size;
        }
        public override void Copy(double size)
        {
            int media = Convert.ToInt32(size / Capacity);
            int vaxt = Convert.ToInt32(media / Read_Write_Speed);

            Console.WriteLine($"Umumi media sayi: {media}");
            Console.WriteLine($"Vaxt: {vaxt} san");
        }

        public override double FreeMemory()
        {
            return Capacity;
        }
        public override void PrintDeviceInfo()
        {
            Console.WriteLine($"Media: {Name}");
            Console.WriteLine($"Model: {Model}");
            Console.WriteLine($"Read/Write Speed: {Read_Write_Speed} mb/san");
            Console.WriteLine($"Capacity: {Capacity} GB");
            Console.WriteLine($"Free Memory: {FreeMemory()} GB");
            Console.WriteLine($"IsSingle: {IsSingle}");
        }
    }

    class HDD : Storage
    {
        public double Speed { get; set; }
        public double Size { get; set; }

        public HDD(string name, string model, double speed, double size)
            : base(name, model)
        {
            Speed = speed;
            Size = size;
        }

        public override double MediaTypeSize(int File_count)
        {
            double size = File_count * 780;

            Console.WriteLine($"{size} MB");
            return size;
        }
        public override void Copy(double size)
        {
            int media = Convert.ToInt32(size / Size);
            int vaxt = Convert.ToInt32(media / Speed);

            Console.WriteLine($"Umumi media sayi: {media}");
            Console.WriteLine($"Vaxt: {vaxt} san");
        }

        public override double FreeMemory()
        {
            return Size;
        }
        public override void PrintDeviceInfo()
        {
            Console.WriteLine($"Media: {Name}");
            Console.WriteLine($"Model: {Model}");
            Console.WriteLine($"Speed: {Speed} mb/san");
            Console.WriteLine($"Capacity: {Size} GB");
            Console.WriteLine($"Free Memory: {FreeMemory()} GB");
        }
    }

}
