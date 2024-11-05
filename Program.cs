namespace PrototypePattern
{
    class Program
    {
        static void Main()
        {
            Guitar guitar1 = new("Telecaster", "Fender", 6, "Электрическая");
            Violin violin1 = new("Скрипка", "Yamaha", 4, "1/2");
            Drum drum1 = new("Бочка", "TAMA", "Полиэтилен", 22.0);

            Guitar guitar2 = (Guitar)guitar1.Clone();
            Violin violin2 = (Violin)violin1.Clone();
            Drum drum2 = (Drum)drum1.Clone();

            Console.WriteLine("Оригиналы:");
            Console.WriteLine(guitar1);
            Console.WriteLine(violin1);
            Console.WriteLine(drum1);

            Console.WriteLine("\nКлоны:");
            Console.WriteLine(guitar2);
            Console.WriteLine(violin2);
            Console.WriteLine(drum2);

            ICloneable cloneableGuitar = guitar1;
            Guitar guitar3 = (Guitar)cloneableGuitar.Clone();

            Console.WriteLine("\nКлон через ICloneable:");
            Console.WriteLine(guitar3);
        }
    }
}
