using SharedProject1.CreateFigures;

namespace SharedProject1.CreateFigures
{
	using System;
	using System.Data;
	using System.Net;

    public interface Interface
	{
		public void Draw();
		public void Square();
		public void Perimetr();
	}

	public class Circle : Interface
	{
		static double xCentr;
		static double yCentr;
		static double radius;
		public Circle(string line) 
		{
			string[] words=line.Split(' ');
	        xCentr = Convert.ToDouble(words[1]);
            yCentr = Convert.ToDouble(words[2]);
            radius = Convert.ToDouble(words[3]);
        }
		
		public void Draw()
		{
           
   			Console.WriteLine($"Circle at ({xCentr},{yCentr}), radius is {radius}");
			
		}
		public void Square()
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

	public class Point : Interface
	{
		static double x;
		static double y;
		public Point(string line)
	    {
		   string[] words=line.Split(" ");
            x = Convert.ToDouble(words[1]);
		    y = Convert.ToDouble(words[2]);
	    }
		public void Draw()
		{

			Console.WriteLine($"point at ({x},{y})");
        }
        public void Square()
        {
            Console.WriteLine( "point's square=0");
        }
        public void Perimetr()
        {
            Console.WriteLine("point's perimetr=0");
        }
    }

    public class Rhomb : Interface
    {
		static double x;
        static double y;
        static double h;
        static double w;

		public Rhomb(string line)
		{
			string[] words=line.Split(" ");
			x = Convert.ToDouble(words[1]);
			y = Convert.ToDouble(words[2]);
			h = Convert.ToDouble(words[3]);
			w = Convert.ToDouble(words[4]);
		}
		public void Draw()
		{
			Console.WriteLine($"Rhomb at ({x},{y}), h= {h}, w= {w}");
        }

        public void Square()
        {
            double Sq = h * w * 2;
            Console.WriteLine($"Rhomb's square={string.Format("{0:0.00}", Sq)}");
        }
        public void Perimetr()
        {
            double Per = 4*Math.Sqrt(h * h + w * w);
            Console.WriteLine($"Perimetr's square={string.Format("{0:0.00}", Per)}");
        }
    }

    public class Rectan : Interface
	{
		static double x1;
		static double y1;
		static double x2;
		static double y2;
		public Rectan(string line)
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
		public void Square()
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

	public class Line : Interface
	{
		static double x1;
		static double y1;
		static double x2;
		static double y2;
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

		public void Square()
		{
            Console.WriteLine($"Line's square is 0");
        }

		public void Perimetr()
		{   
			double Katet1 = Math.Abs(x1 - x2);
			double Katet2 = Math.Abs(y1 - y2);
			double Per = Math.Sqrt(Math.Pow(Katet1,2) + Math.Pow(Katet1, 2));
			Console.WriteLine($"Line`s perimetr= {string.Format("{0:0.00}", Per)}");
		}
	}

	public class Foresquare : Interface
	{
		static double x;
		static double y;
		static double l;
		public Foresquare(string line) 
		{
			string[] words = line.Split(' ');
			x = Convert.ToDouble(words[1]); ;
			y = Convert.ToDouble(words[2]);
			l = Convert.ToDouble(words[3]);
		
		}
		public void Draw()
		{
			Console.WriteLine($"Forescuare's hight left corner is ({x},{y}), side length is{l}");
		}
		public void Square()
		{

			double Sq = Math.Pow(l, 2);
			Console.WriteLine($"Foresquare`s square={string.Format("{0:0.00}", Sq)}");
		}
		public void Perimetr()
		{
  			double Per = l * 4;
			Console.WriteLine($"Foresquare`s perimetr= {string.Format("{0:0.00}", Per)}");
		}

	}
    
}