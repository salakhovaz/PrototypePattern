namespace PrototypePattern
{
    public class PercussionInstrument : Instrument
    {
        public string Material { get; set; }

        public PercussionInstrument(string name, string brand, string material)
            : base(name, brand)
        {
            Material = material;
        }

        public override Instrument Clone()
        {
            return new PercussionInstrument(this.Name, this.Brand, this.Material);
        }

        public override string ToString()
        {
            return $"{base.ToString()}, Материал: {Material}";
        }
    }
}
