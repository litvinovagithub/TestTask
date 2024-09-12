namespace ShapesLibrary.Models
{
    using ShapesLibrary.IShape;
    public class Line : IShape
    {
        private static double x1;
        private static double y1;
        private static double x2;
        private static double y2;

        public Line(string line)
        {
            string[] words = line.Split(' ');
            x1 = Convert.ToDouble(words[1]);
            y1 = Convert.ToDouble(words[2]);
            x2 = Convert.ToDouble(words[3]);
            y2 = Convert.ToDouble(words[4]);
        }

        public void Draw()
        {
            Console.WriteLine($"Line's point is({x1},{y1}) ({x2},{y2})");
        }

        public void Area()
        {
            Console.WriteLine($"Line's square is 0");
        }

        public void Perimetr()
        {
            double Katet1 = Math.Abs(x1 - x2);
            double Katet2 = Math.Abs(y1 - y2);
            double Per = Math.Sqrt(Math.Pow(Katet1, 2) + Math.Pow(Katet1, 2));
            Console.WriteLine($"Line`s perimetr= {string.Format("{0:0.00}", Per)}");
        }
    }

}