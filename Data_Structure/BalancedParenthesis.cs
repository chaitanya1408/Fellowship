//----------------------------------------------------
// <copyright file="BalancedParenthesis.cs" company="Bridgelabz">
// Company copyright tag.
// </copyright>
//----------------------------------------------------
namespace FellowshipChaitanya
{
    using System;
    using System.Text.RegularExpressions;
    

    /// <summary>
    /// BalancedParenthesis as a class
    /// </summary>
    public class BalancedParenthesis
    {
        /// <summary>
        /// BalancedParenthesisFunction as a function
        /// </summary>
        public static void BalancedParenthesisFunction()
        {
            try
            {
                Stack stack = new Stack();
                Console.WriteLine("Enter arithmatic expression");
                String expression = Console.ReadLine();
                char[] expressionarray = new char[expression.Length];

                /// Regex expression to accept elements which is necessary for valid expression \((?>\((?<c>)|[^()]+|\)(?<-c>))*(?(c)(?!))\)
               /* while (!Regex.IsMatch(expression, @"^[0-9-+/*)(]+$"))
                {
                    Console.WriteLine("Enter valid arithmatic expression");
                    expression = Console.ReadLine();
                }*/

                /// iterating to push elements on respective condition
                for (int i = 0; i < expression.Length; i++)
                {
                    if (expressionarray[i] + string.Empty == "(")
                    {
                        stack.Push("(");
                    }

                    if (expressionarray[i] + string.Empty == ")")
                    {
                        stack.Pop();
                    }
                    if (expressionarray[i] + string.Empty == "{")
                    {
                        stack.Push("(");
                    }

                    if (expressionarray[i] + string.Empty == "}")
                    {
                        stack.Pop();
                    }
                    if (expressionarray[i] + string.Empty == "<")
                    {
                        stack.Push("(");
                    }

                    if (expressionarray[i] + string.Empty == ">")
                    {
                        stack.Pop();
                    }
                    if (expressionarray[i] + string.Empty == "[")
                    {
                        stack.Push("(");
                    }

                    if (expressionarray[i] + string.Empty == "]")
                    {
                        stack.Pop();
                    }
                    else
                    {
                        i++;
                    }
                }

                if (stack.IsEmpty())
                {
                    Console.WriteLine("Arithmatic expression is balanced");
                }
                else
                {
                    Console.WriteLine("Arithmatic expression is not balanced");
                }

                Console.WriteLine();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
