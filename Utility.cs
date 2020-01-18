using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

namespace FellowshipChaitanya
{
    public class Utility
    {
        
        public static double DoubleInput()
        {
            return Convert.ToDouble(Console.ReadLine());
        }
        public static String StringInput()
        {
            return Console.ReadLine();
        }
        public static int IntegerInput()
        {
            return Convert.ToInt32(Console.ReadLine());
        }
        public static void Add(int a, int b)
        {
            int c = a + b;
            Console.WriteLine("Total:" + c);
        }
        public static void UsernameWorking(String input)
        {
            int length = input.Length;
            if (length >= 3)
            {
                Console.WriteLine("Hello " + input);
            }
            else
            {
                Console.WriteLine("enter username with minimum 3 Alphabates.");
                Username.UsernameInput();
            }
        }
        public static void TwoDArray(int row, int column)
        {
            int i, j;
            int[,] array1 = new int[row, column];
            Console.WriteLine("Enter elements" + (row * column) + " in array");
            for (i = 0; i < row; i++)
            {
                for (j = 0; j < column; j++)
                {
                    array1[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            for (i = 0; i < row; i++)
            {
                for (j = 0; j < column; j++)
                {
                    Console.Write(array1[i, j] + "\t");
                }
                Console.WriteLine("");
            }

        }

        public static void AddThreeElements(int input)
        {
            int i, j, k, count = 0;
            int[] array1 = new int[input];
            Console.WriteLine("Enter elements in an array:");
            for (i = 0; i < input; i++)
            {
                array1[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (i = 0; i < input; i++)
            {
                for (j = i + 1; j < input; j++)
                {
                    for (k = j + 1; j < input; k++)
                    {
                        if (k == input)
                            break;
                        if (array1[i] + array1[j] + array1[k] == 0)
                        {
                            Console.WriteLine("Distinct Triplates: " + array1[i] + "," + array1[j] + "," + array1[k]);
                            count++;
                        }
                    }

                }
            }
            Console.WriteLine("Number of Distinct inputs are:" + count);
        }
        public static void EucleadeanDistance(int x, int y)
        {
            int xx = x * x;
            int yy = y * y;
            Double distance = Math.Sqrt(xx + yy);
            Console.WriteLine("Distance from origin of point (" + x + "," + y + ") is:" + distance);
        }

        public static void QuadraticRoots(int a, int b, int c)
        {
            int delta = b * b - 4 * a * c;
            double sdelta = Math.Sqrt(Math.Abs(delta));
            double root1 = (-b + sdelta) / (2 * a);
            double root2 = (-b - sdelta) / (2 * a);
            Console.WriteLine("Root1 of x:" + root1);
            Console.WriteLine("Root2 of x:" + root2);
        }

        public static void Effectivewindchill(float temperature, float speed)
        {
            if (temperature < 50 && (speed > 3 && speed < 120))
            {
                double pspeed = Math.Pow(speed, 0.16);
                double windchill = 35.74 + 0.6215 * temperature + (0.4275 * temperature - 35.75) * pspeed;
                Console.WriteLine("Effective Temperature i.e. windchill:" + windchill);
            }
            else
            {
                Console.WriteLine("You have entered wrong inputs.Check the condition before entering:");
                WindChill.Windchill();
            }
        }
        public static void LeapYearCheck(int year)
        {
            int newyear = year, count = 0;
            while (newyear > 0)
            {
                newyear/= 10;
                count++;
            }

            if (count == 4)
            {
                if ((year % 4 == 0 && year % 100 > 0) || (year % 100 == 0 && year % 400 == 0))
                {
                    Console.WriteLine(year + " is Leap Year");
                }
                else
                {
                    Console.WriteLine(year + " is not Leap Year");
                }
            }
            else
            {
                Console.WriteLine("You entered wrong year");
                LeapYear.LeapyaerInput();
            }
        }
        
        public static void Gamblingcalculator(int stake, int goal)
        {
            Random rand = new Random();
            int bets = 0;
            int wins = 0;
            Console.WriteLine("Enter trials");
            int trials = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < trials; i++)
            {
                int cash = stake;
                while (cash > 0 && cash < goal)
                {
                    bets++;
                    if (rand.Next()*6 < 3.0)
                    {
                        cash++;
                    }
                    else
                    {
                        cash--;
                    }
                }

                if (cash == goal)

                    wins++;

            }
            Console.WriteLine("Wins:" + wins);
            Console.WriteLine("Number of Bets:" + bets);
            Console.WriteLine("Percent of wins" + (wins * 100) / trials);
            Console.WriteLine("Percent of fail:" + ((trials - wins) * 100) /trials);

        }
        
    

        public static void PowerOfTwoCalculation(int power)
        {
            if (power >= 0 && power < 31)
            {
                for (int i = 0; i <= power; i++)
                {
                    Console.WriteLine("2^" + i + "=" + Math.Pow(2, i));
                }
            }
            else
            {
                Console.WriteLine("You entered Wrong Power value.");
                PowerOfTwo.PowerInput();
            }
        }
        public static void Factorscalculator(int number)
        {
            int i;
            int j, flag;
            int newnumber = number;
            if (number == 0 || number == 1)
                Console.WriteLine("Enter Number Greater than 1");

            flag = 1;

            for (j = 2; j <= number / 2; ++j)
            {
                if (number % j == 0)
                {
                    flag = 0;

                }
            }
            if (flag == 1)
                Console.WriteLine(number + " is Prime number so its prime factors is itself number:" + newnumber);
            else
            {
                Console.Write("Prime Factors are:");
                for (i = 2; i * i <= newnumber; i++)
                {
                    while (newnumber % i == 0)
                    {
                        newnumber /= i;
                        Console.Write(i + " ");
                    }
                }
                Console.WriteLine();
            }
        }



        public static void FlipCoinCalculation(int toss)
        {
            Random r = new Random();
            int i;
            int head = 0, tails = 0;
            for (i = 0; i < toss; i++)
            {

                double input = r.NextDouble() * 1.0;
                if (input < 0.5)
                {
                    head++;
                }
                else
                {
                    tails++;
                }

            }
            double percentageofhead = ((head * 100) / toss);
            double percentageoftails= ((tails * 100) / toss);
            Console.WriteLine("Percentage of Heads:" + percentageofhead);
            Console.WriteLine("Percentage of Tails:" + percentageoftails);
        }

        public static void HarmonicNumberCalculation(int number)
        {
            int i;
            Double result = 0;
            if (number > 0)
            {
                for (i = 1; i <= number; i++)
                {
                    result += (1.0 / i);
                }
                Console.WriteLine("The value of " + number + " Harmonic Number is:" + result);
            }
            else
            {
                Console.WriteLine("You Entered wrong input");
                HarmonicNumber.HarmonicNumberInput();
            }
        }
        public static void InsertionSortWork(int[] array)
        {
            int i, j;
            Console.WriteLine("Before Sorting array:");
            Utility.DisplayArray(array);
            for (i = 1; i < array.Length; i++)
            {
                int key = array[i];
                j = i - 1;
                while (j >= 0 && array[j] > key)
                {
                    array[j + 1] = array[j];
                    j -= 1;
                }
                array[j + 1] = key;
            }
            Console.WriteLine("After soring array:");
            Utility.DisplayArray(array);
        }

        /// <summary>
        /// gjgjgjgj  
        /// </summary>
        /// <param name="array">kkkkh</param>
        public static void BubbleSortWork(int[] array)
        {
            Console.WriteLine("Before Sorting array:");
            Utility.DisplayArray(array);
            //gjgjgjgj
            for (int i = 0; i < array.Length - 1; i++)
            {
                //kjhkh
                for (int j = 0; j < array.Length - i - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
            Console.WriteLine("After soring array:");
            Utility.DisplayArray(array);
        }

 

        public static int[] GetInputInArray(int input)
        {
            int i;
            int[] array = new int[input];
            Console.WriteLine("Enter Elements");
            for (i = 0; i < input; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            return array;
        }

        public static void DisplayArray(int[] array)
        {
            int i;
            for (i = 0; i < array.Length; i++)
            {
                if (array[i] != 0)
                {
                    Console.Write(array[i] + "\t");
                }
            }
            Console.WriteLine();
        }

        public static Boolean AnagramCheck(String string1, String string2)
        {
            int i, j;
            char[] array1 = string1.ToCharArray();
            char[] array2 = string2.ToCharArray();
            if (array1.Length != array2.Length)
            {
                return false;
            }

            for (i = 0; i < array1.Length - 1; i++)
            {
                for (j = 0; j < array1.Length - i - 1; j++)
                {
                    if (array1[j] > array1[j + 1])
                    {
                        char temp = array1[j];
                        array1[j] = array1[j + 1];
                        array1[j + 1] = temp;
                    }
                }
            }
            for (i = 0; i < array2.Length - 1; i++)
            {
                for (j = 0; j < array1.Length - i - 1; j++)
                {
                    if (array2[j] > array2[j + 1])
                    {
                        char temp = array2[j];
                        array2[j] = array2[j + 1];
                        array2[j + 1] = temp;
                    }
                }
            }
            for (i = 0; i < array1.Length; i++)
            {
                if (array1[i] != array2[i])
                {
                    return false;

                }
            }
            return true;
        }

        public static int[] PrimeNumberRange(int lower, int upper)
        {

            int i,k=0, j, flag;
            int[] primenumbersarray = new int[500];

            for (i = lower; i <= upper; i++)
            {
                if (i == 0 || i == 1)
                    continue;

                flag = 1;

                for (j = 2; j <= i / 2; ++j)
                {
                    if (i % j == 0)
                    {
                        flag = 0;
                    }
                }
                if (flag == 1)
                {
                    Console.Write(i + "\t");
                    primenumbersarray[k] = i;
                    k++;
                }
            }
            return primenumbersarray;
        }
        public static void PrimeNumberCalculator(int input)
        {
            int j, flag;
            if (input <= 1)
            {
                Console.WriteLine("Enter number greater than one");
                PrimeNumber.PrimeNumberInput();
            }

            flag = 1;

            for (j = 2; j <= input / 2; ++j)
            {
                if (input % j == 0)
                {
                    flag = 0;
                    Console.WriteLine(input + " is not Prime number");
                    break;
                }
            }
            if (flag == 1)
                Console.WriteLine(input + "is a Prime number");

        }

        public static void VendingMachineCalculation(int change, int[] notesarray)
        {
            int i, reminder, notes, flag = 0;
            int copychange = change;
            for (i = 0; i < notesarray.Length; i++)
            {
                if (change / notesarray[i] > 0)
                {
                    reminder = change % notesarray[i];
                    notes = change / notesarray[i];
                    Console.WriteLine(notes + " of " + notesarray[i] + "rs.");
                    change = reminder;
                    flag += notes;
                }
            }
            Console.WriteLine("Minimum " + flag + " Notes are required to get " + copychange + "Rupees");
        }

        public static int DayOfWeekCalculator(int month, int date, int year)
        {
            int yy = year - (14 - month) / 12;
            int x = yy + yy / 4 - yy / 100 + yy / 400;
            int mm = month + 12 * ((14 - month) / 12) - 2;
            int day = (date + x + 31 * mm / 12) % 7;
            return day;
        }
        public static double CelciusToFahreheit(int temperature)
        {
            double result = (temperature * 9 / 5) + 32;
            return result;
        }

        public static double FahrenheitToCelcius(int tempearture)
        {
            double result = (tempearture - 32) * (5 / 9);
            return result;
        }

        public static double MonthlyPaymentCalculator(int loan, int years, double rate)
        {
            Double month = 12 * years;
            Double r = rate / (12 * 100);
            double monthlypayemnt = (loan * r) / 1 - (Math.Pow((1 + r), (-month)));
            return monthlypayemnt;
        }

        public static void NewtonsMethod(Double number)
        {
            Double temp = number;
            Double epsilon = 1e-15;
            while (Math.Abs(temp - number / temp) > epsilon * temp)
            {
                temp = ((number / temp) + temp) / 2;
            }
            Console.WriteLine("Square root of " + number + " is:" + temp);
        }
        public static void DecimalToBinaryconverter(int number)
        {
            int i;
            int[] binary = new int[10];
            for (i = 0; number > 0; i++)
            {
                binary[i] = number % 2;
                number /=  2;
            }
            for (i -= 1; i >= 0; i--)
            {
                Console.Write(binary[i]);
            }
           
        }
        public static int SwapNibbles(int x)
        {
            return ((x & 0x0F) << 4 | (x & 0xF0) >> 4);
        }

        public static void PrimeNumberArray(int lower, int upper)
        {
            int i, j, k = 0, flag;
            int[] array = new int[upper-lower+1];
            for (i = lower; i <= upper; i++)
            {
                if (i == 0 || i == 1)
                    continue;

                flag = 1;

                for (j = 2; j <= i / 2; ++j)
                {
                    if (i % j == 0)
                    {
                        flag = 0;
                    }
                }
                if (flag == 1)
                {
                    Console.Write(i + " ");
                    array[k] = i;
                    k++;
                }
            }
            Console.WriteLine();
            Console.WriteLine("Anagram Prime Number:");
            Utility.PrimeAnagram(array);
            Console.WriteLine();
            Console.WriteLine("Pallindrome Prime NUmber:");
            Utility.PrimePalindrome(array);

        }

        public static void PrimeAnagram(int[] array)
        {
            int i, j, k;
            for (i = 0; i < array.Length; i++)
            {
                for (j = i + 1; j < array.Length; j++)
                {
                    int flag = 0;

                    String string1 = array[i].ToString();
                    String string2 = array[j].ToString();
                    if (string1.Length == string2.Length)
                    {
                        char[] array1 = string1.ToCharArray();
                        char[] array2 = string2.ToCharArray();
                        Array.Sort(array1);
                        Array.Sort(array2);
                        for (k = 0; k < array1.Length; k++)
                        {
                            if (array1[k] != array2[k])
                            {
                                flag++;
                            }
                        }
                        if (flag == 0)
                        {
                            if (array[i] != 0 || array[j] != 0)
                            {
                                Console.Write(string1 + " and" + string2 + "   ");
                            }
                        }
                    }
                }
            }
        }

        public static void PrimePalindrome(int[] array)
        {
            int i;
            for (i = 0; i < array.Length; i++)
            {
                int newnumber = 0, reminder;
                int temp = array[i];
                while (temp > 0)
                {
                    reminder = temp % 10;
                    newnumber = newnumber * 10 + reminder;
                    temp /=10;
                }
                if (newnumber == array[i])
                {
                    if (array[i] != 0)
                    {
                        Console.Write(array[i] + " ");
                    }
                }
            }
        }

        public static void BinarySearchinteger(int[] array, int key)
        {
            int low = 0;
            int high = array.Length - 1;
            int mid = ((low + high) / 2);
            while (low <= high)
            {
                if (key == array[mid])
                {
                    Console.WriteLine("Your Key '" + key + "' is FOUND in an Array.");
                    break;
                }
                else if (key > array[mid])
                {
                    low = (mid + 1);
                    mid = ((low + high) / 2);
                }
                else
                {
                    high = (mid - 1);
                    mid = ((low + high) / 2);
                }
            }
            if (low > high)
            {
                Console.WriteLine("Your Key '" + key + "' does NOT found in Search.");
            }
        }

        public static int BinarySearchString(String[] array, String key)
        {
            int l = 0, r = array.Length - 1;
            while (l <= r)
            {
                int m = l + (r - l) / 2;

                int res = key.CompareTo(array[m]);


                if (res == 0)
                    return m;


                else if (res > 0)
                    l = m + 1;


                else
                    r = m - 1;
            }

            return -1;
        }

        public static void GuessNumberWorking(int lower, int upper)
        {
            int i;
            int[] array = new int[upper - lower + 1];
            for (i = 0; i < array.Length; i++)
            {
                array[i] = lower;
                lower++;
            }
            Console.WriteLine("Think of a number");
            int low = 0;
            int high = array.Length - 1;
            int mid = (low + high) / 2; 
            while (low <= high)
            {
                Console.WriteLine("is " + array[mid] + " your number? Press 1 for YES, Press 0 for NO");
                int answer = Convert.ToInt32(Console.ReadLine());
                if (answer == 1)
                {
                    Console.WriteLine("You have guessed the number : " + array[mid]);
                    break;
                }
                else if (answer == 0)
                {
                    Console.WriteLine("Enter 1 if your number is between " + array[low] + "-" + array[mid]);
                    Console.WriteLine("Enter 2 if your number is between " + array[(mid + 1)] + "-" + array[high]);
                    int choice = Convert.ToInt32(Console.ReadLine());
                    if (choice == 1)
                    {
                        high = mid - 1;
                        mid = (low + high) / 2; 
                    }
                    if (choice == 2)
                    {
                        low = mid + 1;
                        mid = (low + high) / 2;
                        
                    }

                }
                else
                    Console.WriteLine("Element not found");

            }
        }

        public static void Sort(int[] arr, int l, int r)
        {
            if (l < r)
            {

                int m = (l + r) / 2;
                Sort(arr, l, m);
                Sort(arr, m + 1, r);
                Utility.MergesortWorking(arr, l, m, r);
            }
        }
        public static void MergesortWorking(int[] arr, int l, int m, int r)
        {
            int n1 = m - l + 1;
            int n2 = r - m;
            int i, j;
            int[] L = new int[n1];
            int[] R = new int[n2];
            for (i = 0; i < n1; ++i)
                L[i] = arr[l + i];
            for (j = 0; j < n2; ++j)
            {
                R[j] = arr[m + 1 + j];
            }
            i = 0;
            j = 0;
            int k = l;
            while (i < n1 && j < n2)
            {
                if (L[i] <= R[j])
                {
                    arr[k] = L[i];
                    i++;
                }
                else
                {
                    arr[k] = R[j];
                    j++;
                }
                k++;
            }
            while (i < n1)
            {
                arr[k] = L[i];
                i++;
                k++;
            }
            while (j < n2)
            {
                arr[k] = R[j];
                j++;
                k++;
            }
        }
        public static void AllPermutaions(char[] arr)
        {
            int i,j;
            int count = 1;
            for ( i = 1; i < arr.Length; i++)
            {
                j = i + 1;
                char temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
                for (i = 0; i < arr.Length; i++)
                {
                    Console.WriteLine(arr[i]);
                }
                count++;
            }
        }

        public static void CouponNumberWorking(int[] distinctArray)
        {
            Random r = new Random();
            int counter = distinctArray.Length;
            int length = counter;
            int count = 0;
            while (counter > 0)
            { 
                int random = (int)( r.NextDouble() * 10);
                for (int i = 0; i < counter; i++)
                {
                   
                    if (distinctArray[i] == random)
                    {
                        count++;
                        counter--;
                        break;
                    }
                    else
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine("Total random numbers needed to have {0} distinct numbers is {1} ",length,count);
        }

        public static void Permute(String string1, int left, int right)
        {
            
            if (left == right)
            {
                Console.WriteLine(string1);
            }
            else
            {
                for (int i = left; i <= right; i++)
                {
                    string1 = Swap(string1, left, i);
                    Permute(string1, left + 1, right);
                    string1 = Swap(string1, left, i);
                }
            }
        }

        public static String Swap(String string1,int i, int j)
        {
            char temp;
            char[] charArray = string1.ToCharArray();
            temp = charArray[i];
            charArray[i] = charArray[j];
            charArray[j] = temp;
            string s = new string(charArray);
            return s;
        }
        public static void DisplayPrimeArray(int[] array)
        {
            int i;
            for (i = 0; i < array.Length; i++)
            {
                if (array[i] != 0)
                {
                    Console.Write(array[i] + "\t");
                }
            }
            Console.WriteLine();
        }


    }
}

       

