using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)

        {


            Class class1 = new Class();
           step1:
            Console.Write("Please Select an action :[+], [-], [*], [/] ");
            string action = Console.ReadLine();
            if (action == "+" || action == "-" || action == "*" || action == "/")
            {
                Console.Write("Please enter 1st variable ");
                double num1 = Convert.ToDouble(Console.ReadLine());
            step2:
                Console.Write("Please enter 2nd variable ");
                double num2 = Convert.ToDouble(Console.ReadLine());



                double result;
                switch (action)
                {
                    case "+":
                        result = class1.SumNumbers(num1, num2);
                        break;
                    case "-":
                        result = class1.DeductNumbers(num1, num2);

                        break;
                    case "*":
                        result = class1.MultiplyNumbers(num1, num2);

                        break;
                    case "/":
                        if (num2 != 0)
                        {
                            result = class1.DevideNumbers(num1, num2);

                        }
                        else
                        {
                            Console.WriteLine("Can't Devide To 0");
                            Console.WriteLine("Please, push any button and TRY AGAIN");
                            Console.ReadKey();
                            goto step2;
                        }
                        break;
                    default:
                        Console.WriteLine("Selected acction is none of recommended: [+], [-], [*], [/]");
                        Console.WriteLine("Please, push any button and TRY AGAIN");
                        Console.ReadKey();
                        goto step1;

                }
                        Console.WriteLine($"The Result of Calculation is: {result}");

            }
            else
            {
                        Console.WriteLine("Selected acction is none of recommended: [+], [-], [*], [/]");
                        Console.WriteLine("Please, push any button and TRY AGAIN");
                        Console.ReadKey();
                        goto step1;

            }
            Console.ReadKey();

        }
           

    }
 }

