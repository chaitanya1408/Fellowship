using System;
using System.Collections.Generic;
using System.Text;

namespace FellowshipChaitanya
{
    class PrimeNumberCheck
    {
        public static void PrimeNumberCheckeInput()
        {
            int i, j = 0,k;
            Console.WriteLine("Enter lower boundary");
            int lower = Utility.IntegerInput();
            Console.WriteLine("Enter upper boundary");
            int upper = Utility.IntegerInput();
            int[] result = new int[lower - upper];
            int[,] numbers = new int[100,100];
            result=Utility.PrimeNumberRange(lower, upper);
            for (i = 0; i < 10;)
            {
                for (j = 0; j < 1000; )
                {
                    while (result[j] < 100 && result[j] > 0)
                    {
                        
                        numbers[i, j] = result[j];
                        j++;
                    }
                    i++;
                    while (result[j] < 200 && result[j] > 100) 
                    {
                        
                        numbers[i, j] = result[j];
                        j++;
                    }
                    i++;
                    while (result[j] < 300 && result[j] > 200)
                    {
                        numbers[i, j] = result[j];
                        j++;
                    }
                    i++;
                    while (result[j] < 400 && result[j] > 300)
                    {
                        numbers[i, j] = result[j];
                        j++;
                    }
                    i++;
                    while (result[j] < 500 && result[j] > 400)
                    {
                        numbers[i, j] = result[j];
                        j++;
                    }
                    i++;
                    while (result[j] < 600 && result[j] > 500)
                    {
                        numbers[i, j] = result[j];
                        j++;
                    }
                    i++;
                    while(result[j] < 700 && result[j] > 600)
                    {
                        numbers[i, j] = result[j];
                        j++;
                    }
                    i++;
                    while (result[j] < 800 && result[j] > 700)
                    {
                        numbers[i, j] = result[j];
                        j++;
                    }
                    i++;
                    while (result[j] < 900 && result[j] > 800)
                    {
                        numbers[i, j] = result[j];
                        j++;
                    }
                    i++;
                    while (result[j] <= 1000 && result[j] > 900)
                    {
                        numbers[i, j] = result[j];
                        j++;
                    }
                    i++;
                }
            }
            for(i=0;i<10;i++)
            {
                for(k=0;k<1000;j++)
                {
                    if (numbers[i,k] != 0)
                    {
                        Console.Write(numbers[i, j]);
                    }
                }
                Console.WriteLine("");
            }
        }
    }
}
