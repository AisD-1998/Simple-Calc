using System;

namespace SimpleCalculator
{
   public class Program
    {
        static void Main(string[] args)
        {
            bool endApp = false;
            // display the title as the c# console calculator app.
            Console.WriteLine("Console Calculator in c#\r");
            Console.WriteLine("--------------------------\n");
            while (!endApp)
            {
                //Declare variables and set to empty
                string numInput1 = "";
                string numInput2 = "";
                double result = 0;

                //Ask the user to type the first number
                Console.Write("type a number,and then press enter:");
                numInput1 = Console.ReadLine();

                double CleanNum1 = 0;
                while(!double.TryParse(numInput1, out CleanNum1))
                {
                    Console.Write("This is not a valid input. Please enter an integer value\n");
                    numInput1 = Console.ReadLine();
                }

                //Ask the user to type the secend number.
                Console.Write("Type another number, and the, press Ente:");
                numInput2 = Console.ReadLine();

                double cleanNum2 = 0;
                while(!double.TryParse(numInput2, out cleanNum2))
                {
                    Console.Write("This is not a valid input. Please enter an integer\n");
                    numInput2 = Console.ReadLine();

                }

                //Ask the user to choose an operator
                Console.WriteLine("Choose an operator from the following list :");
                Console.WriteLine("\ta - Add");
                Console.WriteLine("\ts - Substract");
                Console.WriteLine("\tm - Multiply");
                Console.WriteLine("\td - Devide");
                Console.Write("Your Option ?");

                string op = Console.ReadLine();
                try
                {
                    result = Calculator.DoOperation(CleanNum1, cleanNum2, op);
                    if (double.IsNaN(result))
                    {
                        Console.WriteLine("This operation will result in a matematical error. \n ");
                    }
                    else Console.WriteLine("Your result : {0:0.##}\n", result);
                }
                catch(Exception e)
                {
                    Console.WriteLine("Oh no! An exception occured trying to do the math. \n -Details: " + e.Message);
                }
                Console.WriteLine("--------------------\n");
                // Wait for the user to respond befor closing.
                Console.WriteLine("Press 'n' and Enter to close the app, or press any other key and Enter to continue: ");
                if (Console.ReadLine() == "n") endApp = true;
                Console.WriteLine("\n");//Friendly linedpacing.

            }
            return;
        }
    }
}
