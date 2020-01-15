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
            while(flag)
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
                Console.WriteLine("15. Merge sort ");
                Console.WriteLine("16. Exit");
                Console.WriteLine(" ");
                Console.WriteLine("Enter Your Choice:");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        InsertionSort.insertionSortInput();
                        break;
                    case 2:
                        BubbleSort.bubbleSortInput();
                        break;
                    case 3:
                        Anagram.anagramInput();
                        break;
                    case 4:
                        PrimeNumber.primeNumberInput();
                        break;
                    case 5:
                        VendingMachine.vendingMachineInput();
                        break;
                    case 6:
                        DayOfWeek.dayOfWeekInput();
                        break;
                    case 7:
                        TemperatureConversion.tempeartureConversionInput();
                        break;
                    case 8:
                        MonthlyPayment.monthlyPaymentInput();
                        break;
                    case 9:
                        SquareRoot.squarerootInput();
                        break;
                    case 10:
                        DecimalToBinary.decimalInput();
                        break;
                    case 11:
                        PrimeAnagramPalindrome.primeAnagramPalindrome();
                        break;
                    case 12:
                        BinarySearchInteger.binarySearchInputInteger();
                        break;
                    case 13:
                        BinarySearchString.binarySearchInputString();
                        break;
                    case 14:
                        GuessNumber.guessnumberInput();
                        break;
                    case 15:
                        MergeSort.mergeSortInput();
                        break;
                    case 16:
                        Console.WriteLine("Basic Program Exit!!");
                        flag = false;
                        break;
                    default:
                        Console.WriteLine("Wrong Choice.\nDo you want to work in Bassic Program List?\nIf yes press 1 ");
                        choice = Convert.ToInt32(Console.ReadLine());
                        if (choice == 1)
                            BasicPrograms.basicProgramList();
                        else
                            flag = false;
                        break;
                }
            }
        }
    }
}
