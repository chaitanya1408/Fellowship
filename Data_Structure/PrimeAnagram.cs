using System;
using System.Collections.Generic;
using System.Text;

namespace FellowshipChaitanya
{
    class PrimeAnagram
    {
        public static void PrimeAnagramInput()
        {
            try
            {
                UtilityFunctions utility = new UtilityFunctions();
                int[] primeNumbers = new int[1000];
                int[,] anagramnumbers = new int[10,1000];
                int min = 0, max = 100, k = 0;
                int count = 0;
                for (int i = 1; i <= 1000; i++)
                {
                    if (utility.IsPrime(i))
                    {
                        primeNumbers[count] = i;
                        count++;
                    }
                }

                int[,] array = new int[10, 1000];
                
                for (int i = 0; i < 10; i++)
                {
                    for (int j = 0; j < 100; j++)
                    {
                        if (primeNumbers[k] < max && primeNumbers[k] > min)
                        {
                            array[i, j] = primeNumbers[k];
                            k++;
                        }
                        else
                        {
                            min = max;
                            max = max + 100;
                            break;
                        }
                    }
                }

                for (int i = 0; i < 10; i++)
                {
                    for (int j = 0; j < 100; j++)
                    {
                        if (array[i, j] != 0)
                        {
                            Console.Write(array[i, j] + " ");
                        }
                    }

                    Console.WriteLine();
                }
                
                Console.WriteLine();

                for(int i = 0; i < 10; i++)
                {
                    for (int l = 0; l < 10; l++)
                    {
                        for (int j = 0; j < 100; j++)
                        {
                            if (array[i, j] != 0 && array[i, j + 1] != 0)
                            {
                                int one = array[i, j];
                                int two = array[i, j + 1];
                                if (utility.IsAnagram(one + string.Empty, two + string.Empty))
                                {
                                    if (anagramnumbers[l, k] < max && anagramnumbers[l, k] > min)
                                    {
                                        anagramnumbers[l, k] = one;
                                        k++;
                                        anagramnumbers[l, k + 1] = two;
                                    }
                                    else
                                    {
                                        min = max;
                                        max = max + 100;
                                        break;
                                    }

                                }
                            }
                        }
                    }
                }
                for (int i = 0; i < 10; i++)
                {
                    for (int j = 0; j < 100; j++)
                    {
                        if (anagramnumbers[i, j] != 0)
                        {
                            Console.Write(anagramnumbers[i, j] + " ");
                        }
                    }

                    Console.WriteLine();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
