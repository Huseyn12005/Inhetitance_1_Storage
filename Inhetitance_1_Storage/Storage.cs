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
        public abstract void FreeMemory();
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
        public abstract void FreeMemory();
        public abstract void PrintDeviceInfo();
    }
}
