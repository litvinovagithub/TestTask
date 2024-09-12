namespace program
{
    using newReadFile;
    using ShapesLibrary.Models;
    using ShapesLibrary.FigureFactory;
    class Program
    {
        static void Main()
        {

            FigureFactory[] Figures = Shape.CreateObj("salfetka5.txt");
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

