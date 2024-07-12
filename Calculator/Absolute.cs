namespace Calculator{
    public class Absolute: IBinaryOperator{
        public static float Eval(float lhs, float rhs){
            if (lhs < 0)
            {
                return lhs * -1;
            }
            return lhs;
        }
        
    }
}