namespace PrototypePattern
{
    public class Violin : StringInstrument
    {
        public string Size { get; set; }

        public Violin(string name, string brand, int numberOfStrings, string size)
            : base(name, brand, numberOfStrings)
        {
            Size = size;
        }

        public override Instrument Clone()
        {
            return new Violin(this.Name, this.Brand, this.NumberOfStrings, this.Size);
        }

        public override string ToString()
        {
            return $"{base.ToString()}, Размер: {Size}";
        }
    }
}
