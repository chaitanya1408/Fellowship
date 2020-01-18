using System;
using System.Collections.Generic;
using System.Text;

namespace FellowshipChaitanya
{
    class List
    {
        public static void ListExample1()
        {
            List<int> names = new List<int>();
            Console.WriteLine("Enter how many elemnts do you want to add");
            int input = Convert.ToInt32(Console.ReadLine());
            int i;
            Console.WriteLine("Enter elemnts:");
            for (i = 0; i < input; i++)
            {
                names.Add(Convert.ToInt32(Console.ReadLine()));
            }
            Console.WriteLine("Elements are:");
            foreach (int element in names)
            {
                Console.WriteLine(element);
            }
        }
    }
}
