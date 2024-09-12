namespace newReadFile
{
    using System;
    using ShapesLibrary.FigureFactory;
    using ShapesLibrary.Models;
    using System.Data;
    using System.Net;
    using System.Xml.Linq;
    public class Shape
    {
        public static FigureFactory[] CreateObj(string filePath)
        {
            string[] lines = File.ReadAllLines(filePath);
            int length = lines.Length;
            FigureFactory[] obj = new FigureFactory[length];
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
