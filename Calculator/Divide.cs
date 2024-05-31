namespace Calculator
{
    public class Divide : IBinaryOperator
    {
        public static float Eval(float lhs, float rhs)
        {
            return lhs / rhs;
        }

    }
}