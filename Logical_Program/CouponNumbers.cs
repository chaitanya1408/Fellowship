﻿using System;
using System.Collections.Generic;
using System.Text;

namespace FellowshipChaitanya
{
    public class CouponNumbers
    {
        public static void CouponnumberInput()
        {
            try
            {
                int[] distinctArray = { 6, 0, 1, 2, 8, 9 };
                Utility.CouponNumberWorking(distinctArray);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
