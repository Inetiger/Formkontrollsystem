using System;

namespace Formkontrollsystem
{
    internal class Rektangel : Form
    {
        public int Lengde { get; private set; }
        public int Bredde { get; private set; }
        
        public Rektangel(int lengde, int bredde, string navn, string farge)
        {
            Lengde = lengde;
            Bredde = bredde;
            Navn = navn;
            Farge = farge;
        }
        
        public override double BeregnAreal()
        {
            double Areal = Lengde * Bredde;
            return Areal;
        }
    }
}
