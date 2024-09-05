using System;
using SharedProject1.CreateFigures;
using System.Data;
using System.Net;
using System.Xml.Linq;

namespace ReadFileSalfetka
{
    public class taskSalfetka
    {
        public static Interface[] CreateObj(string filePath)
        {
            string[] lines = File.ReadAllLines(filePath);
            int length = lines.Length;
            Interface[] obj = new Interface[length];
            for (int i = 0; i < length; ++i)
            {
                string line = lines[i];
                string[] words = line.Split(' ');
                string name = words[0];

                if (name == "rect")
                {
                    obj[i] = new Rectan(line);
                }
                if (name == "point")
                {   
                    obj[i] = new Point(line);
                }
                if (name == "line")
                {
                    obj[i] = new Line(line);
                }
                if (name == "foresquare")
                {
                    obj[i] = new Foresquare(line);
                }
                if (name == "circle")
                {
                    obj[i] = new Circle(line);
                }

            }
            return obj;
        }
        
    }
}
