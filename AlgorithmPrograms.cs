using System;
using System.Collections.Generic;
using System.Text;

namespace FellowshipChaitanya
{
    public class AlgorithmPrograms
    {
        public static void AlgorithmProgramList()
        {
            
                Boolean flag = true;
            while (flag)
            {
                Console.WriteLine(" ");
                Console.WriteLine("Algorithm Program List:");
                Console.WriteLine("\n1. Insrtion sort\n2. Bubble Sort");
                Console.WriteLine("3. Anagram\n4. PrimeNumber");
                Console.WriteLine("5. Vending Machine \n6. Day of Week ");
                Console.WriteLine("7. Temperature Conversion \n8. Monthly Payment ");
                Console.WriteLine("9. Square Root\n10. Decimal to binary ");
                Console.WriteLine("11. Prime  anagram and Pallindrome\n12. Binary Search Number ");
                Console.WriteLine("13. Binary search string \n14. Guess Number");
                Console.WriteLine(" 15. Permutation of string");
                Console.WriteLine("16. String Message using RegEx ");
                Console.WriteLine("17. Exit");
                Console.WriteLine(" ");
                Console.WriteLine("Enter Your Choice:");
                try
                {
                    int choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            InsertionSort.InsertionSortInput();
                            break;
                        case 2:
                            BubbleSort.BubbleSortInput();
                            break;
                        case 3:
                            Anagram.AnagramInput();
                            break;
                        case 4:
                            PrimeNumber.PrimeNumberInput();
                            break;
                        case 5:
                            VendingMachine.VendingMachineInput();
                            break;
                        case 6:
                            DayOfWeek.DayOfWeekInput();
                            break;
                        case 7:
                            TemperatureConversion.TempeartureConversionInput();
                            break;
                        case 8:
                            MonthlyPayment.MonthlyPaymentInput();
                            break;
                        case 9:
                            SquareRoot.SquarerootInput();
                            break;
                        case 10:
                            DecimalToBinary.DecimalInput();
                            break;
                        case 11:
                            PrimeAnagramPalindrome.PrimeAnagramPalindromeInput();
                            break;
                        case 12:
                            BinarySearchInteger.BinarySearchInputInteger();
                            break;
                        case 13:
                            BinarySearchString.BinarySearchInputString();
                            break;
                        case 14:
                            GuessNumber.GuessnumberInput();
                            break;

                        case 15:
                            PermutationString.PermutationStringInput();
                            break;
                        case 16:
                            StringMessage.StringMessageInput();
                            break;
                        case 17:
                            Console.WriteLine("Basic Program Exit!!");
                            flag = false;
                            break;
                        default:
                            Console.WriteLine("Wrong Choice.\nDo you want to work in Bassic Program List?\nIf yes press 1 ");
                            choice = Convert.ToInt32(Console.ReadLine());
                            if (choice == 1)
                                AlgorithmPrograms.AlgorithmProgramList();
                            else
                                flag = false;
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
