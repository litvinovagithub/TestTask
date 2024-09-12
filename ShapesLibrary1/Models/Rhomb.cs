namespace ShapesLibrary.Models
{
    using ShapesLibrary.FigureFactory;
    public class Rhomb : FigureFactory
    {
        private static double x;
        private static double y;
        private static double h;
        private static double w;

        public Rhomb(string line)
        {
            string[] words = line.Split(" ");
            x = Convert.ToDouble(words[1]);
            y = Convert.ToDouble(words[2]);
            h = Convert.ToDouble(words[3]);
            w = Convert.ToDouble(words[4]);
        }
        public void Draw()
        {
            Console.WriteLine($"Rhomb at ({x},{y}), h= {h}, w= {w}");
        }

        public void Area()
        {
            double Sq = h * w * 2;
            Console.WriteLine($"Rhomb's square={string.Format("{0:0.00}", Sq)}");
        }
        public void Perimetr()
        {
            double Per = 4 * Math.Sqrt(h * h + w * w);
            Console.WriteLine($"Rhomb's square={string.Format("{0:0.00}", Per)}");
        }
    }
}