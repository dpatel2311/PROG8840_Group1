namespace Calculator
{
    public class Subtract : IBinaryOperator
    {
        public static float Eval(float lhs, float rhs)
        {
            return lhs - rhs;
        }

    }
}