using Calculator;

Prompts.PrintWelcomeMenu();
Prompts.PrintOptions();
Console.WriteLine("Enter operation number: ");
string? OptionChoice = Console.ReadLine();
Console.WriteLine("Enter number 1: ");
string? Number1 = Console.ReadLine();
Console.WriteLine("Enter number 2: ");
string? Number2 = Console.ReadLine();

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
    default:
        throw new Exception("unimplemented");
}