using System;
using System.Collections.Generic;
using System.Text;

namespace FellowshipChaitanya
{
    class BasicPrograms
    {
        public static void BasicProgramList()
        {
           
                Boolean flag = true;
                while (flag)
                {
                    Console.WriteLine(" ");
                    Console.WriteLine("Basic Program List:");
                    Console.WriteLine("\n1. Addition of Two Numbers\n2. Username  ");
                    Console.WriteLine("3. Flip Coin  \n4. Leap Year");
                    Console.WriteLine("5. Power of Two\n6. Harmonic Number");
                    Console.WriteLine("7. Factors");
                    Console.WriteLine("8. Exit");
                    Console.WriteLine(" ");
                    Console.WriteLine("Enter Your Choice:");
                try
                {
                    int choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            AdditionOfTwoNumbers.AdditionInput();
                            break;
                        case 2:
                            Username.UsernameInput();
                            break;
                        case 3:
                            FlipCoin.TossInput();
                            break;
                        case 4:
                            LeapYear.LeapyaerInput();
                            break;
                        case 5:
                            PowerOfTwo.PowerInput();
                            break;
                        case 6:
                            HarmonicNumber.HarmonicNumberInput();
                            break;
                        case 7:
                            Factors.FactorInput();
                            break;
                        case 8:
                            Console.WriteLine("Basic Program Exit!!");
                            flag = false;
                            break;
                        default:
                            Console.WriteLine("Wrong Choice.\nDo you want to work in Bassic Program List?\nIf yes press 1 ");
                            choice = Convert.ToInt32(Console.ReadLine());
                            if (choice == 1)
                                BasicPrograms.BasicProgramList();
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
