namespace Formkontrollsystem
{
    internal class Triangle : Form
    {
        public double Base;
        public double Høyde;

        public Triangle(string navn, string farge, double @base, double høyde) : base(navn, farge)
        {
            Base = @base;
            Høyde = høyde;
        }

        public override double BeregnAreal()
        {
            return Base * Høyde / 2;
        }
    }
}
