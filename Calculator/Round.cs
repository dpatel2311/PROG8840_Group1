using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Calculator
{
    public class Round : IBinaryOperator
    {
        public static float Eval(float lhs, float rhs)
        {
            // Round lhs to 2 decimal places
            float result = (float)Math.Round(lhs, 2);
            Console.WriteLine(result);
            return result;
        }
    }
}