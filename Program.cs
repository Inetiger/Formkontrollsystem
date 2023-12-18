

namespace Formkontrollsystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintEveryShapeAreal();
            PrintShapesInSort();
            PrintColorSort();
        }

        public static List<Form> Shapes = new List<Form>
        {
            new Sirkel(     7,      "Sirkel    ", "Blå    "),
            new Rektangel(  10, 25, "Rektangel ", "Grønn  "),
            new Trekant(    40, 20, "Trekant   ", "Gul    "),
            new Sirkel(     6,      "Sirkel    ", "Lilla  "),
            new Rektangel(  27, 38, "Rektangel ", "Orange "),
            new Trekant(    29, 19, "Trekant   ", "Rosa   "),
        };

        private static void PrintEveryShapeAreal()
        {
            double TotalArea = 0;

            foreach (Form shape in Shapes)
            {
                double Area = shape.BeregnAreal();
                Console.WriteLine($"Form: {shape.Navn} Farge: {shape.Farge} Areal: {Area}");
                TotalArea += Area;
            }

            Console.WriteLine($"\nTotal area: {TotalArea}");
        }

        private static void PrintShapesInSort()
        {
            //foreach (Form shape in Shapes)
            //{
            //    if (sortedList.Count > 0)
            //    {
            //        for (int i = sortedList.Count - 1; i > 0; i--)
            //        {
            //            if (shape.BeregnAreal() > sortedList[i].BeregnAreal()) sortedList.Add(shape);
            //        }
            //    }
            //    else sortedList.Add(shape);
            //}
            //Console.WriteLine("SortedList:");
            //foreach (Form shape in sortedList)
            //{
            //    double Area = shape.BeregnAreal();
            //    Console.WriteLine($"Form: {shape.Navn} Farge: {shape.Farge} Areal: {Area}");
            //}
            List<Form> sortedList = new List<Form>();

            List<Form> copy = new List<Form>();

            foreach (Form form in Shapes)
            {
                copy.Add(form);
            }

            Form HighShape = null;

            while (copy.Count > 0)
            {
                double HighestNumber = 0;

                foreach (Form shape in copy)
                {
                    if (shape.BeregnAreal() > HighestNumber)
                    {
                        HighestNumber = shape.BeregnAreal();
                        HighShape = shape;
                    }
                }

                copy.RemoveAt(copy.IndexOf(HighShape));
                sortedList.Add(HighShape);
            }
            sortedList.Reverse();

            Console.WriteLine("\nSorted List:\n");
            foreach (Form shape in sortedList)
            {
                double Area = shape.BeregnAreal();
                Console.WriteLine($"Form: {shape.Navn} Farge: {shape.Farge} Areal: {Area}");
            }
        }
        private static void PrintColorSort()
        {

            List<Form> sortedList = new List<Form>();

            List<Form> copy = new List<Form>();

            foreach (Form form in Shapes)
            {
                copy.Add(form);
            }

            List<char> alfabet = new List<char>
            {
                'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z',
            };

            foreach (var item in alfabet)
            {
                foreach (var colorName in copy)
                {
                    if (colorName.Farge[0] == item)
                    {
                        sortedList.Add(colorName);
                    }
                }
            }

            Console.WriteLine("\nColorsort List:\n");
            foreach (Form shape in sortedList)
            {
                double Area = shape.BeregnAreal();
                Console.WriteLine($"Form: {shape.Navn} Farge: {shape.Farge} Areal: {Area}");
            }
        }
    }
}
