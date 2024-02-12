namespace Formkontrollsystem
{
    internal abstract class Form
    {
        public string Navn;
        public string Farge;

        protected Form(string navn, string farge)
        {
            Navn = navn;
            Farge = farge;
        }

        public abstract double BeregnAreal();
    }
}
