using System;

namespace IterationStatements
{
	class Program
	{
		static void Main(string[] args)
		{
            // Ask the user for input
            Console.Write("Enter an Integer value between 1 and 100 to execute an iterative statement: ");
            /*
               Use the try catch block to validate user input.
               If the user provides bad input, the catch block
               will handle the error and a message will be displayed.
            */
            try
            {
                // This variable will gather data from user input
                string input = Console.ReadLine();
                // This variable will be used to perform the various iterative statements and is parsed as an integer
                int value_of_input = int.Parse(input);
                /* 
                   This conditional IF/ELSE IF/ELSE statement is used to test the values of user input.
                   Depending on the value of the user input between 1 and 20, a different type of 
                   iterative statement will execute. 
                */
                // If the value of user input is between 1 and 5, execute a For Loop
                if ((value_of_input > 0) && (value_of_input <= 100))
                {
                    Console.WriteLine("Executing a Do While Loop!");
                    Console.WriteLine("The Do While Loop will iterate " + value_of_input.ToString() + " times.");
                    // Here is the Do While Loop
                    do
                    {
                        Console.WriteLine("The value of the iterative variable is: " + value_of_input.ToString());
                        value_of_input--;
                    } while (value_of_input > 0);
                    Console.WriteLine("Press any key to exit the program ...");
                    Console.ReadKey(true);
                }
                // If the user does not enter a value between 1 and 20, display a message
                else
                {
                    Console.WriteLine("Please enter an integer between 1 and 100 and try again ...");
                    Console.WriteLine("Press any key to exit the program and try again ...");
                    Console.ReadKey(true);
                }
            } // End of try
            catch
            {
                Console.WriteLine("Please enter an integer value and try running the program again ...");
                Console.WriteLine("Press any key to exit the program ...");
                Console.ReadKey(true);
            } // End of catch
        } // End of Main
    } // End of class
} // End of namespace
