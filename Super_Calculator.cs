﻿using System;

namespace SuperCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Super Calculator";
            Console.WindowHeight = 45;

            // Title Screen

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Welcome to 'Super Calculator!' \n");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Press 'Enter' to start.");
            Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Select A Game! \n");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("(Type the name of a Game below and press 'Enter') \n");

            // Features

            Console.WriteLine("[Calculator] \n");
            Console.WriteLine("[Math Quiz] \n");
            Console.WriteLine("[Guess The Number] \n");
            Console.WriteLine("[Dice Roll] \n");
            Console.WriteLine("[Double Dice Roll] \n");

            string feature = Console.ReadLine();

            switch (feature)
            {

                // Calculator

                case "calculator" or "Calculator" or "CALCULATOR":
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("\nWelcome to 'Calculator!' \n");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Press 'Enter' to start.");
                    Console.ReadLine();

                    // Choices

                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Please Choose One. \n");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("[Addition] \n");
                    Console.WriteLine("[Subtraction] \n");
                    Console.WriteLine("[Multiplication] \n");
                    Console.WriteLine("[Division] \n");
                    Console.WriteLine("[Exponent] \n");
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.WriteLine("[Exponent Loop] \n");
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("[Average] \n");
                    Console.ForegroundColor = ConsoleColor.White;

                    double num01, num02, num03, num04, num05, num06, num07, num08, num09, num10;
                    double sum;
                    double difference;
                    double product;
                    double quotient;
                    double exponent;
                    double avg02, avg03, avg04, avg05, avg06, avg07, avg08, avg09, avg10;
                    int num;
                    string choice01 = Console.ReadLine();

                    switch (choice01)
                    {

                        // Addition

                        case "addition" or "Addition" or "ADDITION":
                            Console.WriteLine("Please input a number.");
                            num01 = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Please input a second number.");
                            num02 = Convert.ToDouble(Console.ReadLine());
                            sum = Convert.ToDouble(num01 + num02);
                            Console.WriteLine(num01 + " + " + num02 + " = " + sum + ".");
                            break;

                        // Subtraction

                        case "subtraction" or "Subtraction" or "SUBTRACTION":
                            Console.WriteLine("Please input a number.");
                            num01 = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Please input a second number.");
                            num02 = Convert.ToDouble(Console.ReadLine());
                            difference = Convert.ToDouble(num01 - num02);
                            Console.WriteLine(num01 + " - " + num02 + " = " + difference + ".");
                            break;

                        // Multiplication

                        case "multiplication" or "Multiplication" or "MULTIPLICATION":
                            Console.WriteLine("Please input a number.");
                            num01 = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Please input a second number.");
                            num02 = Convert.ToDouble(Console.ReadLine());
                            product = Convert.ToDouble(num01 * num02);
                            Console.WriteLine(num01 + " x " + num02 + " = " + product + ".");
                            break;


                        // Division

                        case "division" or "Division" or "DIVISION":
                            Console.WriteLine("Please input a number.");
                            num01 = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Please input a second number.");
                            num02 = Convert.ToDouble(Console.ReadLine());
                            quotient = Convert.ToDouble(num01 / num02);
                            Console.WriteLine(num01 + " / " + num02 + " = " + quotient + ".");
                            break;

                        // Exponent

                        case "exponent" or "Exponent" or "EXPONENT":
                            Console.WriteLine("Please input a number.");
                            num01 = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Please input a second number.");
                            num02 = Convert.ToDouble(Console.ReadLine());
                            exponent = Convert.ToDouble(Math.Pow(num01, num02));
                            Console.WriteLine(num01 + " to the power of " + num02 + " = " + exponent + ".");
                            break;

                        // Exponent Loop

                        case "exponent loop" or "Exponent loop" or "exponent Loop" or "Exponent Loop" or "EXPONENT LOOP" or "exponentloop" or "EXPONENTLOOP":
                            Console.WriteLine("Please input a number.");
                            num01 = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("How many times would you like " + num01 + " to multiply itself by " + num01 + "?");
                            num02 = Convert.ToDouble(Console.ReadLine());

                            for (double i = 1; i <= num02; i++)
                            {
                                double result = (Math.Pow(num01, i));
                                Console.Write("\n" + result);
                            }

                            break;

                        // Average

                        case "average" or "Average" or "AVERAGE":
                            Console.WriteLine("How many numbers would you like to find the average of? \n");
                            Console.WriteLine("(Pick a number from 2 - 10) \n");
                            num = Convert.ToInt32(Console.ReadLine());

                            switch (num)
                            {
                                case 2:
                                    Console.WriteLine("Please input a number.");
                                    num01 = Convert.ToDouble(Console.ReadLine());
                                    Console.WriteLine("Please input a second number.");
                                    num02 = Convert.ToDouble(Console.ReadLine());
                                    avg02 = Convert.ToDouble((num01 + num02) / 2);
                                    Console.WriteLine("The average of these numbers is " + avg02 + ".");
                                    break;

                                case 3:
                                    Console.WriteLine("Please input a number.");
                                    num01 = Convert.ToDouble(Console.ReadLine());
                                    Console.WriteLine("Please input a second number.");
                                    num02 = Convert.ToDouble(Console.ReadLine());
                                    Console.WriteLine("Please input a third number.");
                                    num03 = Convert.ToDouble(Console.ReadLine());
                                    avg03 = Convert.ToDouble((num01 + num02 + num03) / 3);
                                    Console.WriteLine("The average of these numbers is " + avg03 + ".");
                                    break;

                                case 4:
                                    Console.WriteLine("Please input a number.");
                                    num01 = Convert.ToDouble(Console.ReadLine());
                                    Console.WriteLine("Please input a second number.");
                                    num02 = Convert.ToDouble(Console.ReadLine());
                                    Console.WriteLine("Please input a third number.");
                                    num03 = Convert.ToDouble(Console.ReadLine());
                                    Console.WriteLine("Please input a fourth number.");
                                    num04 = Convert.ToDouble(Console.ReadLine());
                                    avg04 = Convert.ToDouble((num01 + num02 + num03 + num04) / 4);
                                    Console.WriteLine("The average of these numbers is " + avg04 + ".");
                                    break;

                                case 5:
                                    Console.WriteLine("Please input a number.");
                                    num01 = Convert.ToDouble(Console.ReadLine());
                                    Console.WriteLine("Please input a second number.");
                                    num02 = Convert.ToDouble(Console.ReadLine());
                                    Console.WriteLine("Please input a third number.");
                                    num03 = Convert.ToDouble(Console.ReadLine());
                                    Console.WriteLine("Please input a fourth number.");
                                    num04 = Convert.ToDouble(Console.ReadLine());
                                    Console.WriteLine("Please input a fifth number.");
                                    num05 = Convert.ToDouble(Console.ReadLine());
                                    avg05 = Convert.ToDouble((num01 + num02 + num03 + num04 + num05) / 5);
                                    Console.WriteLine("The average of these numbers is " + avg05 + ".");
                                    break;

                                case 6:
                                    Console.WriteLine("Please input a number.");
                                    num01 = Convert.ToDouble(Console.ReadLine());
                                    Console.WriteLine("Please input a second number.");
                                    num02 = Convert.ToDouble(Console.ReadLine());
                                    Console.WriteLine("Please input a third number.");
                                    num03 = Convert.ToDouble(Console.ReadLine());
                                    Console.WriteLine("Please input a fourth number.");
                                    num04 = Convert.ToDouble(Console.ReadLine());
                                    Console.WriteLine("Please input a fifth number.");
                                    num05 = Convert.ToDouble(Console.ReadLine());
                                    Console.WriteLine("Please input a sixth number.");
                                    num06 = Convert.ToDouble(Console.ReadLine());
                                    avg06 = Convert.ToDouble((num01 + num02 + num03 + num04 + num05 + num06) / 6);
                                    Console.WriteLine("The average of these numbers is " + avg06 + ".");
                                    break;

                                case 7:
                                    Console.WriteLine("Please input a number.");
                                    num01 = Convert.ToDouble(Console.ReadLine());
                                    Console.WriteLine("Please input a second number.");
                                    num02 = Convert.ToDouble(Console.ReadLine());
                                    Console.WriteLine("Please input a third number.");
                                    num03 = Convert.ToDouble(Console.ReadLine());
                                    Console.WriteLine("Please input a fourth number.");
                                    num04 = Convert.ToDouble(Console.ReadLine());
                                    Console.WriteLine("Please input a fifth number.");
                                    num05 = Convert.ToDouble(Console.ReadLine());
                                    Console.WriteLine("Please input a sixth number.");
                                    num06 = Convert.ToDouble(Console.ReadLine());
                                    Console.WriteLine("Please input a seventh number.");
                                    num07 = Convert.ToDouble(Console.ReadLine());
                                    avg07 = Convert.ToDouble((num01 + num02 + num03 + num04 + num05 + num06 + num07) / 7);
                                    Console.WriteLine("The average of these numbers is " + avg07 + ".");
                                    break;

                                case 8:
                                    Console.WriteLine("Please input a number.");
                                    num01 = Convert.ToDouble(Console.ReadLine());
                                    Console.WriteLine("Please input a second number.");
                                    num02 = Convert.ToDouble(Console.ReadLine());
                                    Console.WriteLine("Please input a third number.");
                                    num03 = Convert.ToDouble(Console.ReadLine());
                                    Console.WriteLine("Please input a fourth number.");
                                    num04 = Convert.ToDouble(Console.ReadLine());
                                    Console.WriteLine("Please input a fifth number.");
                                    num05 = Convert.ToDouble(Console.ReadLine());
                                    Console.WriteLine("Please input a sixth number.");
                                    num06 = Convert.ToDouble(Console.ReadLine());
                                    Console.WriteLine("Please input a seventh number.");
                                    num07 = Convert.ToDouble(Console.ReadLine());
                                    Console.WriteLine("Please input an eighth number.");
                                    num08 = Convert.ToDouble(Console.ReadLine());
                                    avg08 = Convert.ToDouble((num01 + num02 + num03 + num04 + num05 + num06 + num07 + num08) / 8);
                                    Console.WriteLine("The average of these numbers is " + avg08 + ".");
                                    break;

                                case 9:
                                    Console.WriteLine("Please input a number.");
                                    num01 = Convert.ToDouble(Console.ReadLine());
                                    Console.WriteLine("Please input a second number.");
                                    num02 = Convert.ToDouble(Console.ReadLine());
                                    Console.WriteLine("Please input a third number.");
                                    num03 = Convert.ToDouble(Console.ReadLine());
                                    Console.WriteLine("Please input a fourth number.");
                                    num04 = Convert.ToDouble(Console.ReadLine());
                                    Console.WriteLine("Please input a fifth number.");
                                    num05 = Convert.ToDouble(Console.ReadLine());
                                    Console.WriteLine("Please input a sixth number.");
                                    num06 = Convert.ToDouble(Console.ReadLine());
                                    Console.WriteLine("Please input a seventh number.");
                                    num07 = Convert.ToDouble(Console.ReadLine());
                                    Console.WriteLine("Please input an eighth number.");
                                    num08 = Convert.ToDouble(Console.ReadLine());
                                    Console.WriteLine("Please input a ninth number.");
                                    num09 = Convert.ToDouble(Console.ReadLine());
                                    avg09 = Convert.ToDouble((num01 + num02 + num03 + num04 + num05 + num06 + num07 + num08 + num09) / 9);
                                    Console.WriteLine("The average of these numbers is " + avg09 + ".");
                                    break;

                                case 10:
                                    Console.WriteLine("Please input a number.");
                                    num01 = Convert.ToDouble(Console.ReadLine());
                                    Console.WriteLine("Please input a second number.");
                                    num02 = Convert.ToDouble(Console.ReadLine());
                                    Console.WriteLine("Please input a third number.");
                                    num03 = Convert.ToDouble(Console.ReadLine());
                                    Console.WriteLine("Please input a fourth number.");
                                    num04 = Convert.ToDouble(Console.ReadLine());
                                    Console.WriteLine("Please input a fifth number.");
                                    num05 = Convert.ToDouble(Console.ReadLine());
                                    Console.WriteLine("Please input a sixth number.");
                                    num06 = Convert.ToDouble(Console.ReadLine());
                                    Console.WriteLine("Please input a seventh number.");
                                    num07 = Convert.ToDouble(Console.ReadLine());
                                    Console.WriteLine("Please input an eighth number.");
                                    num08 = Convert.ToDouble(Console.ReadLine());
                                    Console.WriteLine("Please input a ninth number.");
                                    num09 = Convert.ToDouble(Console.ReadLine());
                                    Console.WriteLine("Please input a tenth number.");
                                    num10 = Convert.ToDouble(Console.ReadLine());
                                    avg10 = Convert.ToDouble((num01 + num02 + num03 + num04 + num05 + num06 + num07 + num08 + num09 + num10) / 10);
                                    Console.WriteLine("The average of these numbers is " + avg10 + ".");
                                    break;
                            }

                            break;
                    }

                    break;

                // Math Quiz

                case "math quiz" or "Math quiz" or "math Quiz" or "Math Quiz" or "MATH QUIZ" or "mathquiz" or "MATHQUIZ":
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Welcome to 'Math Quiz!' \n");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Press 'Enter' to start.");
                    Console.ReadLine();

                    // Problems

                    double userAnswer01;
                    double userAnswer02;
                    double userAnswer03;

                    Console.WriteLine("What is 25.5 x 25? \n");
                    userAnswer01 = Convert.ToDouble(Console.ReadLine());

                    switch (userAnswer01)
                    {
                        case 637.5:
                            Console.WriteLine("Correct! \n");
                            break;

                        default:
                            Console.WriteLine("Incorrect. \n");
                            break;
                    }

                    Console.WriteLine("What is 916 / 4? \n");
                    userAnswer02 = Convert.ToDouble(Console.ReadLine());

                    switch (userAnswer02)
                    {
                        case 229:
                            Console.WriteLine("Correct! \n");
                            break;

                        default:
                            Console.WriteLine("Incorrect. \n");
                            break;
                    }

                    Console.WriteLine("What is 2^8? \n");
                    userAnswer03 = Convert.ToDouble(Console.ReadLine());

                    switch (userAnswer03)
                    {
                        case 256:
                            Console.WriteLine("Correct! \n");
                            break;

                        default:
                            Console.WriteLine("Incorrect. \n");
                            break;
                    }

                    break;

                // Guess The Number

                case "guess the number" or "Guess the number" or "guess The number" or "guess the Number" or "Guess The number" or "guess The Number" or "Guess the Number" or "Guess The Number" or "GUESS THE NUMBER" or "guessthenumber" or "GUESSTHENUMBER":
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Welcome to 'Guess The Number!' \n");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Press 'Enter' to start.");
                    Console.ReadLine();
                    break;

                // Dice Roll

                case "dice roll" or "Dice roll" or "dice Roll" or "Dice Roll" or "DICE ROLL" or "diceroll" or "DICEROLL":
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Welcome to 'Dice Roll!' \n");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Press 'Enter' to start.");
                    Console.ReadLine();
                    break;

                // Double Dice Roll

                case "double dice roll" or "Double dice roll" or "double Dice roll" or "double dice Roll" or "Double Dice roll" or "double Dice Roll" or "Double dice Roll" or "Double Dice Roll" or "DOUBLE DICE ROLL" or "doublediceroll" or "DOUBLEDICEROLL":
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("Welcome to 'Double Dice Roll!' \n");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Press 'Enter' to start.");
                    Console.ReadLine();
                    break;
            }

            Console.Read();

        }

    }

}
