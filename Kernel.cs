using System;
using System.Collections.Generic;
using System.Text;
using Sys = Cosmos.System;

namespace NewbKernel
{
    public class Kernel : Sys.Kernel
    {
        protected override void BeforeRun()
        {
            Console.WriteLine("Welcome to NewbKernel by Kavin Jindal :)");
        }

        protected override void Run()
        {
            
            Console.WriteLine("\n\n\t [=] Kernel Version: Pre Alpha 0.0.1");
            Console.WriteLine("\n\n\t [=] Developer: Kavin Jindal");
            Console.WriteLine("\n\n\t [=] Release Date: 12/11/21");
            Console.WriteLine("\n\n\t [!] Write help to know the commands");
            Console.WriteLine(" ");
            Console.WriteLine(" ");

            //var input = Console.ReadLine();
            Console.Write("Type here> ");
            var command = Console.ReadLine();
            int i = 1;
            //while (i > 2) {
            if (command == "help")
            {

                Console.WriteLine("\n Help Section for NewbKernel");
                Console.WriteLine("You can use the following commands in the Kernel");
                Console.WriteLine("[help] -- to view this message");
                //Console.WriteLine("[calculator] -- to use a very basic CLI calculator");
                Console.WriteLine("[credits] -- to view the credits");
                Console.Write("Type here> ");
                Console.ReadLine();

            }
            else if (command == "credits")
            {
                Console.WriteLine("\nCredits for NewbKernel");
                Console.WriteLine("Kernel Developed using CosmOS");
                Console.WriteLine("Developer: Kavin Jindal");
                Console.WriteLine("Github: @kavin-jindal");
                Console.Write("Type here> ");
                Console.ReadLine();
            }
            
            else if (command == "calculator")
            {

                Console.WriteLine("\n NewbKernel Calculator");
                Console.WriteLine("  ");

                Console.Write("Enter the first number>> ");
                double num1 = Double.Parse(Console.ReadLine());

                Console.Write("Enter the second number>> ");
                double num2 = Double.Parse(Console.ReadLine());

                Console.Write("Enter the operator>> ");
                string op = Console.ReadLine();
                
                {
                    if (op == "+")
                    {
                        Console.Write("Result: " + (num1 + num2));
                        Console.ReadLine();
                    }
                    else if (op == "-")
                    {
                        Console.Write("Result: " + (num1 - num2));
                        Console.ReadLine();
                    }
                    else if (op == "*" || op == "x")
                    {
                        Console.Write("Result: " + (num1 * num2));
                        Console.ReadLine();


                    }
                    else if (op == "/")
                    {
                        Console.WriteLine("Result: " + (num1 / num2));
                        Console.ReadLine();
                    }

                    else
                    {
                        Console.Write("[ERROR!] Invalid Operator");
                        Console.ReadLine();
                    }

                        Console.ReadLine();

                    }

            }
            else
            {
                Console.WriteLine("Invalid command! Use 'help' to knwo the valid commands");
                Console.ReadLine();
            }
            }

            // while loop

              

        }

        
    }

