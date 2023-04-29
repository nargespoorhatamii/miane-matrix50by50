using System;
namespace project
{
    class test
    {
        public static void Main()
        {
           int[,] a = new int[50,50];

           
            Console.WriteLine("miane:");
            Calc(a);
        }
        private static void Calc(int[,] a)
        {

           
            for (int coulmn = 1; coulmn < 50; coulmn++)
            {
                for (int row = 1; row < 50; row++)
                {
                    for (int i = coulmn; i <coulmn+ 3 && i<50; i++)
                    {
                        for (int j = row; j < row+3 && j<50; j++)
                        {
                            a[i, j]+= (a[i, j])/ 9;
                        }
                    }
                }
            }
            for (int coulmn = 0; coulmn < 50; coulmn++)
            {
                for (int row = 0; row < 50; row++)
                {
                    
                  


                        Console.WriteLine(a[coulmn,row]);

                    
                }
            }

        }
    }
}