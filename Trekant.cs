using System;

namespace Formkontrollsystem
{
    internal class Trekant : Form
    {
        public int Base { get; set; }
        public int Høyde { get; set; }

        public Trekant(int @base, int høyde, string navn, string farge)
        {
            Base = @base;
            Høyde = høyde;
            Navn = navn;
            Farge = farge;
        }
        
        public override double BeregnAreal()
        {
            double HalfBase = Base / 2;
            double Areal = HalfBase * Høyde;
            return Areal;
        }
    }
}
