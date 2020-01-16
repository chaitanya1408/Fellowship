using System;
using System.Collections.Generic;
using System.Text;

namespace FellowshipChaitanya
{
    class TemperatureConversion
    {
        public static void TempeartureConversionInput()
        {
            try
            {
                int result, temperature;
                Console.WriteLine("Enter choice:\n1. Celcius to fahrenheit\n2. Fahrenheit to celcius");
                int choice = Utility.IntegerInput();
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter temperature in celcius");
                        temperature = Utility.IntegerInput();
                        result = (int)Utility.CelciusToFahreheit(temperature);
                        Console.WriteLine("Temperature in Fahrenheit is:" + result);
                        break;
                    case 2:
                        Console.WriteLine("Enter tempearture in fahrenheit");
                        temperature = Utility.IntegerInput();
                        result = (int)Utility.FahrenheitToCelcius(temperature);
                        Console.WriteLine("Temperature in celcius is:" + result);
                        break;
                    default:
                        Console.WriteLine("Exit");
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
