using System;


namespace ASSIGNMENT01
{
    internal class calculator
    {
        static void Main(string[] args)
        {
        start:
            int add = 0;
            int sub = 0;
            int multiply = 0;
            int divide = 0;

            Console.WriteLine("enter first number");
            int num1 = int.Parse(Console.ReadLine());


            Console.WriteLine("enter second number");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("choose an operation you wanna perform (ADD,SUBTRACT,MULTIPLY, DIVIDE)");
            string operation = Console.ReadLine().ToLower();
            try
            {
                switch (operation)
                {
                    case "add":
                        add = num1 + num2;
                        Console.WriteLine($"Addition = {add}");
                        break;

                    case "subtract":
                        sub = num1 - num2;
                        Console.WriteLine($"Addition = {sub}");
                        break;

                    case "multiply":
                        multiply = num1 * num2;
                        Console.WriteLine($"Addition = {multiply}");
                        break;

                    case "divide":
                        divide = num1 / num2;
                        Console.WriteLine($"Addition = {divide}");
                        break;
                    default:
                        Console.WriteLine($"invalid choice {operation}, please enter your choice....");
                        goto start;
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        decision:
            Console.WriteLine("do you wanna continue? yes/no");
            string decide = Console.ReadLine().ToLower();

            switch (decide)
            {
                case "yes":
                    goto start;
                case "no":
                    break;
                default:
                    Console.WriteLine($"invalid choice {decide}");
                    goto decision;

            }
            Console.WriteLine("Thank you for your time");

        }


    }
}

