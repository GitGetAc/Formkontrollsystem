namespace Formkontrollsystem
{
    internal class Rektangel : Form
    {
        public double Lengde;
        public double Bredde;

        public Rektangel(string navn, string farge, double lengde, double bredde) : base(navn, farge)
        {
            Lengde = lengde;
            Bredde = bredde;
        }

        public override double BeregnAreal()
        {
            return Lengde * Bredde;
        }
    }
}
