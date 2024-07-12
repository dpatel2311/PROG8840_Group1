namespace Calculator{
    public class Percentage: IBinaryOperator{
        public static float Eval(float lhs, float rhs){
            return (lhs/rhs)*100;
        }
        
    }
}