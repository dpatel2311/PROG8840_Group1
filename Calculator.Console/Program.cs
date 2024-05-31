using Calculator;

Prompts.PrintWelcomeMenu();
Prompts.PrintOptions();
Console.WriteLine("Enter operation number: ");
string? OptionChoice = Console.ReadLine();
Console.WriteLine("Enter number 1: ");
string? Number1 = Console.ReadLine();
Console.WriteLine("Enter number 2: ");
string? Number2 = Console.ReadLine();


//

/*
FloatValidator validator = new FloatValidator();
float number;

try
{
    if (validator.TryParseFloat(Number1, out number))
    {
        //        float Number1Converted = float.Parse(Number1);
        Console.WriteLine($"The string '{Number1}' is a valid float. Parsed value: {number}");
        Number1Converted = float.Parse(Number1);
    }
    else
    {
        Console.WriteLine($"The string '{Number1}' is not a valid float.");
    }
}
catch (Exception ex)
{
    Console.WriteLine($"An error occurred: {ex.Message}");
}

//
//
*/
float Number1Converted = float.Parse(Number1);
float Number2Converted = float.Parse(Number2);
switch(OptionChoice){
    case "1":
        float Sum = Evaluator.Eval("+", Number1Converted, Number2Converted);
        Console.WriteLine($"{Number1Converted} + {Number2Converted} = {Sum}");
        break;
    case "2":
        float Subtract = Evaluator.Eval("-", Number1Converted, Number2Converted);
        Console.WriteLine($"{Number1Converted} - {Number2Converted} = {Subtract}");
        break;
    case "3":
        float Product = Evaluator.Eval("*", Number1Converted, Number2Converted);
        Console.WriteLine($"{Number1Converted} * {Number2Converted} = {Product}");
        break;
    case "4":
        float Division = Evaluator.Eval("/", Number1Converted, Number2Converted);
        Console.WriteLine($"{Number1Converted} / {Number2Converted} = {Division}");
        break;
    default:
        throw new Exception("unimplemented");
}