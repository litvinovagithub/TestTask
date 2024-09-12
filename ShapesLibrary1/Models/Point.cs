namespace ShapesLibrary.Models
{
    using ShapesLibrary.FigureFactory;

    public class Point : FigureFactory
    {
        private static double x;
        private static double y;
        public Point(string line)
        {
            string[] words = line.Split(" ");
            x = Convert.ToDouble(words[1]);
            y = Convert.ToDouble(words[2]);
        }
        public void Draw()
        {

            Console.WriteLine($"point at ({x},{y})");
        }
        public void Area()
        {
            Console.WriteLine("point's square=0");
        }
        public void Perimetr()
        {
            Console.WriteLine("point's perimetr=0");
        }
    }
}