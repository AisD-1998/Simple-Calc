using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleCalculator
{
    class Calculator
    {
        public static double DoOperation(double num1,double num2,string op)
        {
            double result = double.NaN; //default value is not a number 
            //use a switch statement to do the math 
            switch(op)
            {
                case "a":
                    result = num1 + num2;
                    break;
                case "s":
                    result = num1 - num2;
                    break;
                case "m":
                    result = num1 * num2;
                    break;
                case "d":
                    //ask the user to enter a non-zero divisor
                    if(num2 != 0)
                    {
                       result= num1 / num2;
                    }
                    break;
                //Return text for an incorrect option entry
                default:
                    break;
            }
            return result;
        }
    }
}
