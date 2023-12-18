namespace Formkontrollsystem
{
    internal class Sirkel : Form
    {
        public double Radius { get; private set; }

        public Sirkel(double radius, string navn, string farge)
        {
            Radius = radius;
            Navn = navn;
            Farge = farge;
        }

        public override double BeregnAreal()
        {
            double R2 = Radius * Radius;
            double Pi = Math.PI;
            double Areal = Pi * R2;
            return Areal;
        }
    }
}
