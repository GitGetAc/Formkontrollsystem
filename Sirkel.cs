namespace Formkontrollsystem
{
    internal class Sirkel : Form
    {
        public double Radius;

        public Sirkel(string navn, string farge, double radius) : base(navn, farge)
        {
            Radius = radius;
        }

        public override double BeregnAreal()
        {
            return Radius * Radius * Math.PI;
        }
    }
}
