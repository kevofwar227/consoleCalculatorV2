using System;

namespace consoleCalculatorV2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Operation Selection
            Console.WriteLine("Choose an operation: ");
            Console.WriteLine("1 add");
            Console.WriteLine("2 subtract");
            Console.WriteLine("3 multiply");
            Console.WriteLine("4 divide");

            int operatorSelection = Convert.ToInt32(Console.ReadLine());

            //sets up the different operations
            if (operatorSelection == 1)
            {
                //add
                Console.WriteLine("Current selected operation: Addition");

                int x, y;
                Console.WriteLine("Enter a number: ");
                x = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter another number: ");
                y = Convert.ToInt32(Console.ReadLine());
                int output = x + y;
                Console.WriteLine("Your output is: " + output);

            }else if (operatorSelection == 2)
            {
                //subtract
                Console.WriteLine("Current selected operation: Subtraction");

                int x, y;
                Console.WriteLine("Enter a number: ");
                x = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter another number: ");
                y = Convert.ToInt32(Console.ReadLine());
                int output = x - y;
                Console.WriteLine("Your output is: " + output);
            }
            else if (operatorSelection == 3)
            {
                //multiply
                Console.WriteLine("Current selected operation: Multiplication");

                int x, y;
                Console.WriteLine("Enter a number: ");
                x = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter another number: ");
                y = Convert.ToInt32(Console.ReadLine());
                int output = x * y;
                Console.WriteLine("Your output is: " + output);
            }
            else if (operatorSelection == 4)
            {
                //divide
                Console.WriteLine("Current selected operation: Division");

                int x, y;
                Console.WriteLine("Enter a number: ");
                x = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter another number: ");
                y = Convert.ToInt32(Console.ReadLine());
                int output = x / y;
                Console.WriteLine("Your output is: " + output);
            }
            else
            {
                //if any other input is entered, this is the error message
                Console.WriteLine("An Error occured, this is most likely due to an invalid operator selection.");
            }
                }
        }
    }
