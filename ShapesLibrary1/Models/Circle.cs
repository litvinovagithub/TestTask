namespace ShapesLibrary.Models
{
    using ShapesLibrary.FigureFactory;
    public class Circle : FigureFactory
    {
        private static double xCentr;
        private static double yCentr;
        private static double radius;
        public Circle(string line)
        {
            string[] words = line.Split(' ');
            xCentr = Convert.ToDouble(words[1]);
            yCentr = Convert.ToDouble(words[2]);
            radius = Convert.ToDouble(words[3]);
        }

        public void Draw()
        {

            Console.WriteLine($"Circle at ({xCentr},{yCentr}), radius is {radius}");

        }
        public void Area()
        {
            double Sq = Math.PI * radius * radius;
            Console.WriteLine($"Circle`s square= {string.Format("{0:0.00}", Sq)}");
        }
        public void Perimetr()
        {
            double Per = Math.PI * radius * 2;
            Console.WriteLine($"Circle`s perimetr= {string.Format("{0:0.00}", Per)}");

        }

    }
}