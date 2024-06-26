﻿using Calculator;
Prompts.PrintWelcomeMenu();

while (true)
{
    myloop:
    Prompts.PrintOptions();
    Console.WriteLine("Enter operation number: ");
    string? OptionChoice = Console.ReadLine();

    if (OptionChoice.Equals("1") || OptionChoice.Equals("2") || OptionChoice.Equals("3") || OptionChoice.Equals("4") || OptionChoice.Equals("5"))
    {
        if (OptionChoice.Equals("5"))
        {
            Console.WriteLine("Exiting gracefully");
            Environment.Exit(0);
            break;
        }        
    }
    else
    {
        Console.WriteLine("Invalid option chosen, read options carefully and enter again");
     goto myloop;
    }

    float Number1Converted, Number2Converted;
    Console.WriteLine("Enter number 1: ");
    string? Number1 = Console.ReadLine();

    if (!float.TryParse(Number1, out Number1Converted))
    {
        Console.WriteLine("You had entered invalid input for number 1, enter valid inputs");
        goto myloop;
    }
    Console.WriteLine("Enter number 2: ");
    string? Number2 = Console.ReadLine();
    if (!float.TryParse(Number2, out Number2Converted))
    {
        Console.WriteLine("You had entered invalid input for number 2, enter valid inputs");
        goto myloop;
    }
//    float Number1Converted = float.Parse(Number1);
  //  float Number2Converted = float.Parse(Number2);
    switch (OptionChoice)
    {
        case "1":
            float Sum = Evaluator.Eval("+", Number1Converted, Number2Converted);
            Console.WriteLine("The output for addition is as below");
            Console.WriteLine($"{Number1Converted} + {Number2Converted} = {Sum}");
            Console.WriteLine("####################################################");
            Console.WriteLine("Enter new input for calculation from below options");
            break;
        case "2":
            float Subtract = Evaluator.Eval("-", Number1Converted, Number2Converted);
            Console.WriteLine("The output for subtraction is as below");
            Console.WriteLine($"{Number1Converted} - {Number2Converted} = {Subtract}");
            Console.WriteLine("####################################################");
            Console.WriteLine("Enter new input for calculation from below options");
            break;
        case "3":
            float Product = Evaluator.Eval("*", Number1Converted, Number2Converted);
            Console.WriteLine("The output for multiplication is as below");
            Console.WriteLine($"{Number1Converted} * {Number2Converted} = {Product}");
            Console.WriteLine("####################################################");
            Console.WriteLine("Enter new input for calculation from below options");
            break;
        case "4":
            float Division = Evaluator.Eval("/", Number1Converted, Number2Converted);
            Console.WriteLine("The output for division is as below");
            Console.WriteLine($"{Number1Converted} / {Number2Converted} = {Division}");
            Console.WriteLine("####################################################");
            Console.WriteLine("Enter new input for calculation from below options");
            break;
        default:
            throw new Exception("unimplemented");
    }
}