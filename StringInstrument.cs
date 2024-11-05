namespace PrototypePattern
{
    public class StringInstrument : Instrument
    {
        public int NumberOfStrings { get; set; }

        public StringInstrument(string name, string brand, int numberOfStrings)
            : base(name, brand)
        {
            NumberOfStrings = numberOfStrings;
        }

        public override Instrument Clone()
        {
            return new StringInstrument(this.Name, this.Brand, this.NumberOfStrings);
        }

        public override string ToString()
        {
            return $"{base.ToString()}, Кол-во струн: {NumberOfStrings}";
        }
    }
}
