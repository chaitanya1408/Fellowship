

namespace FellowshipChaitanya
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Text.RegularExpressions;
    public class Data_Structure_Programs
    {
        public static void Data_Structure_Program_List()
        {
            bool exit = false;
          

            while (!exit)
            {
                Console.WriteLine("1: UnOrdered List");
                Console.WriteLine("2: Ordered List");
                Console.WriteLine("3: BalancedParenthesis");
                Console.WriteLine("4: BankingCashCounter");
                Console.WriteLine("5: PalindromeChecker");
                Console.WriteLine("6: HashChain");
                Console.WriteLine("7: PrimeNumbers");
                Console.WriteLine("8: PrimeAnagram By Stack");
                Console.WriteLine("9: PrimeAnagram By Queue");
                Console.WriteLine("10: Calender");
                Console.WriteLine("11: Calender By Queue");
                Console.WriteLine("0: Exit");
                string input = Console.ReadLine();

                
                {
                    int num = Convert.ToInt32(input);
                    switch (num)
                    {
                        case 1:
                            UnOrderedList.UnOrderedListFunction();
                            break;

                        case 2:
                            OrderedList.OrderedListFunction();
                            break;

                        case 3:
                            BalancedParenthesis.BalancedParenthesisFunction();
                            break;

                        case 4:
                            BankingCashCounter.BankingCashCounterFunction();
                            break;

                        case 5:
                            PalindromeChecker.PalindromeCheckerFunction();
                            break;

                        case 6:
                            HashChain.HashChainFunction();
                            break;

                        case 7:
                            PrimeNumbers.TwoDimensionArray();
                            break;

                        case 8:
                            PrimeAnagramStack.PrimeAndAnagram();
                            break;

                        case 9:
                            PrimeAnagramQueue.PrimeAndAnagram();
                            break;

                        case 10:
                            Calender.CalenderFunction();
                            break;

                        case 11:
                            CalenderByQueue.DisplayCalender();
                            break;

                        case 0:
                            exit = true;
                            break;

                        default:
                            Console.WriteLine("Invalid input");
                            Console.WriteLine();
                            break;
                    }
                }
               
            }
        }
    }
}
