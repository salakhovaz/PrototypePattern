namespace PrototypePattern
{
    public class Drum : PercussionInstrument
    {
        public double Diameter { get; set; }

        public Drum(string name, string brand, string material, double diameter)
            : base(name, brand, material)
        {
            Diameter = diameter;
        }

        public override Instrument Clone()
        {
            return new Drum(this.Name, this.Brand, this.Material, this.Diameter);
        }

        public override string ToString()
        {
            return $"{base.ToString()}, Диаметр: {Diameter}";
        }
    }
}
