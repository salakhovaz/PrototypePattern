namespace PrototypePattern
{
    public class Instrument : IMyCloneable<Instrument>, ICloneable
    {
        public string Name { get; set; }

        public string Brand { get; set; }

        public Instrument(string name, string brand)
        {
            Name = name;
            Brand = brand;
        }

        public virtual Instrument Clone()
        {
            return new Instrument(this.Name, this.Brand);
        }

        object ICloneable.Clone()
        {
            return Clone();
        }

        public override string ToString()
        {
            return $"Инструмент: {Name}, Бренд: {Brand}";
        }
    }
}
