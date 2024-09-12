namespace program
{
    using ShapeFactory;
    using ShapesLibrary.Models;
    using ShapesLibrary.IShape;
    class Program
    {
        static void Main()
        {

            IShape[] Figures = Shape.CreateObj("salfetka5.txt");
            int len = Figures.Length;
            for (int i = 0; i < len; i++)
            {
                Figures[i].Draw();
                Figures[i].Perimetr();
                Figures[i].Area();

            }


        }
    }



}

