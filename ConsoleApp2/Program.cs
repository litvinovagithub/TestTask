namespace program
{
    using ReadFileSalfetka;
    using SharedProject1.CreateFigures;

    public class fileOperation
    {
        
        class Program
        {
            static void Main()
            {

               Interface[] figures=taskSalfetka.CreateObj("C:/Users/user/source/repos/ConsoleApp2/salfetka.txt");
                int len = figures.Length;
                for (int i = 0; i < len; i++)
                {
                    figures[i].Draw();
                    figures[i].Perimetr();
                    figures[i].Square();
                 
                }


            }
        }

    }
     
   
}

