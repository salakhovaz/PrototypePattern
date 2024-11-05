namespace PrototypePattern
{
    public class Guitar : StringInstrument
    {
        public string GuitarType { get; set; }

        public Guitar(string name, string brand, int numberOfStrings, string guitarType)
            : base(name, brand, numberOfStrings)
        {
            GuitarType = guitarType;
        }

        public override Instrument Clone()
        {
            return new Guitar(this.Name, this.Brand, this.NumberOfStrings, this.GuitarType);
        }

        public override string ToString()
        {
            return $"{base.ToString()}, Тип гитары: {GuitarType}";
        }
    }
}
