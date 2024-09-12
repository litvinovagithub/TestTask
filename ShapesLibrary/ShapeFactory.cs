namespace ShapeFactory
{
    using System;
    using ShapesLibrary.IShape;
    using ShapesLibrary.Models;
   
    public class Shape
    {
        public static IShape[] CreateObj(string filePath)
        {
            string[] lines = File.ReadAllLines(filePath);
            int length = lines.Length;
            IShape[] obj = new IShape[length];
            for (int i = 0; i < length; ++i)
            {
                string line = lines[i];
                string[] words = line.Split(' ');
                string name = words[0];

                if (name == "rect")
                {
                    obj[i] = new Rectangular(line);
                    continue;
                }
                if (name == "point")
                {
                    obj[i] = new Point(line);
                    continue;   
                }
                if (name == "line")
                {
                    obj[i] = new Line(line);
                    continue;
                }
                if (name == "square")
                {
                    obj[i] = new Square(line);
                    continue;
                }
                if (name == "circle")
                {
                    obj[i] = new Circle(line);
                    continue;
                }

            }
            return obj;
        }

    }
}
