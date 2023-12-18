namespace Formkontrollsystem
{
    internal abstract class Form
    {
        public string Navn { get; set; }
        public string Farge { get; set; }

        public abstract double BeregnAreal();
    }
}
