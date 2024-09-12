namespace ShapesLibrary.Models
{
    using ShapesLibrary.FigureFactory;
    public class Square : FigureFactory
    {
        private static double x;
        private static double y;
        private static double l;
        public Square(string line)
        {
            string[] words = line.Split(' ');
            x = Convert.ToDouble(words[1]); ;
            y = Convert.ToDouble(words[2]);
            l = Convert.ToDouble(words[3]);

        }
        public void Draw()
        {
            Console.WriteLine($"Scuare's hight left corner is ({x},{y}), side length is{l}");
        }
        public void Area()
        {

            double Sq = Math.Pow(l, 2);
            Console.WriteLine($"Square`s square={string.Format("{0:0.00}", Sq)}");
        }
        public void Perimetr()
        {
            double Per = l * 4;
            Console.WriteLine($"Square`s perimetr= {string.Format("{0:0.00}", Per)}");
        }

    }
}