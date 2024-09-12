namespace ShapesLibrary.Models
{
    using ShapesLibrary.FigureFactory;
    public class Rectangular : FigureFactory
    {
        private static double x1;
        private static double y1;
        private static double x2;
        private static double y2;
        public Rectangular(string line)
        {
            string[] words = line.Split(" ");
            x1 = Convert.ToDouble(words[1]);
            y1 = Convert.ToDouble(words[2]);
            x2 = Convert.ToDouble(words[3]);
            y2 = Convert.ToDouble(words[4]);
        }
        public void Draw()
        {
            Console.WriteLine($"Rectangular's diagonal is ({x1},{y1}), ({x2},{y2})");
        }
        public void Area()
        {
            double Side1 = Math.Abs(x1 - x2);
            double Side2 = Math.Abs(y1 - y2);
            double Sq = Side1 * Side2;
            Console.WriteLine($"Rectangular`s square={string.Format("{0:0.00}", Sq)}");
        }
        public void Perimetr()
        {
            double Side1 = Math.Abs(x1 - x2);
            double Side2 = Math.Abs(y1 - y2);
            double Per = 2 * (Side1 + Side2);
            Console.WriteLine($"Rectangular`s perimetr= {string.Format("{0:0.00}", Per)}");

        }
    }
}