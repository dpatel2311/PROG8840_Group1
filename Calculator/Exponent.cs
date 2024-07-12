namespace Calculator{
    public class Exponent: IBinaryOperator{
        public static float Eval(float lhs, float rhs){
            return (int)Math.Pow(lhs,rhs);
        }
        
    }
}