using System;

namespace Get_PI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetPI());
        }//main

        static double GetPI()
        {
             double formulaPI;
            double formulaPITotal = 0;
            double x = 1;
            int j = 1;



            for(int i = 1; i<1000000; i+=2)
            {
                formulaPI = 1 / x  ;
                formulaPITotal += formulaPI;
                x = (i + 2) * Math.Pow (-1, j);
                j++;
                 
                

            }

            return 4 * formulaPITotal ;
        }
    }
}
