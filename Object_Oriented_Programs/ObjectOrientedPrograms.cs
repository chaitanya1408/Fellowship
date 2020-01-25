


namespace FellowshipChaitanya.Object_Oriented_Programs
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using AddressBook;
    public class ObjectOrientedPrograms
    {
        public static void ObjectOrientedProgramList()
        {
            Boolean flag = true;
            while (flag)
            {
                Console.WriteLine("");
                Console.WriteLine("Object Oriented Program List:");
                Console.WriteLine("1. Address Book");
                Console.WriteLine("2. Exit");
                Console.WriteLine("");
                Console.WriteLine("Enter your choice:");
                try
                {
                    int choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            AddressBook.AddressBook.AddressBookOperations();
                            break;
                        case 2:
                            Console.WriteLine("Exit From Object Oriented Programs");
                            flag = false;
                            break;
                        default:
                            Console.WriteLine("Wrong Choice.\nDo you want to work in Address Book?\nIf yes press 1 ");
                            choice = Convert.ToInt32(Console.ReadLine());
                            if (choice == 1)
                                ObjectOrientedProgramList();
                            else
                                flag = false;
                            break;

                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
    }
}
